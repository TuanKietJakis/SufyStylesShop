using BussinessObject.DTO;
using BussinessObject.DTO.Admin;
using BussinessObject.DTO.Post;
using BussinessObject.Models;
using Humanizer;
using ISUZU_NEXT.Server.Core.Extentions;
using MailKit.Search;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Repositories.IRepository;
using Repositories.Repository;
using Repository.IRepository;

namespace APIService.Service
{
    public class PostService
    {
        private readonly IPostRepository _postRepository;
        private readonly IUserRepository _userRepository;
        private readonly IPostCommentRepository _postCommentRepository;
        private readonly IPostLikeRepository _postLikeRepository;
        private readonly IPostBookmarkRepository _postBookmarkRepository;
       
        public PostService(
            IPostRepository postRepository, 
            IUserRepository userRepository,
            IPostCommentRepository postCommentRepository,
             IPostLikeRepository postLikeRepository,
            IPostBookmarkRepository postBookmarkRepository)
        {
            _postRepository = postRepository;
            _userRepository = userRepository;
            _postCommentRepository = postCommentRepository;
            _postLikeRepository = postLikeRepository;
            _postBookmarkRepository = postBookmarkRepository;
         
        }
       
        public async Task ChangeIsVisible(Guid postId, ApprovePost approvePost)
        {
            var post = await _postRepository.GetById(postId);
            if (post == null)
                throw new Exception("Post not found");
   
            post.CopyProperties(approvePost);

            _postRepository.Update(post);
            await _postRepository.SaveChanges();
        }


        public async Task<PostDetailDto> GetPostById(Guid postId, Guid currentUserId)
        {
            // Lấy thông tin bài viết
            var post = await _postRepository.GetById(postId);
            if (post == null)
                throw new Exception("Post not found");

      
            if (post.AuthorId != currentUserId)
            {
                post.ViewNumber++;
                _postRepository.Update(post);
                await _postRepository.SaveChanges();
            }
        
            var postDto = new PostDetailDto();
            postDto.CanLike = !post.PostLikes.Any(like => like.UserId == currentUserId);

            postDto.CopyProperties(post);

          
            bool isFollowed = post.Author.Following
                .Any(f => f.FollowingId == currentUserId && f.IsDeleted == false);
            
            postDto.Author.IsFollowed = isFollowed;
         
            // Ánh xạ danh sách người dùng đã thích bài viết
            postDto.PostLikes = new List<PostLikeDto>();
            foreach (var like in post.PostLikes)
            {
                var likedUser = await _userRepository.GetUserById(like.UserId);
                if (likedUser != null)
                {
                    var postUserDto = new PostUserDto
                    {
                        UserId = likedUser.UserId,
                        ProfileName = likedUser.ProfileName,
                        UrlImage = likedUser.UrlImage,
                       
                        IsFollowed = likedUser.Following
                            .Any(f => f.FollowingId == currentUserId && !f.IsDeleted)
                    };

                    var postLikeDto = new PostLikeDto
                    {
                        UserId = like.UserId,
                        PostId = like.PostId,
                        User = postUserDto,
                        IsDeleted = like.IsDeleted
                    };

                    postDto.PostLikes.Add(postLikeDto);
                }
            }
            postDto.PostComments = new List<PostCommentDto>();
            foreach (var comment in post.PostComments)
            {
                var commentUser = await _userRepository.GetUserById(comment.UserId);
                if (commentUser != null)
                {
                 
                    var isCommentUserFollowed = commentUser.Following
                        .Any(f => f.FollowingId == currentUserId && !f.IsDeleted);

                    bool hasLiked = comment.PostCommentLikes.Any(like => like.UserId == currentUserId);
                    var commentDto = new PostCommentDto
                    {
                        PostCommentId = comment.PostCommentId,
                        PostId = comment.PostId,
                        UserId = comment.UserId,
                        ProfileName = comment.User.ProfileName,
                        UrlImage = comment.User.UrlImage,
                        Content = comment.Content,
                        CreateDate = comment.CreateDate,
                        UpdateDate = comment.UpdateDate,
                        IsDeleted = comment.IsDeleted,
                        LikeNumber = comment.LikeNumber,
                       
                        IsFollow = isCommentUserFollowed,
                        CanLike = !hasLiked
                    };

                    postDto.PostComments.Add(commentDto);
                }
            }

            return postDto;
        }

