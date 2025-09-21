using BussinessObject.Model;
using BussinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject.SeedData
{
    public class SeedDataProductComment
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductFeedback>().HasData(
                new ProductFeedback
                {

                    ProductFeedbackId = new Guid("A1234567-8901-2345-6789-ABCDE1234567"), // CommentId mẫu

                    ProductId = SeedDataProduct.GetIndex(0).ProductId, // ProductId mẫu
                    UserId = new Guid("3F2504E0-4F89-11D3-9A0C-0305E82C3301"), // UserId mẫu
                    Content = "Áo siu đẹp lun áaaa",
                    Rating = 5,
                    CreatedDate = DateTime.UtcNow,
                    IsDeleted = false,
                    IsReported = false
                },
                new ProductFeedback
                {

                    ProductFeedbackId = new Guid("B2345678-1234-5678-90AB-BCDEF1234567"), // CommentId mẫu

                    ProductId = SeedDataProduct.GetIndex(0).ProductId, // ProductId mẫu
                    UserId = new Guid("C33912D3-4525-43F1-B893-07580F2C4226"), // UserId mẫu
                    Content = "Trời ơi đẹp dữ luôn siu rì còm mên cho cả nhà nha",
                    Rating = 3,
                    CreatedDate = DateTime.UtcNow,
                    IsDeleted = false,
                    IsReported = false
                },
                //
                new ProductFeedback
                {
                    ProductFeedbackId = new Guid("D98384C3-79B9-420B-B9F7-44C618EDB1A2"), // CommentId mẫu
                    ProductId = SeedDataProduct.GetIndex(1).ProductId, // ProductId mẫu
                    UserId = new Guid("3F2504E0-4F89-11D3-9A0C-0305E82C3301"), // UserId mẫu
                    Content = "Không bàn cãi gì luônnnn",
                    Rating = 4,
                    CreatedDate = DateTime.UtcNow,
                    IsDeleted = false,
                    IsReported = false
                },
                new ProductFeedback
                {
                    ProductFeedbackId = new Guid("A741A3B8-125F-4894-927A-CE7B1B38F24A"), // CommentId mẫu
                    ProductId = SeedDataProduct.GetIndex(1).ProductId, // ProductId mẫu
                    UserId = new Guid("C33912D3-4525-43F1-B893-07580F2C4226"), // UserId mẫu
                    Content = "Đẹp xĩu up xĩu down",
                    Rating = 4,
                    CreatedDate = DateTime.UtcNow,
                    IsDeleted = false,
                    IsReported = false
                },
                new ProductFeedback
                {
                    ProductFeedbackId = Guid.NewGuid(), // CommentId mẫu
                    ProductId = SeedDataProduct.GetIndex(2).ProductId, // ProductId mẫu
                    UserId = new Guid("C76DD8D3-A7F4-4F95-BAEA-8E52B31730C6"), // UserId mẫu
                    Content = "Rộng quáaaaa",
                    Rating = 1,
                    CreatedDate = DateTime.UtcNow,
                    IsDeleted = false,
                    IsReported = false
                },
                new ProductFeedback
                {
                    ProductFeedbackId = Guid.NewGuid(), // CommentId mẫu
                    ProductId = SeedDataProduct.GetIndex(3).ProductId, // ProductId mẫu
                    UserId = new Guid("5EB29BD0-1C6B-42BF-A2C7-C71E05D4B10D"), // UserId mẫu
                    Content = "Dễ phối đồ, hợp với mọi loại phong cách",
                    Rating = 4,
                    CreatedDate = DateTime.UtcNow,
                    IsDeleted = false,
                    IsReported = false
                },
                new ProductFeedback
                {
                    ProductFeedbackId = Guid.NewGuid(), // CommentId mẫu
                    ProductId = SeedDataProduct.GetIndex(3).ProductId, // ProductId mẫu
                    UserId = new Guid("3F2504E0-4F89-11D3-9A0C-0305E82C3301"), // UserId mẫu
                    Content = "Xinhhhh",
                    Rating = 5,
                    CreatedDate = DateTime.UtcNow,
                    IsDeleted = false,
                    IsReported = false
                },
                new ProductFeedback
                {
                    ProductFeedbackId = Guid.NewGuid(), // CommentId mẫu
                    ProductId = SeedDataProduct.GetIndex(4).ProductId, // ProductId mẫu
                    UserId = new Guid("7ED45DA6-D22C-43C6-91F1-A1FD396CE414"), // UserId mẫu
                    Content = "Không còn gì để tả luôn, xuất sắc",
                    Rating = 5,
                    CreatedDate = DateTime.UtcNow,
                    IsDeleted = false,
                    IsReported = false
                }/*,
                new ProductFeedback
                {
                    ProductFeedbackId = Guid.NewGuid(), // CommentId mẫu
                    ProductId = SeedDataProduct.GetIndex(4).ProductId, // ProductId mẫu
                    UserId = new Guid("5EB29BD0-1C6B-42BF-A2C7-C71E05D4B10D"), // UserId mẫu
                    Content = "Tạm",
                    Rating = 2,
                    CreatedDate = DateTime.UtcNow,
                    IsDeleted = false,
                    IsReported = false
                },
                new ProductFeedback
                {
                    ProductFeedbackId = Guid.NewGuid(), // CommentId mẫu
                    ProductId = SeedDataProduct.GetIndex(5).ProductId, // ProductId mẫu
                    UserId = new Guid("5EB29BD0-1C6B-42BF-A2C7-C71E05D4B10D"), // UserId mẫu
                    Content = "Ổn nhaaaa",
                    Rating = 3,
                    CreatedDate = DateTime.UtcNow,
                    IsDeleted = false,
                    IsReported = false
                },
                new ProductFeedback
                {
                    ProductFeedbackId = Guid.NewGuid(), // CommentId mẫu
                    ProductId = SeedDataProduct.GetIndex(5).ProductId, // ProductId mẫu
                    UserId = new Guid("7ED45DA6-D22C-43C6-91F1-A1FD396CE414"), // UserId mẫu
                    Content = "Quá ổn luônnnnn",
                    Rating = 5,
                    CreatedDate = DateTime.UtcNow,
                    IsDeleted = false,
                    IsReported = false
                },
                new ProductFeedback
                {
                    ProductFeedbackId = Guid.NewGuid(), // CommentId mẫu
                    ProductId = SeedDataProduct.GetIndex(6).ProductId, // ProductId mẫu
                    UserId = new Guid("7ED45DA6-D22C-43C6-91F1-A1FD396CE414"), // UserId mẫu
                    Content = "Màu xấu so với ảnh",
                    Rating = 1,
                    CreatedDate = DateTime.UtcNow,
                    IsDeleted = false,
                    IsReported = false
                },
                new ProductFeedback
                {
                    ProductFeedbackId = Guid.NewGuid(), // CommentId mẫu
                    ProductId = SeedDataProduct.GetIndex(6).ProductId, // ProductId mẫu
                    UserId = new Guid("5EB29BD0-1C6B-42BF-A2C7-C71E05D4B10D"), // UserId mẫu
                    Content = "Sản phẩm không giống hình mọi người nên cân nhắc khi mua",
                    Rating = 2,
                    CreatedDate = DateTime.UtcNow,
                    IsDeleted = false,
                    IsReported = false
                },
                new ProductFeedback
                {
                    ProductFeedbackId = Guid.NewGuid(), // CommentId mẫu
                    ProductId = SeedDataProduct.GetIndex(7).ProductId, // ProductId mẫu
                    UserId = new Guid("3F2504E0-4F89-11D3-9A0C-0305E82C3301"), // UserId mẫu
                    Content = "Đẹp nhaa",
                    Rating = 5,
                    CreatedDate = DateTime.UtcNow,
                    IsDeleted = false,
                    IsReported = false
                },
                new ProductFeedback
                {
                    ProductFeedbackId = Guid.NewGuid(), // CommentId mẫu
                    ProductId = SeedDataProduct.GetIndex(7).ProductId, // ProductId mẫu
                    UserId = new Guid("C76DD8D3-A7F4-4F95-BAEA-8E52B31730C6"), // UserId mẫu
                    Content = "OK á nên mua thử",
                    Rating = 5,
                    CreatedDate = DateTime.UtcNow,
                    IsDeleted = false,
                    IsReported = false
                },
                new ProductFeedback
                {
                    ProductFeedbackId = Guid.NewGuid(), // CommentId mẫu
                    ProductId = SeedDataProduct.GetIndex(8).ProductId, // ProductId mẫu
                    UserId = new Guid("C33912D3-4525-43F1-B893-07580F2C4226"), // UserId mẫu
                    Content = "OK á nên mua thử",
                    Rating = 5,
                    CreatedDate = DateTime.UtcNow,
                    IsDeleted = false,
                    IsReported = false
                },
                new ProductFeedback
                {
                    ProductFeedbackId = Guid.NewGuid(), // CommentId mẫu
                    ProductId = SeedDataProduct.GetIndex(8).ProductId, // ProductId mẫu
                    UserId = new Guid("7ED45DA6-D22C-43C6-91F1-A1FD396CE414"), // UserId mẫu
                    Content = "Mua thử đi không thất vọng đâu nhe mọi người",
                    Rating = 4,
                    CreatedDate = DateTime.UtcNow,
                    IsDeleted = false,
                    IsReported = false
                },
                new ProductFeedback
                {
                    ProductFeedbackId = Guid.NewGuid(), // CommentId mẫu
                    ProductId = SeedDataProduct.GetIndex(9).ProductId, // ProductId mẫu
                    UserId = new Guid("5EB29BD0-1C6B-42BF-A2C7-C71E05D4B10D"), // UserId mẫu
                    Content = "Tuyệt vời luôn",
                    Rating = 4,
                    CreatedDate = DateTime.UtcNow,
                    IsDeleted = false,
                    IsReported = false
                },
                new ProductFeedback
                {
                    ProductFeedbackId = Guid.NewGuid(), // CommentId mẫu
                    ProductId = SeedDataProduct.GetIndex(10).ProductId, // ProductId mẫu
                    UserId = new Guid("72AB8BAE-9706-4709-9734-D6E986F539EA"), // UserId mẫu
                    Content = "Cũm oke á cả nhà vải đẹp lắm",
                    Rating = 5,
                    CreatedDate = DateTime.UtcNow,
                    IsDeleted = false,
                    IsReported = false
                },
                new ProductFeedback
                {
                    ProductFeedbackId = Guid.NewGuid(), // CommentId mẫu
                    ProductId = SeedDataProduct.GetIndex(11).ProductId, // ProductId mẫu
                    UserId = new Guid("5EB29BD0-1C6B-42BF-A2C7-C71E05D4B10D"), // UserId mẫu
                    Content = "Cá nhân tui thấy hơi chật, kiểu dáng cũm không quá đẹp",
                    Rating = 1,
                    CreatedDate = DateTime.UtcNow,
                    IsDeleted = false,
                    IsReported = false
                },
                new ProductFeedback
                {
                    ProductFeedbackId = Guid.NewGuid(), // CommentId mẫu
                    ProductId = SeedDataProduct.GetIndex(12).ProductId, // ProductId mẫu
                    UserId = new Guid("7ED45DA6-D22C-43C6-91F1-A1FD396CE414"), // UserId mẫu
                    Content = "Tạm hoi à mọi người nên cân nhắc khi mua nha",
                    Rating = 3,
                    CreatedDate = DateTime.UtcNow,
                    IsDeleted = false,
                    IsReported = false
                },
                new ProductFeedback
                {
                    ProductFeedbackId = Guid.NewGuid(), // CommentId mẫu
                    ProductId = SeedDataProduct.GetIndex(13).ProductId, // ProductId mẫu
                    UserId = new Guid("C76DD8D3-A7F4-4F95-BAEA-8E52B31730C6"), // UserId mẫu
                    Content = "Tạmmm",
                    Rating = 2,
                    CreatedDate = DateTime.UtcNow,
                    IsDeleted = false,
                    IsReported = false
                },
                new ProductFeedback
                {
                    ProductFeedbackId = Guid.NewGuid(), // CommentId mẫu
                    ProductId = SeedDataProduct.GetIndex(14).ProductId, // ProductId mẫu
                    UserId = new Guid("C33912D3-4525-43F1-B893-07580F2C4226"), // UserId mẫu
                    Content = "Diệu Kha nhooo",
                    Rating = 3,
                    CreatedDate = DateTime.UtcNow,
                    IsDeleted = false,
                    IsReported = false
                },
                new ProductFeedback
                {
                    ProductFeedbackId = Guid.NewGuid(), // CommentId mẫu
                    ProductId = SeedDataProduct.GetIndex(14).ProductId, // ProductId mẫu
                    UserId = new Guid("C76DD8D3-A7F4-4F95-BAEA-8E52B31730C6"), // UserId mẫu
                    Content = "Vải đẹp, thoải mái lắmmm",
                    Rating = 4,
                    CreatedDate = DateTime.UtcNow,
                    IsDeleted = false,
                    IsReported = false
                },
                new ProductFeedback
                {
                    ProductFeedbackId = Guid.NewGuid(), // CommentId mẫu
                    ProductId = SeedDataProduct.GetIndex(15).ProductId, // ProductId mẫu
                    UserId = new Guid("7ED45DA6-D22C-43C6-91F1-A1FD396CE414"), // UserId mẫu
                    Content = "mua thử đi cả nhà",
                    Rating = 4,
                    CreatedDate = DateTime.UtcNow,
                    IsDeleted = false,
                    IsReported = false
                },
                new ProductFeedback
                {
                    ProductFeedbackId = Guid.NewGuid(), // CommentId mẫu
                    ProductId = SeedDataProduct.GetIndex(16).ProductId, // ProductId mẫu
                    UserId = new Guid("5EB29BD0-1C6B-42BF-A2C7-C71E05D4B10D"), // UserId mẫu
                    Content = "mua thử đi cả nhà",
                    Rating = 5,
                    CreatedDate = DateTime.UtcNow,
                    IsDeleted = false,
                    IsReported = false
                },
                new ProductFeedback
                {
                    ProductFeedbackId = Guid.NewGuid(), // CommentId mẫu
                    ProductId = SeedDataProduct.GetIndex(17).ProductId, // ProductId mẫu
                    UserId = new Guid("3F2504E0-4F89-11D3-9A0C-0305E82C3301"), // UserId mẫu
                    Content = "Cũm cũm",
                    Rating = 2,
                    CreatedDate = DateTime.UtcNow,
                    IsDeleted = false,
                    IsReported = false
                },
                new ProductFeedback
                {
                    ProductFeedbackId = Guid.NewGuid(), // CommentId mẫu
                    ProductId = SeedDataProduct.GetIndex(18).ProductId, // ProductId mẫu
                    UserId = new Guid("7ED45DA6-D22C-43C6-91F1-A1FD396CE414"), // UserId mẫu
                    Content = "Tạm thôi nha",
                    Rating = 2,
                    CreatedDate = DateTime.UtcNow,
                    IsDeleted = false,
                    IsReported = false
                },
                new ProductFeedback
                {
                    ProductFeedbackId = Guid.NewGuid(), // CommentId mẫu
                    ProductId = SeedDataProduct.GetIndex(18).ProductId, // ProductId mẫu
                    UserId = new Guid("C76DD8D3-A7F4-4F95-BAEA-8E52B31730C6"), // UserId mẫu
                    Content = "Oki lắm á",
                    Rating = 5,
                    CreatedDate = DateTime.UtcNow,
                    IsDeleted = false,
                    IsReported = false
                },
                new ProductFeedback
                {
                    ProductFeedbackId = Guid.NewGuid(), // CommentId mẫu
                    ProductId = SeedDataProduct.GetIndex(19).ProductId, // ProductId mẫu
                    UserId = new Guid("C33912D3-4525-43F1-B893-07580F2C4226"), // UserId mẫu
                    Content = "Oki lắm á",
                    Rating = 5,
                    CreatedDate = DateTime.UtcNow,
                    IsDeleted = false,
                    IsReported = false
                },
                new ProductFeedback
                {
                    ProductFeedbackId = Guid.NewGuid(), // CommentId mẫu
                    ProductId = SeedDataProduct.GetIndex(20).ProductId, // ProductId mẫu
                    UserId = new Guid("C76DD8D3-A7F4-4F95-BAEA-8E52B31730C6"), // UserId mẫu
                    Content = "Xấu lắm nha",
                    Rating = 1,
                    CreatedDate = DateTime.UtcNow,
                    IsDeleted = false,
                    IsReported = false
                },
                new ProductFeedback
                {
                    ProductFeedbackId = Guid.NewGuid(), // CommentId mẫu
                    ProductId = SeedDataProduct.GetIndex(21).ProductId, // ProductId mẫu
                    UserId = new Guid("7ED45DA6-D22C-43C6-91F1-A1FD396CE414"), // UserId mẫu
                    Content = "hàng lỗi, mong được giải quyết!!!",
                    Rating = 1,
                    CreatedDate = DateTime.UtcNow,
                    IsDeleted = false,
                    IsReported = false
                },
                new ProductFeedback
                {
                    ProductFeedbackId = Guid.NewGuid(), // CommentId mẫu
                    ProductId = SeedDataProduct.GetIndex(21).ProductId, // ProductId mẫu
                    UserId = new Guid("5EB29BD0-1C6B-42BF-A2C7-C71E05D4B10D"), // UserId mẫu
                    Content = "Tạm",
                    Rating = 3,
                    CreatedDate = DateTime.UtcNow,
                    IsDeleted = false,
                    IsReported = false
                },
                new ProductFeedback
                {
                    ProductFeedbackId = Guid.NewGuid(), // CommentId mẫu
                    ProductId = SeedDataProduct.GetIndex(22).ProductId, // ProductId mẫu
                    UserId = new Guid("3F2504E0-4F89-11D3-9A0C-0305E82C3301"), // UserId mẫu
                    Content = "Tạm",
                    Rating = 3,
                    CreatedDate = DateTime.UtcNow,
                    IsDeleted = false,
                    IsReported = false
                },
                new ProductFeedback
                {
                    ProductFeedbackId = Guid.NewGuid(), // CommentId mẫu
                    ProductId = SeedDataProduct.GetIndex(23).ProductId, // ProductId mẫu
                    UserId = new Guid("72AB8BAE-9706-4709-9734-D6E986F539EA"), // UserId mẫu
                    Content = "Vải thô mặc không thoải mái",
                    Rating = 2,
                    CreatedDate = DateTime.UtcNow,
                    IsDeleted = false,
                    IsReported = false
                },
                new ProductFeedback
                {
                    ProductFeedbackId = Guid.NewGuid(), // CommentId mẫu
                    ProductId = SeedDataProduct.GetIndex(24).ProductId, // ProductId mẫu
                    UserId = new Guid("72AB8BAE-9706-4709-9734-D6E986F539EA"), // UserId mẫu
                    Content = "Chất liệu tốttt",
                    Rating = 5,
                    CreatedDate = DateTime.UtcNow,
                    IsDeleted = false,
                    IsReported = false
                },
                new ProductFeedback
                {
                    ProductFeedbackId = Guid.NewGuid(), // CommentId mẫu
                    ProductId = SeedDataProduct.GetIndex(25).ProductId, // ProductId mẫu
                    UserId = new Guid("3F2504E0-4F89-11D3-9A0C-0305E82C3301"), // UserId mẫu
                    Content = "Dịu nhooo",
                    Rating = 5,
                    CreatedDate = DateTime.UtcNow,
                    IsDeleted = false,
                    IsReported = false
                },
                new ProductFeedback
                {
                    ProductFeedbackId = Guid.NewGuid(), // CommentId mẫu
                    ProductId = SeedDataProduct.GetIndex(26).ProductId, // ProductId mẫu
                    UserId = new Guid("3F2504E0-4F89-11D3-9A0C-0305E82C3301"), // UserId mẫu
                    Content = "Dịuuuuuuu",
                    Rating = 5,
                    CreatedDate = DateTime.UtcNow,
                    IsDeleted = false,
                    IsReported = false
                },
                new ProductFeedback
                {
                    ProductFeedbackId = Guid.NewGuid(), // CommentId mẫu
                    ProductId = SeedDataProduct.GetIndex(27).ProductId, // ProductId mẫu
                    UserId = new Guid("7ED45DA6-D22C-43C6-91F1-A1FD396CE414"), // UserId mẫu
                    Content = "6677",
                    Rating = 1,
                    CreatedDate = DateTime.UtcNow,
                    IsDeleted = false,
                    IsReported = false
                },
                new ProductFeedback
                {
                    ProductFeedbackId = Guid.NewGuid(), // CommentId mẫu
                    ProductId = SeedDataProduct.GetIndex(28).ProductId, // ProductId mẫu
                    UserId = new Guid("7ED45DA6-D22C-43C6-91F1-A1FD396CE414"), // UserId mẫu
                    Content = "6 quắc",
                    Rating = 1,
                    CreatedDate = DateTime.UtcNow,
                    IsDeleted = false,
                    IsReported = false
                },
                new ProductFeedback
                {
                    ProductFeedbackId = Guid.NewGuid(), // CommentId mẫu
                    ProductId = SeedDataProduct.GetIndex(28).ProductId, // ProductId mẫu
                    UserId = new Guid("C33912D3-4525-43F1-B893-07580F2C4226"), // UserId mẫu
                    Content = "Sản phẩm tốt",
                    Rating = 5,
                    CreatedDate = DateTime.UtcNow,
                    IsDeleted = false,
                    IsReported = false
                },
                new ProductFeedback
                {
                    ProductFeedbackId = Guid.NewGuid(), // CommentId mẫu
                    ProductId = SeedDataProduct.GetIndex(29).ProductId, // ProductId mẫu
                    UserId = new Guid("C76DD8D3-A7F4-4F95-BAEA-8E52B31730C6"), // UserId mẫu
                    Content = "Sản phẩm phù hợp vs dá tìn",
                    Rating = 4,
                    CreatedDate = DateTime.UtcNow,
                    IsDeleted = false,
                    IsReported = false
                },
                new ProductFeedback
                {
                    ProductFeedbackId = Guid.NewGuid(), // CommentId mẫu
                    ProductId = SeedDataProduct.GetIndex(30).ProductId, // ProductId mẫu
                    UserId = new Guid("7ED45DA6-D22C-43C6-91F1-A1FD396CE414"), // UserId mẫu
                    Content = "Sản phẩm đẹp nhoooo",
                    Rating = 5,
                    CreatedDate = DateTime.UtcNow,
                    IsDeleted = false,
                    IsReported = false
                },
                new ProductFeedback
                {
                    ProductFeedbackId = Guid.NewGuid(), // CommentId mẫu
                    ProductId = SeedDataProduct.GetIndex(31).ProductId, // ProductId mẫu
                    UserId = new Guid("7ED45DA6-D22C-43C6-91F1-A1FD396CE414"), // UserId mẫu
                    Content = "Sản phẩm đẹp nhoooo",
                    Rating = 5,
                    CreatedDate = DateTime.UtcNow,
                    IsDeleted = false,
                    IsReported = false
                },
                new ProductFeedback
                {
                    ProductFeedbackId = Guid.NewGuid(), // CommentId mẫu
                    ProductId = SeedDataProduct.GetIndex(32).ProductId, // ProductId mẫu
                    UserId = new Guid("5EB29BD0-1C6B-42BF-A2C7-C71E05D4B10D"), // UserId mẫu
                    Content = "tạm hoi vải hơi cứng",
                    Rating = 2,
                    CreatedDate = DateTime.UtcNow,
                    IsDeleted = false,
                    IsReported = false
                },
                new ProductFeedback
                {

                    ProductFeedbackId = Guid.NewGuid(), // CommentId mẫu
                    ProductId = SeedDataProduct.GetIndex(33).ProductId, // ProductId mẫu
                    UserId = new Guid("5EB29BD0-1C6B-42BF-A2C7-C71E05D4B10D"), // UserId mẫu
                    Content = "Không đẹp cũm không xấu",
                    Rating = 3,
                    CreatedDate = DateTime.UtcNow,
                    IsDeleted = false,
                    IsReported = false
                },
                new ProductFeedback
                {
                    ProductFeedbackId = Guid.NewGuid(), // CommentId mẫu
                    ProductId = SeedDataProduct.GetIndex(33).ProductId, // ProductId mẫu
                    UserId = new Guid("7ED45DA6-D22C-43C6-91F1-A1FD396CE414"), // UserId mẫu
                    Content = "Nô còm mên",
                    Rating = 1,
                    CreatedDate = DateTime.UtcNow,
                    IsDeleted = false,
                    IsReported = false
                },
                new ProductFeedback
                {
                    ProductFeedbackId = Guid.NewGuid(), // CommentId mẫu
                    ProductId = SeedDataProduct.GetIndex(34).ProductId, // ProductId mẫu
                    UserId = new Guid("7ED45DA6-D22C-43C6-91F1-A1FD396CE414"), // UserId mẫu
                    Content = "Nô còm mên",
                    Rating = 1,
                    CreatedDate = DateTime.UtcNow,
                    IsDeleted = false,
                    IsReported = false
                },
                new ProductFeedback
                {
                    ProductFeedbackId = Guid.NewGuid(), // CommentId mẫu
                    ProductId = SeedDataProduct.GetIndex(35).ProductId, // ProductId mẫu
                    UserId = new Guid("C76DD8D3-A7F4-4F95-BAEA-8E52B31730C6"), // UserId mẫu
                    Content = "Tốt lắm nhaaa",
                    Rating = 5,
                    CreatedDate = DateTime.UtcNow,
                    IsDeleted = false,
                    IsReported = false
                },
                new ProductFeedback
                {
                    ProductFeedbackId = Guid.NewGuid(), // CommentId mẫu
                    ProductId = SeedDataProduct.GetIndex(36).ProductId, // ProductId mẫu
                    UserId = new Guid("C76DD8D3-A7F4-4F95-BAEA-8E52B31730C6"), // UserId mẫu
                    Content = "Tốt lắm nhaaa",
                    Rating = 5,
                    CreatedDate = DateTime.UtcNow,
                    IsDeleted = false,
                    IsReported = false
                },
                new ProductFeedback
                {
                    ProductFeedbackId = Guid.NewGuid(), // CommentId mẫu
                    ProductId = SeedDataProduct.GetIndex(37).ProductId, // ProductId mẫu
                    UserId = new Guid("C76DD8D3-A7F4-4F95-BAEA-8E52B31730C6"), // UserId mẫu
                    Content = "Tốt lắm nhaaa",
                    Rating = 5,
                    CreatedDate = DateTime.UtcNow,
                    IsDeleted = false,
                    IsReported = false
                },
                new ProductFeedback
                {
                    ProductFeedbackId = Guid.NewGuid(), // CommentId mẫu
                    ProductId = SeedDataProduct.GetIndex(38).ProductId, // ProductId mẫu
                    UserId = new Guid("C76DD8D3-A7F4-4F95-BAEA-8E52B31730C6"), // UserId mẫu
                    Content = "chán lắm đừng mua",
                    Rating = 1,
                    CreatedDate = DateTime.UtcNow,
                    IsDeleted = false,
                    IsReported = false
                },
                new ProductFeedback
                {
                    ProductFeedbackId = Guid.NewGuid(), // CommentId mẫu
                    ProductId = SeedDataProduct.GetIndex(39).ProductId, // ProductId mẫu
                    UserId = new Guid("C76DD8D3-A7F4-4F95-BAEA-8E52B31730C6"), // UserId mẫu
                    Content = "chán lắm đừng mua",
                    Rating = 1,

                    CreatedDate = DateTime.UtcNow,
                    IsDeleted = false,
                    IsReported = false
                }*/
            );
        }

    }
}
