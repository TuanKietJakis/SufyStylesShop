using BussinessObject.Model;
using BussinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace BussinessObject.SeedData
{
    public static class SeedDataCommentList
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            var datetime = DateTime.Now;
            modelBuilder.Entity<PostComment>().HasData(
                new PostComment
                {
                    PostCommentId = new Guid("D1E2F3A4-B5C6-47D8-9ABC-1234567890AB"), // ID cho Comment 1
                    PostId = new Guid("1F1021A2-FD1B-4142-B1DF-019E763053FB"), // ID bài viết tương ứng
                    UserId = new Guid("7ED45DA6-D22C-43C6-91F1-A1FD396CE414"), // ID người dùng đã bình luận
                    Content = "Bài viết rất hay, cảm ơn bạn đã chia sẻ!",
                    CreateDate = datetime,
                    UpdateDate = datetime,
                    IsDeleted = false,
                    LikeNumber = 0 // Số lượt thích cho bình luận
                },
                new PostComment
                {
                    PostCommentId = new Guid("E2F3A4B5-C6D7-48E9-ABCD-234567890ABC"), // ID cho Comment 2
                    PostId = new Guid("1F1021A2-FD1B-4142-B1DF-019E763053FB"),
                    UserId = new Guid("C76DD8D3-A7F4-4F95-BAEA-8E52B31730C6"), // ID người dùng đã bình luận
                    Content = "Mình cũng nghĩ như vậy, rất đáng để đọc!",
                    CreateDate = datetime,
                    UpdateDate = datetime,
                    IsDeleted = false,
                    LikeNumber = 0
                },
                new PostComment
                {
                    PostCommentId = new Guid("F3A4B5C6-D7E8-49FA-ABCD-34567890ABCD"), // ID cho Comment 3
                    PostId = new Guid("1F1021A2-FD1B-4142-B1DF-019E763053FB"), // ID bài viết tương ứng
                    UserId = new Guid("C33912D3-4525-43F1-B893-07580F2C4226"), // ID người dùng đã bình luận
                    Content = "Chủ đề rất thú vị, mong muốn có thêm thông tin chi tiết!",
                    CreateDate = datetime,
                    UpdateDate = datetime,
                    IsDeleted = false,
                    LikeNumber = 0
                },
                new PostComment
                {
                    PostCommentId = new Guid("D4E5F6A7-B8C9-4DAB-BBCB-56789ABCDE01"), // ID cho Comment 4
                    PostId = new Guid("1F1021A2-FD1B-4142-B1DF-019E763053FB"), // ID bài viết tương ứng
                    UserId = new Guid("3F2504E0-4F89-11D3-9A0C-0305E82C3301"), // ID người dùng đã bình luận
                    Content = "Bài viết rất thú vị, mình sẽ chia sẻ cho bạn bè!",
                    CreateDate = datetime,
                    UpdateDate = datetime,
                    IsDeleted = false,
                    LikeNumber = 1
                },
                // New Comment 2
                new PostComment
                {
                    PostCommentId = new Guid("C9D0E1A2-B2D3-4F88-9A12-67890F2F3BCD"), // ID cho Comment 5
                    PostId = new Guid("1F1021A2-FD1B-4142-B1DF-019E763053FB"), // ID bài viết tương ứng
                    UserId = new Guid("3F2504E0-4F89-11D3-9A0C-0305E82C3301"), // ID người dùng đã bình luận
                    Content = "Tuyệt vời, hy vọng sẽ có thêm nhiều bài viết như thế này!",
                    CreateDate = datetime,
                    UpdateDate = datetime,
                    IsDeleted = false,
                    LikeNumber = 2
                }
            );

            modelBuilder.Entity<PostCommentLike>().HasData(
    new PostCommentLike
    {
        UserId = Guid.Parse("3F2504E0-4F89-11D3-9A0C-0305E82C3301"), 
        CommentId = Guid.Parse("D4E5F6A7-B8C9-4DAB-BBCB-56789ABCDE01"), 
        LikedDate = new DateTime(2024, 1, 1, 8, 30, 0),
        IsDeleted = false
    },
    new PostCommentLike
    {
        UserId = Guid.Parse("3F2504E0-4F89-11D3-9A0C-0305E82C3301"), 
        CommentId = Guid.Parse("C9D0E1A2-B2D3-4F88-9A12-67890F2F3BCD"), 
        LikedDate = new DateTime(2024, 1, 1, 8, 45, 0),
        IsDeleted = false
    },
    new PostCommentLike
    {
        UserId = Guid.Parse("C76DD8D3-A7F4-4F95-BAEA-8E52B31730C6"), 
        CommentId = Guid.Parse("C9D0E1A2-B2D3-4F88-9A12-67890F2F3BCD"), 
        LikedDate = new DateTime(2024, 1, 2, 9, 15, 0),
        IsDeleted = false
    }
);



        }
    }
}