        public async Task<PostDetailDto> CreatePost(PostCreateDto postCreateDto)
        {
            // Validate the user
            var user = await _userRepository.GetUserById(postCreateDto.AuthorId);
            if (user == null)
            {
                throw new Exception("User not found");
            }

            if (postCreateDto.PostProductTags != null && postCreateDto.PostProductTags.Any())
            {
                var productIds = postCreateDto.PostProductTags.Select(pt => pt.ProductId).ToList();
                var existingProducts = await _postRepository.GetProductsByIds(productIds);

                // Lọc ra các productId không tồn tại
                var invalidProductIds = productIds.Except(existingProducts.Select(p => p.ProductId)).ToList();
                if (invalidProductIds.Any())
                {
                    throw new Exception($"Products not found: {string.Join(", ", invalidProductIds)}");
                }
            }
            var post = Post.Create(postCreateDto);

            _postRepository.Add(post);
            await _postRepository.SaveChanges();

            var postDto = new PostDetailDto();
            postDto.CopyProperties(post);
            return postDto;
        }


        public async Task UpdatePost(Guid postId, PostUpdateDto postUpdateDto, Guid userId)
        {
            var post = await _postRepository.GetPostByUserIdAndPostId(userId, postId);
            if (post == null)
                throw new Exception("Post not found or user does not own this post");


            post.CopyProperties(postUpdateDto);

            if (postUpdateDto?.ImagePostsDto?.Any() == true)
            {
                // xóa khỏi list
                post.PostImages.Clear();

                // Thêm các hình ảnh mới vào danh sách ImagePosts
                foreach (var imageDto in postUpdateDto.ImagePostsDto)
                {
                    var imagePost = PostImage.Create(post.PostId, imageDto);
                    post.PostImages.Add(imagePost);
                    // đánh dấu là thêm mới
                    _postRepository.AddImage(imagePost);
                }
            }

            post.UpdateDate = DateTime.Now;
            post.IsVisible = postUpdateDto.IsVisible ?? null;
            _postRepository.Update(post);
            
            await _postRepository.SaveChanges();
        }

        public async Task DeletePost(Guid postId,Guid userId)
        {
            var post = await _postRepository.GetPostByUserIdAndPostId(userId, postId);
            if (post == null)
                throw new Exception("Post not found or user does not own this post");

            post.IsDeleted = true;
            post.IsVisible = false;
            _postRepository.Update(post);
            await _postRepository.SaveChanges();
        } 

        public async Task DeletePostAdmin(Guid postId)
        {
            var post = await _postRepository.GetById(postId);

            if (post == null)
                throw new Exception("Post not found");
          
            _postRepository.SoftDelete(postId);
            post.IsVisible = false;
            await _postRepository.SaveChanges();
        }

