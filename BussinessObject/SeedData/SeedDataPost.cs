using BussinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject.SeedData
{
    public static class SeedDataPost
    {
        private static readonly Post[] Posts = new Post[]
        {
                      
/*            new Post
    {
        PostId = Guid.NewGuid(), //1
        AuthorId = SeedDataUser.GetIndex(3).UserId,
        Title = "Thác nước hùng vĩ",
        Content = "#thácnước",
        PageTitle = "Chiêm ngưỡng thác nước đẹp",
        MetaDescription = "Khám phá vẻ đẹp thiên nhiên tại thác nước hùng vĩ.",
        ViewNumber = 150,
        ShareNumber = 40,

        UrlHandle = "thac-nuoc",
        CreateDate = DateTime.UtcNow,
        UpdateDate = DateTime.UtcNow,
        IsVisible = true,
        IsDeleted = false,
        IsReported = false,
        ReasonReport = null
    },*//*            new Post
    {
        PostId = Guid.NewGuid(), //2
        AuthorId = SeedDataUser.GetIndex(1).UserId,
        Title = "Cảnh biển",
        Content = "#biểnđẹp",
        PageTitle = "Thăm quan bãi biển đẹp",
        MetaDescription = "Hành trình khám phá vẻ đẹp biển cả.",
        ViewNumber = 85,
        ShareNumber = 20,

        UrlHandle = "canh-bien",
        CreateDate = DateTime.UtcNow,
        UpdateDate = DateTime.UtcNow,
        IsVisible = true,
        IsDeleted = false,
        IsReported = false,
        ReasonReport = null
    },
            new Post
            {
                PostId = Guid.NewGuid(), //3
                AuthorId = SeedDataUser.GetIndex(1).UserId,
                Title = "Cảnh biển",
                Content = "#biểnđẹp",
                PageTitle = "Thăm quan bãi biển đẹp",
                MetaDescription = "Hành trình khám phá vẻ đẹp biển cả.",
                ViewNumber = 85,
                ShareNumber = 20,
       
                UrlHandle = "canh-bien",
                CreateDate = DateTime.UtcNow,
                UpdateDate = DateTime.UtcNow,
                IsVisible = true,
                IsDeleted = false,
                IsReported = false,
                ReasonReport = null
            },*/

/*            new Post
            {
                PostId = Guid.Parse("9A1021A2-FD1B-4142-B1DF-019E763053FB"), //4
                AuthorId = SeedDataUser.GetIndex(3).UserId,
                Title = "Thác nước hùng vĩ",
                Content = "#thácnước",
                PageTitle = "Chiêm ngưỡng thác nước đẹp",
                MetaDescription = "Khám phá vẻ đẹp thiên nhiên tại thác nước hùng vĩ.",
                ViewNumber = 150,
                ShareNumber = 40,
              
                UrlHandle = "thac-nuoc",
                CreateDate = DateTime.UtcNow,
                UpdateDate = DateTime.UtcNow,
                IsVisible = true,
                IsDeleted = false,
                IsReported = false,
                ReasonReport = null
            },*/
            /*new Post
            {
                PostId = Guid.Parse("7B1021A2-FD1B-4142-B1DF-019E763053FB"), //5
                AuthorId = SeedDataUser.GetIndex(1).UserId,
                Title = "Cảnh biển",
                Content = "#biểnđẹp",
                PageTitle = "Thăm quan bãi biển đẹp",
                MetaDescription = "Hành trình khám phá vẻ đẹp biển cả.",
                ViewNumber = 85,
                ShareNumber = 20,
   
                UrlHandle = "canh-bien",
                CreateDate = DateTime.UtcNow,
                UpdateDate = DateTime.UtcNow,
                IsVisible = true,
                IsDeleted = false,
                IsReported = false,
                ReasonReport = null
            },
            new Post
            {
                PostId = Guid.Parse("7D1021A2-FD1B-4142-B1DF-019E763053FB"), //6
                AuthorId = SeedDataUser.GetIndex(2).UserId,
                Title = "Vườn quốc gia",
                Content = "#vườnquốcgia",
                PageTitle = "Khám phá vườn quốc gia",
                MetaDescription = "Một chuyến hành trình đến vườn quốc gia xanh tươi.",
                ViewNumber = 105,
                ShareNumber = 35,
          
                UrlHandle = "vuon-quoc-gia",
                CreateDate = DateTime.UtcNow,
                UpdateDate = DateTime.UtcNow,
                IsVisible = true,
                IsDeleted = false,
                IsReported = false,
                ReasonReport = null
            },
            new Post
            {
                PostId = Guid.Parse("8A1021A2-FD1B-4142-B1DF-019E763053FB"), // 7
                AuthorId = SeedDataUser.GetIndex(4).UserId,
                Title = "Phong cảnh đồi núi",
                Content = "#đốinúi",
                PageTitle = "Khám phá những ngọn đồi kỳ vĩ",
                MetaDescription = "Những đồi núi huyền bí và kỳ vĩ trong hành trình du lịch.",
                ViewNumber = 98,
                ShareNumber = 22,
            
                UrlHandle = "phong-canh-doi-nui",
                CreateDate = DateTime.UtcNow,
                UpdateDate = DateTime.UtcNow,
                IsVisible = true,
                IsDeleted = false,
                IsReported = false,
                ReasonReport = null
            },
            new Post
            {
                PostId = Guid.Parse("4C1021A2-FD1B-4142-B1DF-019E763053FB"), // 8
                AuthorId = SeedDataUser.GetIndex(0).UserId,
                Title = "Chợ nổi Cái Răng",
                Content = "#chợnổi",
                PageTitle = "Trải nghiệm chợ nổi Cái Răng",
                MetaDescription = "Chợ nổi Cái Răng - một trải nghiệm độc đáo tại Cần Thơ.",
                ViewNumber = 200,
                ShareNumber = 50,
              
                UrlHandle = "cho-noi-cai-rang",
                CreateDate = DateTime.UtcNow,
                UpdateDate = DateTime.UtcNow,
                IsVisible = true,
                IsDeleted = false,
                IsReported = false,
                ReasonReport = null
            },*/
            new Post
            {
                PostId = Guid.Parse("B9F3D0D4-6F68-400F-BAD2-9B83EB673ACA"), // 8
                AuthorId = Guid.Parse("3F2504E0-4F89-11D3-9A0C-0305E82C3301"),
                Title = "Chạy bộ nè",
                Content = "Chạy bộ với tôi khôngggg",
                PageTitle = "Chạy bộ nè",
                MetaDescription = "Chạy bộ với tôi khôngggg",
                ViewNumber = 200,

                UrlHandle = "ch-y-b-n",
                CreateDate = DateTime.UtcNow.AddDays(-4),
                UpdateDate = DateTime.UtcNow.AddDays(-4),

                IsVisible = true,
                IsDeleted = false,
                IsReported = false,
                ReasonReport = null
            },
            new Post
            {
                PostId = Guid.Parse("8EB434BB-0E29-4A55-BE4A-77D710EBD6A6"), // 8
                AuthorId = Guid.Parse("3F2504E0-4F89-11D3-9A0C-0305E82C3301"),
                Title = "Dạo phố với tui khum",
                Content = "alone",
                PageTitle = "Dạo phố với tui khum",
                MetaDescription = "alone",
                ViewNumber = 200,
      
                UrlHandle = "d-o-ph-v-i-tui-khum",
                CreateDate = DateTime.UtcNow.AddDays(-5),
                UpdateDate = DateTime.UtcNow.AddDays(-5),
                IsVisible = true,
                IsDeleted = false,
                IsReported = false,
                ReasonReport = null
            },
            new Post
            {
                PostId = Guid.Parse("607B4DB7-57F8-42EC-A8BA-EB3BE8E126BB"), // 8
                AuthorId = Guid.Parse("C33912D3-4525-43F1-B893-07580F2C4226"),
                Title = "Oufit dạo phố",
                Content = "Áo trễ vai đơn giản và bó hoa bạn thích",
                PageTitle = "Oufit dạo phố",
                MetaDescription = "Áo trễ vai đơn giản và bó hoa bạn thích",
                ViewNumber = 200,
              
                UrlHandle = "oufit-d-o-ph",
                CreateDate = DateTime.UtcNow,
                UpdateDate = DateTime.UtcNow,
                IsVisible = true,
                IsDeleted = false,
                IsReported = false,
                ReasonReport = null
            },
            new Post
            {
                PostId = Guid.Parse("BCB12B9B-D374-4505-9051-3A7CDE836F21"), // 8
                AuthorId = Guid.Parse("C33912D3-4525-43F1-B893-07580F2C4226"),
                Title = "Đốm dễ thương nè",
                Content = "Bé Đốm 3 tủi chào cô chú nhaaa",
                PageTitle = "Đốm dễ thương nè",
                MetaDescription = "Bé Đốm 3 tủi chào cô chú nhaaa",
                ViewNumber = 200,
               
                UrlHandle = "m-d-th-ng-n",
                CreateDate = DateTime.UtcNow.AddDays(-10),
                UpdateDate =DateTime.UtcNow.AddDays(-10),
                IsVisible = true,
                IsDeleted = false,
                IsReported = false,
                ReasonReport = null
            },
            new Post
            {
                PostId = Guid.Parse("DC9C8380-FD04-4D0B-AAA4-41187D4E49F9"), // 8
                AuthorId = Guid.Parse("C76DD8D3-A7F4-4F95-BAEA-8E52B31730C6"),
                Title = "Em xinggg",
                Content = "Chiếc áo basic nhưng đẹp dã man",
                PageTitle = "Em xinggg",
                MetaDescription = "Chiếc áo basic nhưng đẹp dã man",
                ViewNumber = 200,
               
                UrlHandle = "em-xinggg",
                CreateDate = DateTime.UtcNow.AddDays(-12),
                UpdateDate = DateTime.UtcNow.AddDays(-12),
                IsVisible = true,
                IsDeleted = false,
                IsReported = false,
                ReasonReport = null
            },
            new Post
            {
                PostId = Guid.Parse("3C9A7354-B558-4D44-959D-63142BEB0A0E"), // 8
                AuthorId = Guid.Parse("C76DD8D3-A7F4-4F95-BAEA-8E52B31730C6"),
                Title = "Biển và em",
                Content = "Chiếc đầm trắng xinh iu tôn dáng cực kì luônnn",
                PageTitle = "Biển và em",
                MetaDescription = "Chiếc đầm trắng xinh iu tôn dáng cực kì luônnn",
                ViewNumber = 200,
              
                UrlHandle = "bi-n-v-em",
               CreateDate = DateTime.UtcNow.AddDays(-15),
                UpdateDate = DateTime.UtcNow.AddDays(-15),
                IsVisible = true,
                IsDeleted = false,
                IsReported = false,
                ReasonReport = null
            },
            new Post
            {
                PostId = Guid.Parse("906C61A2-32AA-4F19-A842-3DF864B7411D"), // 8
                AuthorId = Guid.Parse("7ED45DA6-D22C-43C6-91F1-A1FD396CE414"),
                Title = "Sáng chủ nhật",
                Content = "Áo sơ mi là lựa chọn an toàn cho oufit của bạn vào buổi sáng của ngày nghỉ khi đi coffee cùng bạn bè",
                PageTitle = "Sáng chủ nhật",
                MetaDescription = "Áo sơ mi là lựa chọn an toàn cho oufit của bạn vào buổi sáng của ngày nghỉ khi đi coffee cùng bạn bè",
                ViewNumber = 100,
               
                UrlHandle = "s-ng-ch-nh-t",
               CreateDate = DateTime.UtcNow.AddDays(-17),
                UpdateDate = DateTime.UtcNow.AddDays(-17),
                IsVisible = true,
                IsDeleted = false,
                IsReported = false,
                ReasonReport = null
            },
            new Post
            {
                PostId = Guid.Parse("71EAF445-8A8A-4755-90E3-23A7AE3B9227"), // 8
                AuthorId = Guid.Parse("5EB29BD0-1C6B-42BF-A2C7-C71E05D4B10D"),
                Title = "Hiiiii",
                Content = "Croptop với quần Jeans over hợp luôn",
                PageTitle = "Hiiiii",
                MetaDescription = "Croptop với quần Jeans over hợp luôn",
                ViewNumber = 100,
   
                UrlHandle = "hiiiii",
                CreateDate = DateTime.UtcNow.AddDays(-18),
                UpdateDate = DateTime.UtcNow.AddDays(-18),
                IsVisible = true,
                IsDeleted = false,
                IsReported = false,
                ReasonReport = null
            },
            new Post
            {
                PostId = Guid.Parse("8A687930-5A59-4F74-A93C-6DEB89D049CF"), // 8
                AuthorId = Guid.Parse("7ED45DA6-D22C-43C6-91F1-A1FD396CE414"),
                Title = "Sơ mi trắng",
                Content = "Vải thoáng mái mê cực",
                PageTitle = "Sơ mi trắng",
                MetaDescription = "Vải thoáng mái mê cực",
                ViewNumber = 100,
            

                UrlHandle = "hiiiii",
                CreateDate = DateTime.UtcNow,
                UpdateDate = DateTime.UtcNow,
                IsVisible = true,
                IsDeleted = false,
                IsReported = false,
                ReasonReport = null
            },
            new Post
            {
                PostId = Guid.Parse("253C48DC-A4DE-47FB-A36D-39D6CFD914B1"), // 8
                AuthorId = Guid.Parse("5EB29BD0-1C6B-42BF-A2C7-C71E05D4B10D"),
                Title = "2",
                Content = "Croptop với chân váy cũm xinh lắm nòoo",
                PageTitle = "2",
                MetaDescription = "Croptop với chân váy cũm xinh lắm nòoo",
                ViewNumber = 100,
           

                UrlHandle = "2",
              CreateDate = DateTime.UtcNow.AddDays(-19),
                UpdateDate = DateTime.UtcNow.AddDays(-19),
                IsVisible = true,
                IsDeleted = false,
                IsReported = false,
                ReasonReport = null
            },
            new Post
            {
                PostId = Guid.Parse("1F1021A2-FD1B-4142-B1DF-019E763053FB"), // 8
                AuthorId = Guid.Parse("5EB29BD0-1C6B-42BF-A2C7-C71E05D4B10D"),
                Title = "2",
                Content = "Cơm nước gì chưa người đẹp",
                PageTitle = "2",
                MetaDescription = "Croptop với chân váy cũm xinh lắm nòoo",
                ViewNumber = 100,
            

                UrlHandle = "2",
                CreateDate = DateTime.UtcNow,
                UpdateDate = DateTime.UtcNow,
                IsVisible = true,
                IsDeleted = false,
                IsReported = false,
                ReasonReport = null
            },
            new Post
            {
                PostId = Guid.Parse("9A1021A2-FD1B-4142-B1DF-019E763053FB"), // 8
                AuthorId = Guid.Parse("5EB29BD0-1C6B-42BF-A2C7-C71E05D4B10D"),
                Title = "Hi bbi",
                Content = "Cục cưng ơi anh qua chở em đi ăn kem nò",
                PageTitle = "Hi bbi",
                MetaDescription = "Cục cưng ơi anh qua chở em đi ăn kem nò",
                ViewNumber = 100,

                UrlHandle = "2",
                CreateDate = DateTime.UtcNow.AddDays(-1),
                UpdateDate = DateTime.UtcNow.AddDays(-1),
                IsVisible = true,
                IsDeleted = false,
                IsReported = false,
                ReasonReport = null
            },
            new Post
            {
                PostId = Guid.Parse("7B1021A2-FD1B-4142-B1DF-019E763053FB"), //5
                AuthorId = SeedDataUser.GetIndex(1).UserId,
                Title = "Cảnh núi",
                Content = "#biểnđẹp",
                PageTitle = "Thăm quan núi đẹp",
                MetaDescription = "Hành trình khám phá vẻ đẹp của núi.",
                ViewNumber = 85,

                UrlHandle = "canh-nui",
                CreateDate = DateTime.UtcNow.AddDays(-19),
                UpdateDate = DateTime.UtcNow.AddDays(-19),
                IsVisible = true,
                IsDeleted = false,
                IsReported = false,
                ReasonReport = null
            },
            new Post
            {
                PostId = Guid.Parse("7D1021A2-FD1B-4142-B1DF-019E763053FB"), //6
                AuthorId = SeedDataUser.GetIndex(2).UserId,
                Title = "Xinh ngoan iu của ai đây",
                Content = "hi",
                PageTitle = "Xinh ngoan iu của ai đây",
                MetaDescription = "hi",
                ViewNumber = 105,

                UrlHandle = "vuon-quoc-gia",
                CreateDate = DateTime.UtcNow.AddDays(-2),
                UpdateDate = DateTime.UtcNow.AddDays(-2),
                IsVisible = true,
                IsDeleted = false,
                IsReported = false,
                ReasonReport = null
            },
            new Post
            {
                PostId = Guid.Parse("8A1021A2-FD1B-4142-B1DF-019E763053FB"), // 7
                AuthorId = SeedDataUser.GetIndex(4).UserId,
                Title = "Đi học nhooo",
                Content = "Ghét code C#",
                PageTitle = "Đi học nhooo",
                MetaDescription = "Ghét code C#",
                ViewNumber = 98,

                UrlHandle = "ghet-C#",
                CreateDate = DateTime.UtcNow.AddDays(-20),
                UpdateDate = DateTime.UtcNow.AddDays(-20),
                IsVisible = true,
                IsDeleted = false,
                IsReported = false,
                ReasonReport = null
            },
            new Post
            {
                PostId = Guid.Parse("4C1021A2-FD1B-4142-B1DF-019E763053FB"), // 8
                AuthorId = SeedDataUser.GetIndex(0).UserId,
                Title = "Nơi này thích thật chiếc quần phá cách",
                Content = "Siu thoải mái",
                PageTitle = "Nơi này thích thật chiếc quần phá cách",
                MetaDescription = "Siu thoải mái",
                ViewNumber = 200,

                UrlHandle = "cho-noi",
                 CreateDate = DateTime.UtcNow.AddDays(-23),
                UpdateDate = DateTime.UtcNow.AddDays(-23),
                IsVisible = true,
                IsDeleted = false,
                IsReported = false,
                ReasonReport = null
            },
            new Post
            {
                PostId = Guid.Parse("3F8A1C5E-9A67-4E1D-B5B2-39E5F9C6A8F1"), // 8
                AuthorId = SeedDataUser.GetIndex(1).UserId,
                Title = "Áo thun đơn giản thoải mái",
                Content = "Chụp hình cùng tôi chứ?",
                PageTitle = "Áo thun đơn giản thoải mái",
                MetaDescription = "Chụp hình cùng tôi chứ?",
                ViewNumber = 200,

                UrlHandle = "chuphinh",
                CreateDate = DateTime.UtcNow.AddDays(-24),
                UpdateDate = DateTime.UtcNow.AddDays(-24),
                IsVisible = true,
                IsDeleted = false,
                IsReported = false,
                ReasonReport = null
            },
            new Post
            {
                PostId = Guid.Parse("A1D4F782-6F3E-4C9A-B3E1-58D72B6C9F45"), // 8
                AuthorId = SeedDataUser.GetIndex(5).UserId,
                Title = "Áo khoác siu ấm",
                Content = "Chụp hình cùng tôi chứ?",
                PageTitle = "Áo khoác siu ấm",
                MetaDescription = "Chụp hình cùng tôi chứ?",
                ViewNumber = 200,

                UrlHandle = "chuphinh",
                 CreateDate = DateTime.UtcNow.AddDays(-29),
                UpdateDate = DateTime.UtcNow.AddDays(-29),
                IsVisible = true,
                IsDeleted = false,
                IsReported = false,
                ReasonReport = null
            },
            new Post
            {
                PostId = Guid.Parse("C7B3F2E1-8D94-47C6-AB26-3E9F5A7D4B21"), // 8
                AuthorId = SeedDataUser.GetIndex(4).UserId,
                Title = "Bóng rổ chứ?",
                Content = "Bóng nè",
                PageTitle = "Bóng rổ chứ?",
                MetaDescription = "Bóng nè",
                ViewNumber = 200,
             
                UrlHandle = "chuphinh",
                CreateDate = DateTime.UtcNow,
                UpdateDate = DateTime.UtcNow,
                IsVisible = true,
                IsDeleted = false,
                IsReported = false,
                ReasonReport = null
            },
            new Post
            {
                PostId = Guid.Parse("5E9A2C7D-4B63-4E1F-9A72-B6C8D45F3E1A"), // 8
                AuthorId = SeedDataUser.GetIndex(2).UserId,
                Title = "Cười lên nào người đẹp",
                Content = "2-3 chụp nò",
                PageTitle = "Cười lên nào người đẹp",
                MetaDescription = "2-3 chụp nò",
                ViewNumber = 200,
             
                UrlHandle = "chuphinh",
                CreateDate = DateTime.UtcNow.AddDays(-25),
                UpdateDate = DateTime.UtcNow.AddDays(-25),
                IsVisible = true,
                IsDeleted = false,
                IsReported = false,
                ReasonReport = null
            },
            new Post
            {
                PostId = Guid.Parse("2A3D9F7E-5C41-4B82-B6F9-7D3E1C4A5F26"), // 8
                AuthorId = SeedDataUser.GetIndex(1).UserId,
                Title = "Cười lên nào người đẹp",
                Content = "2-3 chụp nò",
                PageTitle = "Cười lên nào người đẹp",
                MetaDescription = "2-3 chụp nò",
                ViewNumber = 200,
               
                UrlHandle = "chuphinh",
                 CreateDate = DateTime.UtcNow.AddDays(-30),
                UpdateDate = DateTime.UtcNow.AddDays(-30),
                IsVisible = true,
                IsDeleted = false,
                IsReported = false,
                ReasonReport = null
            },
            new Post
            {
                PostId = Guid.Parse("8C5E1F9A-72D4-4B6C-3E7D-9A5F2C41B8F2"), // 8
                AuthorId = SeedDataUser.GetIndex(1).UserId,
                Title = "Cà hê gì chưa ng đẹp",
                Content = "ỏoo",
                PageTitle = "Cà hê gì chưa ng đẹp",
                MetaDescription = "ỏoo",
                ViewNumber = 200,
               
                UrlHandle = "chuphinh",
                CreateDate = DateTime.UtcNow.AddDays(-25),
                UpdateDate = DateTime.UtcNow.AddDays(-25),
                IsVisible = true,
                IsDeleted = false,
                IsReported = false,
                ReasonReport = null
            },
            new Post
            {
                PostId = Guid.Parse("4B3E7D9A-5F2C-41B8-C5E1-F9A72D4B6C9F"), // 8
                AuthorId = SeedDataUser.GetIndex(1).UserId,
                Title = "sì maiiii",
                Content = "chàooo nhó",
                PageTitle = "sì maiiii",
                MetaDescription = "chàooo nhó",
                ViewNumber = 200,
               
                UrlHandle = "chuphinh",
                 CreateDate = DateTime.UtcNow.AddDays(-23),
                UpdateDate = DateTime.UtcNow.AddDays(-23),
                IsVisible = true,
                IsDeleted = false,
                IsReported = false,
                ReasonReport = null
            },
            new Post
            {
                PostId = Guid.Parse("F9A72D4B-6C9F-5E1C-3E7D-4B3E7D9A5F2C"), // 8
                AuthorId = SeedDataUser.GetIndex(3).UserId,
                Title = "cái túi xinh quá",
                Content = "chàooo nhó",
                PageTitle = "cái túi xinh quá",
                MetaDescription = "chàooo nhó",
                ViewNumber = 200,
               
                UrlHandle = "chuphinh",
                 CreateDate = DateTime.UtcNow.AddDays(-29),
                UpdateDate = DateTime.UtcNow.AddDays(-29),
                IsVisible = true,
                IsDeleted = false,
                IsReported = false,
                ReasonReport = null
            },
            new Post
            {
                PostId = Guid.Parse("6C9F5E1C-3E7D-4B3E-7D9A-5F2C41B8F2A7"), // 8
                AuthorId = SeedDataUser.GetIndex(3).UserId,
                Title = "hiiiii",
                Content = "chàooo nhó",
                PageTitle = "hiiiii",
                MetaDescription = "chàooo nhó",
                ViewNumber = 200,
              
                UrlHandle = "chuphinh",
                CreateDate = DateTime.UtcNow,
                UpdateDate = DateTime.UtcNow,
                IsVisible = true,
                IsDeleted = false,
                IsReported = false,
                ReasonReport = null
            },
            new Post
            {
                PostId = Guid.Parse("D4B6C9F5-E1C3-E7D4-B3E7-D9A5F2C41B8F"), // 8
                AuthorId = SeedDataUser.GetIndex(3).UserId,
                Title = "Chụp hình hong nèe",
                Content = "2-3 chụp nho",
                PageTitle = "Chụp hình hong nèe",
                MetaDescription = "2-3 chụp nho",
                ViewNumber = 200,
              
                UrlHandle = "chuphinh",
                CreateDate = DateTime.UtcNow.AddDays(-30),
                UpdateDate = DateTime.UtcNow.AddDays(-30),
                IsVisible = true,
                IsDeleted = false,
                IsReported = false,
                ReasonReport = null
            },
            new Post
            {
                PostId = Guid.Parse("3E1F9A72-B6D4-4C5E-8A7D-2B9F41C3E6F5"), // 8
                AuthorId = SeedDataUser.GetIndex(0).UserId,
                Title = "Chụp hình hong nèe",
                Content = "2-3 chụp nho",
                PageTitle = "Chụp hình hong nèe",
                MetaDescription = "2-3 chụp nho",
                ViewNumber = 200,
               
                UrlHandle = "chuphinh",
                CreateDate = DateTime.UtcNow.AddDays(-32),
                UpdateDate = DateTime.UtcNow.AddDays(-32),
                IsVisible = true,
                IsDeleted = false,
                IsReported = false,
                ReasonReport = null
            },
            new Post
            {
                PostId = Guid.Parse("A7C5E9D4-B62F-4F3E-1B7A-92C8D6F14E3F"), // 8
                AuthorId = SeedDataUser.GetIndex(2).UserId,
                Title = "Look at me",
                Content = "xinh lung linh",
                PageTitle = "Look at me",
                MetaDescription = "xinh lung linh",
                ViewNumber = 200,
               
                UrlHandle = "chuphinh",
               CreateDate = DateTime.UtcNow.AddDays(-31),
                UpdateDate = DateTime.UtcNow.AddDays(-31),
                IsVisible = true,
                IsDeleted = false,
                IsReported = false,
                ReasonReport = null
            },
            new Post
            {
                PostId = Guid.Parse("9A72C5E1-F3D4-B6F4-E38D-1B7A2C9F5E7D"), // 8
                AuthorId = SeedDataUser.GetIndex(1).UserId,
                Title = "Hoa đẹp hay hoa đẹp",
                Content = "xinh lung linh",
                PageTitle = "Hoa đẹp hay hoa đẹp",
                MetaDescription = "xinh lung linh",
                ViewNumber = 200,
              
                UrlHandle = "chuphinh",
                CreateDate = DateTime.UtcNow,
                UpdateDate = DateTime.UtcNow,
                IsVisible = true,
                IsDeleted = false,
                IsReported = false,
                ReasonReport = null
            },
            new Post
            {
                PostId = Guid.Parse("D4B6F3E9-A27C-5E1F-7D9A-2C84F1B3E65F"), // 8
                AuthorId = SeedDataUser.GetIndex(0).UserId,
                Title = "Nến và em",
                Content = "lạnh nhaaa",
                PageTitle = "Nến và em",
                MetaDescription = "lạnh nhaaa",
                ViewNumber = 200,
             
                UrlHandle = "chuphinh",
                CreateDate = DateTime.UtcNow.AddDays(-38),
                UpdateDate = DateTime.UtcNow.AddDays(-38),
                IsVisible = true,
                IsDeleted = false,
                IsReported = false,
                ReasonReport = null
            },
            new Post
            {
                PostId = Guid.Parse("5F3E9A2C-7D41-B6D4-8F2A-C5E17B9F4E3F"), // 8
                AuthorId = SeedDataUser.GetIndex(2).UserId,
                Title = "chu chu",
                Content = "hép pi bớt đây",
                PageTitle = "chu chu",
                MetaDescription = "hép pi bớt đây",
                ViewNumber = 200,
               
                UrlHandle = "chuphinh",
                 CreateDate = DateTime.UtcNow.AddDays(-39),
                UpdateDate = DateTime.UtcNow.AddDays(-39),
                IsVisible = true,
                IsDeleted = false,
                IsReported = false,
                ReasonReport = null
            },
            new Post
            {
                PostId = Guid.Parse("6bd026b4-d15c-4255-aff3-6e5b9e1da4cd"), // 8
                AuthorId = SeedDataUser.GetIndex(1).UserId,
                Title = "Cà hê cà hê",
                Content = "Hôm nay nắng thật đẹp",
                PageTitle = "Cà hê cà hê",
                MetaDescription = "Hôm nay nắng thật đẹp",
                ViewNumber = 200,
                

                UrlHandle = "chuphinh",
                 CreateDate = DateTime.UtcNow.AddDays(-38),
                UpdateDate = DateTime.UtcNow.AddDays(-38),
                IsVisible = true,
                IsDeleted = false,
                IsReported = false,
                ReasonReport = null
            },
            new Post
            {
                PostId = Guid.Parse("96bbcd9d-662d-46ad-8f1e-f7b60803d56b"), // 8
                AuthorId = SeedDataUser.GetIndex(9).UserId,
                Title = "Chơi đim honggg",
                Content = "Mắt kính này xinhhh",
                PageTitle = "Chơi đim honggg",
                MetaDescription = "Mắt kính này xinhhh",
                ViewNumber = 200,
             
                UrlHandle = "chuphinh",
                CreateDate = DateTime.UtcNow,
                UpdateDate = DateTime.UtcNow,
                IsVisible = true,
                IsDeleted = false,
                IsReported = false,
                ReasonReport = null
            },
            new Post
            {
                PostId = Guid.Parse("ceb542b4-71eb-4201-990f-e8a6033d9053"), // 8
                AuthorId = SeedDataUser.GetIndex(9).UserId,
                Title = "Chơi đim honggg",
                Content = "Mắt kính này xinhhh",
                PageTitle = "Chơi đim honggg",
                MetaDescription = "Mắt kính này xinhhh",
                ViewNumber = 200,
               
                UrlHandle = "chuphinh",
                CreateDate = DateTime.UtcNow,
                UpdateDate = DateTime.UtcNow,
                IsVisible = true,
                IsDeleted = false,
                IsReported = false,
                ReasonReport = null
            },
            new Post
            {
                PostId = Guid.Parse("bdbb2f86-be2b-49ef-adf9-7a2d0e1cd1ca"), // 8
                AuthorId = SeedDataUser.GetIndex(3).UserId,
                Title = "fairy",
                Content = "Đầm trắng xinh iu",
                PageTitle = "fairy",
                MetaDescription = "Đầm trắng xinh iu",
                ViewNumber = 200,
               
                UrlHandle = "chuphinh",
                CreateDate = DateTime.UtcNow,
                UpdateDate = DateTime.UtcNow,
                IsVisible = true,
                IsDeleted = false,
                IsReported = false,
                ReasonReport = null
            },
            new Post
            {
                PostId = Guid.Parse("498089e6-2c96-4836-a943-59efc2b0f3dc"), // 8
                AuthorId = SeedDataUser.GetIndex(0).UserId,
                Title = "Ăn tối hong",
                Content = "Mì ý nhoo",
                PageTitle = "Ăn tối hong",
                MetaDescription = "Mì ý nhoo",
                ViewNumber = 200,
  
                UrlHandle = "chuphinh",
                CreateDate = DateTime.UtcNow,
                UpdateDate = DateTime.UtcNow,
                IsVisible = true,
                IsDeleted = false,
                IsReported = false,
                ReasonReport = null
            },
            new Post
            {
                PostId = Guid.Parse("f890459c-9dff-4d2c-9faf-61b39e2c203d"), // 8
                AuthorId = SeedDataUser.GetIndex(1).UserId,
                Title = "Ăn uống gì chưa người đẹp",
                Content = "Đi ăn với tôi khum nè",
                PageTitle = "Ăn uống gì chưa người đẹp",
                MetaDescription = "Đi ăn với tôi khum nè",
                ViewNumber = 200,
              //  ShareNumber = 50,

                UrlHandle = "chuphinh",
                 CreateDate = DateTime.UtcNow.AddDays(-39),
                UpdateDate = DateTime.UtcNow.AddDays(-39),
                IsVisible = true,
                IsDeleted = false,
                IsReported = false,
                ReasonReport = null
            },
            new Post
            {
                PostId = Guid.Parse("093eb660-5870-4255-9a7f-87af2a2f3112"), // 8
                AuthorId = SeedDataUser.GetIndex(5).UserId,
                Title = "Nơi đây thoáng mát lắm nè cả nhà iu",
                Content = "hít hà",
                PageTitle = "Nơi đây thoáng mát lắm nè cả nhà iu",
                MetaDescription = "hít hà",
                ViewNumber = 200,
              //  ShareNumber = 50,

                UrlHandle = "chuphinh",
                CreateDate = DateTime.UtcNow.AddDays(-40),
                UpdateDate = DateTime.UtcNow.AddDays(-40),
                IsVisible = true,
                IsDeleted = false,
                IsReported = false,
                ReasonReport = null
            },
            new Post
            {
                PostId = Guid.Parse("7615a51f-2980-4edd-8a79-1f518f700aef"), // 8
                AuthorId = SeedDataUser.GetIndex(2).UserId,
                Title = "Ngoan xinh iu nò",
                Content = "hít hà",
                PageTitle = "Ngoan xinh iu nò",
                MetaDescription = "hít hà",
                ViewNumber = 200,
              //  ShareNumber = 50,

                UrlHandle = "chuphinh",
                 CreateDate = DateTime.UtcNow.AddDays(-40),
                UpdateDate = DateTime.UtcNow.AddDays(-40),
                IsVisible = true,
                IsDeleted = false,
                IsReported = false,
                ReasonReport = null
            },
            new Post
            {
                PostId = Guid.Parse("a5e63d45-516b-4323-9a9b-22bf43f0ddf0"), // 8
                AuthorId = SeedDataUser.GetIndex(9).UserId,
                Title = "Kính đen",
                Content = "Đi chơi i",
                PageTitle = "Kính đen",
                MetaDescription = "Đi chơi i",
                ViewNumber = 200,
             //   ShareNumber = 50,

                UrlHandle = "chuphinh",
                CreateDate = DateTime.UtcNow.AddDays(-42),
                UpdateDate = DateTime.UtcNow.AddDays(-42),
                IsVisible = true,
                IsDeleted = false,
                IsReported = false,
                ReasonReport = null
            },
            new Post
            {
                PostId = Guid.Parse("6d2d1944-9398-4b1a-b498-a22f669893c8"), // 8
                AuthorId = SeedDataUser.GetIndex(3).UserId,
                Title = "Chụp hình gì khum người đẹp",
                Content = "Chụp hình đi người đẹp",
                PageTitle = "Chụp hình gì khum người đẹp",
                MetaDescription = "Chụp hình đi người đẹp",
                ViewNumber = 200,
             //   ShareNumber = 50,

                UrlHandle = "chuphinh",
                CreateDate = DateTime.UtcNow,
                UpdateDate = DateTime.UtcNow,
                IsVisible = true,
                IsDeleted = false,
                IsReported = false,
                ReasonReport = null
            },
            new Post
            {
                PostId = Guid.Parse("dc359935-04f8-41cc-816a-993405de2673"), // 8
                AuthorId = SeedDataUser.GetIndex(1).UserId,
                Title = "Mã số 07 nò",
                Content = "Chụp hình đi người đẹp",
                PageTitle = "Mã số 07 nò",
                MetaDescription = "Chụp hình đi người đẹp",
                ViewNumber = 200,
            //    ShareNumber = 50,

                UrlHandle = "chuphinh",
                CreateDate = DateTime.UtcNow.AddDays(-43),
                UpdateDate = DateTime.UtcNow.AddDays(-43),
                IsVisible = true,
                IsDeleted = false,
                IsReported = false,
                ReasonReport = null
            },
            new Post
            {
                PostId = Guid.Parse("fc8dff53-387b-4f58-bad9-e1938d2a336a"), // 8
                AuthorId = SeedDataUser.GetIndex(0).UserId,
                Title = "Đẹp trai vãi ò",
                Content = "Chụp hình đi người đẹp",
                PageTitle = "Đẹp trai vãi ò",
                MetaDescription = "Chụp hình đi người đẹp",
                ViewNumber = 200,
             //   ShareNumber = 50,

                UrlHandle = "chuphinh",
               CreateDate = DateTime.UtcNow.AddDays(-43),
                UpdateDate = DateTime.UtcNow.AddDays(-43),
                IsVisible = true,
                IsDeleted = false,
                IsReported = false,
                ReasonReport = null
            },
            new Post
            {
                PostId = Guid.Parse("f37099a2-f5f7-465a-9829-339eb423186b"), // 8
                AuthorId = SeedDataUser.GetIndex(10).UserId,
                Title = "Chu chu",
                Content = "Đi chơi gì chưa người đẹp",
                PageTitle = "Chu chu",
                MetaDescription = "Đi chơi gì chưa người đẹp",
                ViewNumber = 200,
            //    ShareNumber = 50,

                UrlHandle = "chuphinh",
               CreateDate = DateTime.UtcNow.AddDays(-43),
                UpdateDate = DateTime.UtcNow.AddDays(-43),
                IsVisible = true,
                IsDeleted = false,
                IsReported = false,
                ReasonReport = null
            },
            new Post
            {
                PostId = Guid.Parse("07b99ca1-de5a-4905-a56c-9494592304d2"), // 8
                AuthorId = SeedDataUser.GetIndex(10).UserId,
                Title = "Lại đi  cà hê nò",
                Content = "Đi chơi gì chưa người đẹp",
                PageTitle = "Lại đi  cà hê nò",
                MetaDescription = "Đi chơi gì chưa người đẹp",
                ViewNumber = 200,
             //   ShareNumber = 50,

                UrlHandle = "chuphinh",
                CreateDate = DateTime.UtcNow,
                UpdateDate = DateTime.UtcNow,
                IsVisible = true,
                IsDeleted = false,
                IsReported = false,
                ReasonReport = null
            },
            new Post
            {
                PostId = Guid.Parse("c9449176-2e00-4b7b-bc83-e34a5bcd1305"), // 8
                AuthorId = SeedDataUser.GetIndex(11).UserId,
                Title = "Lại đi  cà hê nò",
                Content = "Đi chơi gì chưa người đẹp",
                PageTitle = "Lại đi  cà hê nò",
                MetaDescription = "Đi chơi gì chưa người đẹp",
                ViewNumber = 200,
             //   ShareNumber = 50,

                UrlHandle = "chuphinh",
               CreateDate = DateTime.UtcNow.AddDays(-43),
                UpdateDate = DateTime.UtcNow.AddDays(-43),
                IsVisible = true,
                IsDeleted = false,
                IsReported = false,
                ReasonReport = null
            },
            new Post
            {
                PostId = Guid.Parse("0195ddd5-e8a8-4450-830b-ce7d9aacb039"), // 8
                AuthorId = SeedDataUser.GetIndex(11).UserId,
                Title = "Vạt nắng lung linh",
                Content = "Đi chơi gì chưa người đẹp",
                PageTitle = "Vạt nắng lung linh",
                MetaDescription = "Đi chơi gì chưa người đẹp",
                ViewNumber = 200,
             //   ShareNumber = 50,

                UrlHandle = "chuphinh",
               CreateDate = DateTime.UtcNow.AddDays(-45),
                UpdateDate = DateTime.UtcNow.AddDays(-45),
                IsVisible = true,
                IsDeleted = false,
                IsReported = false,
                ReasonReport = null
            },
            new Post
            {
                PostId = Guid.Parse("307ae225-7691-4236-88aa-36506890fa64"), // 8
                AuthorId = SeedDataUser.GetIndex(12).UserId,
                Title = "Vạt nắng lung linh",
                Content = "Đi chơi gì chưa người đẹp",
                PageTitle = "Vạt nắng lung linh",
                MetaDescription = "Đi chơi gì chưa người đẹp",
                ViewNumber = 200,
             //   ShareNumber = 50,

                UrlHandle = "chuphinh",
                CreateDate = DateTime.UtcNow.AddDays(-50),
                UpdateDate = DateTime.UtcNow.AddDays(-50),
                IsVisible = true,
                IsDeleted = false,
                IsReported = false,
                ReasonReport = null
            },
            new Post
            {
                PostId = Guid.Parse("a479f484-326d-4119-8afb-cd6f3fe63532"), // 8
                AuthorId = SeedDataUser.GetIndex(12).UserId,
                Title = "Áo này xinh dữ lun í",
                Content = "Đi chơi gì chưa người đẹp",
                PageTitle = "Áo này xinh dữ lun í",
                MetaDescription = "Đi chơi gì chưa người đẹp",
                ViewNumber = 200,
             //   ShareNumber = 50,

                UrlHandle = "chuphinh",
                CreateDate = DateTime.UtcNow.AddDays(-52),
                UpdateDate = DateTime.UtcNow.AddDays(-52),
                IsVisible = true,
                IsDeleted = false,
                IsReported = false,
                ReasonReport = null
            },
            new Post
            {
                PostId = Guid.Parse("71cda676-2a3e-48b7-b66a-7d4965d02698"), // 8
                AuthorId = SeedDataUser.GetIndex(13).UserId,
                Title = "Đu đi honggg",
                Content = "Đi chơi gì chưa người đẹp",
                PageTitle = "Đu đi honggg",
                MetaDescription = "Đi chơi gì chưa người đẹp",
                ViewNumber = 200,
             //   ShareNumber = 50,

                UrlHandle = "chuphinh",
                CreateDate = DateTime.UtcNow,
                UpdateDate = DateTime.UtcNow,
                IsVisible = true,
                IsDeleted = false,
                IsReported = false,
                ReasonReport = null
            },
            new Post
            {
                PostId = Guid.Parse("4c3c0968-7694-4fcd-b49c-ac8354ef0311"), // 8
                AuthorId = SeedDataUser.GetIndex(13).UserId,
                Title = "Thư viện với tui hong",
                Content = "Nay hơi lạnh",
                PageTitle = "Thư viện với tui hong",
                MetaDescription = "Nay hơi lạnh",
                ViewNumber = 200,
             //   ShareNumber = 50,

                UrlHandle = "chuphinh",
                CreateDate = DateTime.UtcNow,
                UpdateDate = DateTime.UtcNow,
                IsVisible = true,
                IsDeleted = false,
                IsReported = false,
                ReasonReport = null
            },
            new Post
            {
                PostId = Guid.Parse("ccce4a73-de31-4282-aa08-abe659efb1ca"), // 8
                AuthorId = SeedDataUser.GetIndex(14).UserId,
                Title = "Đi học nè",
                Content = "Uống nước nè người đẹp",
                PageTitle = "Đi học nè",
                MetaDescription = "Uống nước nè người đẹp",
                ViewNumber = 200,
            //    ShareNumber = 50,

                UrlHandle = "chuphinh",
                CreateDate = DateTime.UtcNow,
                UpdateDate = DateTime.UtcNow,
                IsVisible = true,
                IsDeleted = false,
                IsReported = false,
                ReasonReport = null
            },
            new Post
            {
                PostId = Guid.Parse("19028697-7c61-457a-80b0-c2b26e94ebd5"), // 8
                AuthorId = SeedDataUser.GetIndex(14).UserId,
                Title = "Đi học nè",
                Content = "Uống nước nè người đẹp",
                PageTitle = "Đi học nè",
                MetaDescription = "Uống nước nè người đẹp",
                ViewNumber = 200,
           
                UrlHandle = "chuphinh",
                CreateDate = DateTime.UtcNow,
                UpdateDate = DateTime.UtcNow,
                IsVisible = true,
                IsDeleted = false,
                IsReported = false,
                ReasonReport = null
            }



        };
        public static Post GetIndex(int index)
        {
            if (index < 0 || index >= Posts.Length)
            {
                throw new IndexOutOfRangeException("Index out of range for seed data.");
            }
            return Posts[index];
        }
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>().HasData(Posts);
        }
    }
}
 