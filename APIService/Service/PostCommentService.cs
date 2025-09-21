using BussinessObject.DTO;
using BussinessObject.DTO.Comment;
using BussinessObject.DTO.Post;
using BussinessObject.Model;
using BussinessObject.Models;
using ISUZU_NEXT.Server.Core.Extentions;
using Microsoft.EntityFrameworkCore;
using Repositories.IRepository;
using Repositories.Repository;
using Repository.IRepository;

namespace APIService.Service
{
    public class PostCommentService
    {
        private readonly IPostCommentRepository _postCommentRepository;
        private readonly IPostRepository _postRepository;
        private readonly IUserRepository _userRepository;
        private readonly IUserCommentLikeRepository _userCommentLikeRepository;
        public PostCommentService(IPostCommentRepository postCommentRepository, IPostRepository postRepository, IUserRepository userRepository, IUserCommentLikeRepository userCommentLikeRepository)
        {
            _postCommentRepository = postCommentRepository;
            _postRepository = postRepository;
            _userRepository = userRepository;
            _userCommentLikeRepository = userCommentLikeRepository;
        }

        public async Task<CommentDto> GetCommentById(Guid commentId)
        {
            var comment = await _postCommentRepository.GetById(commentId);
            if (comment == null)
                throw new Exception("Comment not found");

            var commentDto = new CommentDto();
            commentDto.CopyProperties(comment);

            // Lấy danh sách người đã like comment
            commentDto.LikedUsers = comment.PostCommentLikes
                .Where(like => !like.IsDeleted) // Chỉ lấy like chưa bị xóa
                .Select(like => new CommentUserDto
                {
                    UserId = like.User.UserId,
                    ProfileName = like.User.ProfileName,
                    UrlImage = like.User.UrlImage
                }).ToList();

            return commentDto;
        }

        public async Task CreateComment(Guid userId, Guid postId, CommentCreateDto dto)
        {
            var post = await _postRepository.GetById(postId);
            if (post == null)
            {
                throw new Exception("Post not found");
            }

            var user = await _userRepository.GetUserById(userId);
            if (user == null)
            {
                throw new Exception("User not found");
            }

            var datetime = DateTime.Now;

            var comment = new PostComment
            {
                Content = dto.Content,
                Post = post,
                User = user,
                CreateDate = datetime,
                UpdateDate = datetime,
                IsDeleted = false,
                LikeNumber = 0
            };

            _postCommentRepository.Add(comment);
            await _postCommentRepository.SaveChanges();

        }
        public async Task UpdateComment(Guid commentId, Guid userId, CommentUpdateDto updateCommentDto)
        {
            var comment = await _postCommentRepository.GetById(commentId);
            if (comment == null)
                throw new Exception("Comment not found");
            if(comment.UserId != userId) throw new Exception("Comment not found");
            comment.CopyProperties(updateCommentDto);
            comment.UpdateDate = DateTime.Now;

            _postCommentRepository.Update(comment);
            await _postCommentRepository.SaveChanges();
        }
        public async Task DeleteComment(Guid userId,Guid commentId)
        {
            var comment = await _postCommentRepository.GetById(commentId);
            if (comment == null)
                throw new Exception("Comment not found");
            if (comment.UserId != userId) throw new Exception("Comment not found");
            _postCommentRepository.SoftDelete(commentId);
            await _postCommentRepository.SaveChanges();
        }
       

        public async Task LikeComment(Guid commentId, Guid userId)
        {
            var comment = await _postCommentRepository.GetById(commentId);
            if (comment == null)
            {
                throw new Exception("Comment not found.");
            }
            var user = await _userRepository.GetUserById(userId);
            if (user == null)
            {
                throw new Exception("User not found.");
            }

            var existingLike = await _userCommentLikeRepository.GetById(userId, commentId);
            if (existingLike != null)
            {
                existingLike.IsDeleted = false;
                _userCommentLikeRepository.Update(existingLike);
            }
            else
            {
                var like = new PostCommentLike
                {
                    CommentId = commentId,
                    UserId = userId,
                    LikedDate = DateTime.UtcNow,
                    IsDeleted = false
                };

                _userCommentLikeRepository.Add(like);

            }

      
            await _userCommentLikeRepository.SaveChanges();


            comment.LikeNumber++;
            _postCommentRepository.Update(comment);
            await _postCommentRepository.SaveChanges();
        }
        public async Task RemoveLikeComment(Guid commentId, Guid userId)
        {
            var comment = await _postCommentRepository.GetById(commentId);
            if (comment == null)
            {
                throw new Exception("Comment not found.");
            }
          
            var existingLike = await _userCommentLikeRepository.GetById(userId, commentId);
            if (existingLike == null)
            {
                throw new Exception("User not liked this comment.");
            }

            existingLike.IsDeleted = true;
            _userCommentLikeRepository.Update(existingLike);
            await _userCommentLikeRepository.SaveChanges();

            comment.LikeNumber--;
            _postCommentRepository.Update(comment);
            await _postCommentRepository.SaveChanges();
        }
    }
}