        public async Task<List<PostDto>> GetAll(Guid currentUserId)
        {
            var entityPages = await _postRepository
                         .GetAll()
                         .Where(p => p.IsVisible == true && p.IsDeleted == false)
                         .OrderByDescending(p => p.CreateDate)
                         .ToListAsync();

            var dtoPages = new List<PostDto>();

            foreach (var entityPage in entityPages)
            {
                var dto = new PostDto();

                // Kiểm tra mối quan hệ giữa người hiện tại và tác giả bài viết
                bool isFollowed = entityPage.Author.Following
                    .Any(f => f.FollowingId == currentUserId && f.IsDeleted == false);

                dto.CopyProperties(entityPage);
                dto.Author.IsFollowed = isFollowed;

                // Ánh xạ danh sách người dùng đã thích bài viết từ dữ liệu đã nạp
                dto.PostLikes = entityPage.PostLikes.Select(like => new PostLikeDto
                {
                    UserId = like.UserId,
                    PostId = like.PostId,
                    User = new PostUserDto
                    {
                        UserId = like.User.UserId,
                        ProfileName = like.User.ProfileName,
                        UrlImage = like.User.UrlImage,
                        IsFollowed = like.User.Following
                            .Any(f => f.FollowingId == currentUserId && !f.IsDeleted)
                    },
                    IsDeleted = like.IsDeleted
                }).ToList();

                // Ánh xạ danh sách comment của bài viết từ dữ liệu đã nạp
                dto.PostComments = entityPage.PostComments.Select(comment => new PostCommentDto
                {
                    PostCommentId = comment.PostCommentId,
                    PostId = comment.PostId,
                    UserId = comment.UserId,
                    ProfileName = comment.User.ProfileName,
                    UrlImage = comment.User.UrlImage,
                    Content = comment.Content,
                    CreateDate = comment.CreateDate,
                    UpdateDate = comment.UpdateDate,
                    IsDeleted = comment.IsDeleted,
                    LikeNumber = comment.LikeNumber,
                    IsFollow = comment.User.Following
                        .Any(f => f.FollowingId == currentUserId && !f.IsDeleted)
                }).ToList();

                dtoPages.Add(dto);
            }

            return dtoPages;
        }

       
        public async Task<List<PostDetailDto>> GetAllByUserId(Guid currentUserId, Guid userId)
        {
            var entityPages = await _postRepository.GetAllByUserId(userId)
                .OrderByDescending(p => p.CreateDate)
                .ToListAsync();

            var dtoPages = new List<PostDetailDto>();

            foreach (var entityPage in entityPages)
            {
                var dto = new PostDetailDto();

                // Kiểm tra mối quan hệ giữa người hiện tại và tác giả bài viết
                bool isFollowed = entityPage.Author.Following
                    .Any(f => f.FollowingId == currentUserId && f.IsDeleted == false);

                dto.CopyProperties(entityPage);
                dto.Author.IsFollowed = isFollowed;

                // Ánh xạ danh sách người dùng đã thích bài viết
                dto.PostLikes = entityPage.PostLikes.Select(like => new PostLikeDto
                {
                    UserId = like.UserId,
                    PostId = like.PostId,
                    User = new PostUserDto
                    {
                        UserId = like.User.UserId,
                        ProfileName = like.User.ProfileName,
                        UrlImage = like.User.UrlImage,
                        IsFollowed = like.User.Following.Any(f => f.FollowingId == currentUserId && !f.IsDeleted)
                    },
                    IsDeleted = like.IsDeleted
                }).ToList();

                // Ánh xạ danh sách comment của bài viết
                dto.PostComments = entityPage.PostComments.Select(comment => new PostCommentDto
                {
                    PostCommentId = comment.PostCommentId,
                    PostId = comment.PostId,
                    UserId = comment.UserId,
                    ProfileName = comment.User.ProfileName,
                    UrlImage = comment.User.UrlImage,
                    Content = comment.Content,
                    CreateDate = comment.CreateDate,
                    UpdateDate = comment.UpdateDate,
                    IsDeleted = comment.IsDeleted,
                    LikeNumber = comment.LikeNumber,
                    IsFollow = comment.User.Following.Any(f => f.FollowingId == currentUserId && !f.IsDeleted)
                }).ToList();

                dtoPages.Add(dto);
            }

            return dtoPages;
        }

       
        public async Task<List<PostBookmarkDto>> GetBookmarksByUserId(Guid userId)
        {
            
            var bookmarks = await _postBookmarkRepository.GetAllByUserId(userId).ToListAsync();
            var result = new List<PostBookmarkDto>();
            bookmarks.ForEach(b =>
            {
                var dto = new PostBookmarkDto();
                dto.CopyProperties(b);
                result.Add(dto);
            });
           
            return result;

        }
        public async Task<List<PostCommentDto>> GetCommentsByUserId(Guid userId)
        {
           
            var bookmarks = await _postCommentRepository.GetAllByUserId(userId).ToListAsync();
            var result = new List<PostCommentDto>();
            bookmarks.ForEach(b =>
            {
                var dto = new PostCommentDto();
                dto.CopyProperties(b);
                result.Add(dto);
            });

            return result;

        }
        public async Task AddBookmark(Guid postId, Guid userId)
        {
            var existingSave = await _postBookmarkRepository.GetById(userId, postId);
            if (existingSave != null)
            {
                existingSave.IsDeleted = false;
                _postBookmarkRepository.Update(existingSave);
            }
            else
            {
                var saveList = new PostBookmark
                {
                    UserId = userId,
                    PostId = postId,
                    SaveDate = DateTime.UtcNow,
                    IsDeleted = false
                };
                _postBookmarkRepository.Add(saveList);
            }

            
            await _postBookmarkRepository.SaveChanges();
        }
        public async Task Unbookmark(Guid postId, Guid userId)
        {
            var saveListEntry = await _postBookmarkRepository.GetById(userId, postId);
            if (saveListEntry == null)
            {
                throw new Exception("Post not found in save list.");
            }

            saveListEntry.IsDeleted = true;
            _postBookmarkRepository.Update(saveListEntry);
            await _postBookmarkRepository.SaveChanges();
        }

     
        public async Task<List<PostAdminDto>> GetAllPostAdmin()
        {
            var entityPages = await _postRepository.GetAll().OrderByDescending(p => p.CreateDate).ToListAsync();
            var dtoPages = new List<PostAdminDto>();
            foreach (var entityPage in entityPages)
            {
                var dto = new PostAdminDto();
                dto.CopyProperties(entityPage);
                dto.NumberLike = entityPage.PostLikes.Count(l => !l.IsDeleted);
                dto.NumberComment = entityPage.PostComments.Count(c => !c.IsDeleted);
                dto.PostImages = entityPage.PostImages.Select(image =>
                {
                    var postImageDto = new PostImageDto();
                    postImageDto.CopyProperties(image);
                    return postImageDto;
                }).ToList();
                dto.PostProductTags = entityPage.PostProductTags.Select(tag =>
                {
                    var postProductTagDto = new PostProductTagDto();
                    postProductTagDto.CopyProperties(tag);
                    return postProductTagDto;
                }).ToList();
                dtoPages.Add(dto);
            }
            return dtoPages;
        }
        public async Task<PostAdminDetailDto> GetPostAdminDetailById(Guid postId)
        {
            // Lấy thông tin bài viết
            var post = await _postRepository.GetById(postId);
            if (post == null)
                throw new Exception("Post not found");
            var postDetailDto = new PostAdminDetailDto();
            postDetailDto.CopyProperties(post);
            postDetailDto.PostLikes = post.PostLikes.Select(like =>
            {
                var postLikeAdminDto = new PostLikeAdminDto();
                postLikeAdminDto.CopyProperties(like);
                postLikeAdminDto.ProfileName = like.User?.ProfileName ?? string.Empty;
                postLikeAdminDto.UrlImage = like.User?.UrlImage;
                return postLikeAdminDto;
            }).ToList();
            postDetailDto.PostComments = post.PostComments.Select(comment =>
            {
                var postCommentDto = new PostCommentAdminDto();
                postCommentDto.CopyProperties(comment);
                return postCommentDto;
            }).ToList();
            postDetailDto.PostImages = post.PostImages.Select(image =>
            {
                var postImageDto = new PostImageDto();
                postImageDto.CopyProperties(image);
                return postImageDto;
            }).ToList();
            postDetailDto.PostProductTags = post.PostProductTags.Select(tag =>
            {
                var postProductTagDto = new PostProductTagDto();
                postProductTagDto.CopyProperties(tag);
                return postProductTagDto;
            }).ToList();
            return postDetailDto;
        }

        public async Task AddLike(Guid postId, Guid userId)
        {
            var post = await _postRepository.GetById(postId);
            if (post == null)
            {
                throw new Exception("Post not found");
            }

            var existingLike = await _postLikeRepository.GetById(userId, postId);

            // neu da ton tai thi thanh false
            // neu61 chua ton tai thi them moi voi true
            if (existingLike != null)
            {
                existingLike.IsDeleted = false;
                _postLikeRepository.Update(existingLike);
            }
            else
            {
                var like = new PostLike
                {
                    PostId = postId,
                    UserId = userId,
                    IsDeleted = false,
                };

                _postLikeRepository.Add(like);
            }


            await _postLikeRepository.SaveChanges();
        }

        public async Task RemoveLike(Guid postId, Guid userId)
        {
           

            var existingLike = await _postLikeRepository.GetById(userId, postId);

            if (existingLike == null)
            {
                throw new Exception("You have not liked this post.");
            }

            existingLike.IsDeleted = true;
            _postLikeRepository.Update(existingLike);
            await _postLikeRepository.SaveChanges();
        }

    }
}
