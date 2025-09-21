using BussinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace BussinessObject.SeedData
{
    public static class SeedDataPostImage
    {
        private static readonly PostImage[] PostImages = new PostImage[]
        {
            new PostImage
            {
                ImagePostId = Guid.Parse("3CEB6C8C-FCCB-47E4-BE72-F551A96B6035"),
                PostId = Guid.Parse("B9F3D0D4-6F68-400F-BAD2-9B83EB673ACA"),
                AspectRatio = "16:9",
                AltImage = "Oufit chạy bộ",
                UrlImage = "https://i.ibb.co/d4DC30mw/image.jpg"
            },
            new PostImage
            {
                ImagePostId = Guid.Parse("821E1674-5A09-46AF-B2EB-99BBCF60DD44"),
                PostId = Guid.Parse("8EB434BB-0E29-4A55-BE4A-77D710EBD6A6"),
                AspectRatio = "16:9",
                AltImage = "Chạy bộ nè",
                UrlImage = "https://i.ibb.co/zWMcXwch/t-i-xu-ng.jpg"
            },
            new PostImage
            {
                ImagePostId = Guid.Parse("25AE3D65-A45E-4D29-A9E6-E06F22EB63A3"),
                PostId = Guid.Parse("607B4DB7-57F8-42EC-A8BA-EB3BE8E126BB"),
                AspectRatio = "16:9",
                AltImage = "Oufit dạo phố",
                UrlImage = "https://i.ibb.co/TNgP0k6/alinakim.jpg"
            },
            new PostImage
            {
                ImagePostId = Guid.Parse("BEE79862-ACE2-4E9C-8D74-F2B4EB657752"),
                PostId = Guid.Parse("BCB12B9B-D374-4505-9051-3A7CDE836F21"),
                AspectRatio = "16:9",
                AltImage = "Đốm dễ thương nè",
                UrlImage = "https://i.ibb.co/PZjRZt4n/aesthetic-wallpaper.jpg"
            },
            new PostImage
            {
                ImagePostId = Guid.Parse("15D79C1C-5811-47EB-A3D0-D5AC12352D9F"),
                PostId = Guid.Parse("DC9C8380-FD04-4D0B-AAA4-41187D4E49F9"),
                AspectRatio = "16:9",
                AltImage = "Em xinggg",
                UrlImage = "https://i.ibb.co/4wMHP4t4/save-fl-me.jpg"
            },
            new PostImage
            {
                ImagePostId = Guid.Parse("98DEA0AA-C45F-43E8-A1DC-B2616BEF54FB"),
                PostId = Guid.Parse("3C9A7354-B558-4D44-959D-63142BEB0A0E"),
                AspectRatio = "16:9",
                AltImage = "Biển và em",
                UrlImage = "https://i.ibb.co/Q7sZ4m03/t-i-xu-ng-1.jpg"
            },
            new PostImage
            {
                ImagePostId = Guid.Parse("AAA2574F-F30C-412D-8DE9-27993273C630"),
                PostId = Guid.Parse("906C61A2-32AA-4F19-A842-3DF864B7411D"),
                AspectRatio = "16:9",
                AltImage = "Sáng chủ nhật",
                UrlImage = "https://i.ibb.co/vxppPx94/Morning-Coffee.jpg"
            },
            new PostImage
            {
                ImagePostId = Guid.Parse("F6B318E2-A46F-464C-8AD8-4F575B46D00D"),
                PostId = Guid.Parse("71EAF445-8A8A-4755-90E3-23A7AE3B9227"),
                AspectRatio = "16:9",
                AltImage = "Hiiiii",
                UrlImage = "https://i.ibb.co/bjwtVQz4/Tik-Tok-ttien2406.jpg"
            },
            new PostImage
            {
                ImagePostId = Guid.Parse("564B4F05-FBC0-491A-A2CD-A34300FD3EA3"),
                PostId = Guid.Parse("8A687930-5A59-4F74-A93C-6DEB89D049CF"),
                AspectRatio = "16:9",
                AltImage = "Sơ mi trắng",
                UrlImage = "https://i.ibb.co/qFcXzQtT/a11ae126-aab6-440f-9bb0-c3d19efba85e.jpg"
            },
            new PostImage
            {
                ImagePostId = Guid.Parse("89A260F3-9D1C-47EA-BE37-11E7F5FF4370"),
                PostId = Guid.Parse("253C48DC-A4DE-47FB-A36D-39D6CFD914B1"),
                AspectRatio = "16:9",
                AltImage = "2",
                UrlImage = "https://i.ibb.co/tMxxjkFZ/t-i-xu-ng-3.jpg"
            },
            new PostImage
            {
                ImagePostId = Guid.NewGuid(),
                PostId = Guid.Parse("1F1021A2-FD1B-4142-B1DF-019E763053FB"),  // Khớp với `PostId` của bài viết
                AspectRatio = "16:9",
                AltImage = "2",
                UrlImage = "https://i.ibb.co/k0nXzvY/e121e9f2f9b9208d7299d8c1c38df79c.jpg"
            },
            new PostImage
            {
                ImagePostId = Guid.NewGuid(),
                PostId = Guid.Parse("9A1021A2-FD1B-4142-B1DF-019E763053FB"),  // Khớp với `PostId` của bài viết
                AspectRatio = "16:9",
                AltImage = "2",
                UrlImage = "https://i.ibb.co/VYpkbJkP/0eeb261c5e3641bcfb2860befa5a3ca6.jpg"
            },
            new PostImage
            {
                ImagePostId = Guid.NewGuid(),
                PostId = Guid.Parse("7D1021A2-FD1B-4142-B1DF-019E763053FB"),  // Khớp với `PostId` của bài viết
                AspectRatio = "16:9",
                AltImage = "2",
                UrlImage = "https://i.ibb.co/Ngn799y0/d067b499f5ad1a998b6870af546a351e.jpg"
            },
            new PostImage
            {
                ImagePostId = Guid.NewGuid(),
                PostId = Guid.Parse("7B1021A2-FD1B-4142-B1DF-019E763053FB"),  // Khớp với `PostId` của bài viết
                AspectRatio = "16:9",
                AltImage = "2",
                UrlImage = "https://i.ibb.co/WvVq8pzX/c86cf58ffff00dfa2405c043eed9e625.jpg"
            },
            new PostImage
            {
                ImagePostId = Guid.NewGuid(),
                PostId = Guid.Parse("8A1021A2-FD1B-4142-B1DF-019E763053FB"),  // Khớp với `PostId` của bài viết
                AspectRatio = "16:9",
                AltImage = "2",
                UrlImage = "https://i.ibb.co/wZ1WQ2TZ/2cfa7ed419ca4ca5eb3eb1f357e9be4d.jpg"
            },
            new PostImage
            {
                ImagePostId = Guid.NewGuid(),
                PostId = Guid.Parse("4C1021A2-FD1B-4142-B1DF-019E763053FB"), // Khớp với `PostId` của bài viết
                AspectRatio = "16:9",
                AltImage = "2",
                UrlImage = "https://i.ibb.co/wNKT9XHr/dd476928a834b25ad3762df3392936f2.jpg"
            },
            new PostImage
            {
                ImagePostId = Guid.NewGuid(),
                PostId = Guid.Parse("3F8A1C5E-9A67-4E1D-B5B2-39E5F9C6A8F1"), // Khớp với `PostId` của bài viết
                AspectRatio = "16:9",
                AltImage = "2",
                UrlImage = "https://i.ibb.co/QjtgvCd6/3cbbd9f1e95bc0b0157889809e67a27a.jpg"
            },
            new PostImage
            {
                ImagePostId = Guid.NewGuid(),
                PostId = Guid.Parse("A1D4F782-6F3E-4C9A-B3E1-58D72B6C9F45"), // Khớp với `PostId` của bài viết
                AspectRatio = "16:9",
                AltImage = "2",
                UrlImage = "https://i.ibb.co/zVH02wz4/10cc9b0fe192e9c28ecbc4f7138031b0.jpg"
            },
            new PostImage
            {
                ImagePostId = Guid.NewGuid(),
                PostId = Guid.Parse("C7B3F2E1-8D94-47C6-AB26-3E9F5A7D4B21"), // Khớp với `PostId` của bài viết
                AspectRatio = "16:9",
                AltImage = "2",
                UrlImage = "https://i.ibb.co/nN1GzZ1k/73de23f951cc234980c6061334c90e73.jpg"
            },
            new PostImage
            {
                ImagePostId = Guid.NewGuid(),
                PostId = Guid.Parse("5E9A2C7D-4B63-4E1F-9A72-B6C8D45F3E1A"), // Khớp với `PostId` của bài viết
                AspectRatio = "16:9",
                AltImage = "2",
                UrlImage = "https://i.ibb.co/n80kywSN/287f03d7003fa6182409a53c692e08bd.jpg"
            },
            new PostImage
            {
                ImagePostId = Guid.NewGuid(),
                PostId = Guid.Parse("2A3D9F7E-5C41-4B82-B6F9-7D3E1C4A5F26"), // Khớp với `PostId` của bài viết
                AspectRatio = "16:9",
                AltImage = "2",
                UrlImage = "https://i.ibb.co/r2rqTQ5h/7561f872176d7cff3dc7f2c6a2c2d90e.jpg"
            },
            new PostImage
            {
                ImagePostId = Guid.NewGuid(),
                PostId = Guid.Parse("8C5E1F9A-72D4-4B6C-3E7D-9A5F2C41B8F2"), // Khớp với `PostId` của bài viết
                AspectRatio = "16:9",
                AltImage = "2",
                UrlImage = "https://i.ibb.co/Df105BgS/10072766921ae3f632436db63045693a.jpg"
            },
            new PostImage
            {
                ImagePostId = Guid.NewGuid(),
                PostId = Guid.Parse("4B3E7D9A-5F2C-41B8-C5E1-F9A72D4B6C9F"), // Khớp với `PostId` của bài viết
                AspectRatio = "16:9",
                AltImage = "2",
                UrlImage = "https://i.ibb.co/q3Q6CPCc/aa982c8e545d2e52f8f22cea55ff569b.jpg"
            },
            new PostImage
            {
                ImagePostId = Guid.NewGuid(),
                PostId = Guid.Parse("F9A72D4B-6C9F-5E1C-3E7D-4B3E7D9A5F2C"), // Khớp với `PostId` của bài viết
                AspectRatio = "16:9",
                AltImage = "2",
                UrlImage = "https://i.ibb.co/QvknssdW/c0a5bb4208788db6deabe7246b62d1bc.jpg"
            },
            new PostImage
            {
                ImagePostId = Guid.NewGuid(),
                PostId = Guid.Parse("6C9F5E1C-3E7D-4B3E-7D9A-5F2C41B8F2A7"), // Khớp với `PostId` của bài viết
                AspectRatio = "16:9",
                AltImage = "2",
                UrlImage = "https://i.ibb.co/HLcfQZzm/d3a47703c62ecb5166755d3092107178.jpg"
            },
            new PostImage
            {
                ImagePostId = Guid.NewGuid(),
                PostId = Guid.Parse("D4B6C9F5-E1C3-E7D4-B3E7-D9A5F2C41B8F"), // Khớp với `PostId` của bài viết
                AspectRatio = "16:9",
                AltImage = "2",
                UrlImage = "https://i.ibb.co/DPD5gbjs/dbb94f7a5a6bde1fa20331e90eef6de6.jpg"
            },
            new PostImage
            {
                ImagePostId = Guid.NewGuid(),
                PostId = Guid.Parse("3E1F9A72-B6D4-4C5E-8A7D-2B9F41C3E6F5"), // Khớp với `PostId` của bài viết
                AspectRatio = "16:9",
                AltImage = "2",
                UrlImage = "https://i.ibb.co/prhJDLMQ/dcb8ca413e0244808f3fb6f1706c5118.jpg"
            },
            new PostImage
            {
                ImagePostId = Guid.NewGuid(),
                PostId = Guid.Parse("A7C5E9D4-B62F-4F3E-1B7A-92C8D6F14E3F"), // Khớp với `PostId` của bài viết
                AspectRatio = "16:9",
                AltImage = "2",
                UrlImage = "https://i.ibb.co/vvq5SJwn/z6337301327035-25dc2448bc95d53cdefff6f8a2f395ec.jpg"
            },
            new PostImage
            {
                ImagePostId = Guid.NewGuid(),
                PostId = Guid.Parse("9A72C5E1-F3D4-B6F4-E38D-1B7A2C9F5E7D"), // Khớp với `PostId` của bài viết
                AspectRatio = "16:9",
                AltImage = "2",
                UrlImage = "https://i.ibb.co/0yCjbsP4/z6337301427470-6b468b3605aef88b9bb0b03f5b88ce92.jpg"
            },
            new PostImage
            {
                ImagePostId = Guid.NewGuid(),
                PostId = Guid.Parse("D4B6F3E9-A27C-5E1F-7D9A-2C84F1B3E65F"), // Khớp với `PostId` của bài viết
                AspectRatio = "16:9",
                AltImage = "2",
                UrlImage = "https://i.ibb.co/1G80DfGp/z6337301429530-60ea8ebbd3e689121471cf14f46d97b2.jpg"
            },
            new PostImage
            {
                ImagePostId = Guid.NewGuid(),
                PostId = Guid.Parse("5F3E9A2C-7D41-B6D4-8F2A-C5E17B9F4E3F"), // Khớp với `PostId` của bài viết
                AspectRatio = "16:9",
                AltImage = "2",
                UrlImage = "https://i.ibb.co/GvyMX44v/z6337301685670-c8db853c69ea82e77d9fa5697fd6cd9b.jpg"
            },
            new PostImage
            {
                ImagePostId = Guid.NewGuid(),
                PostId = Guid.Parse("6bd026b4-d15c-4255-aff3-6e5b9e1da4cd"), // Khớp với `PostId` của bài viết
                AspectRatio = "16:9",
                AltImage = "2",
                UrlImage = "https://i.ibb.co/Kj0nSvWg/454630308-1215741039429225-5646081511149320292-n.jpg"
            },
            new PostImage
            {
                ImagePostId = Guid.NewGuid(),
                PostId = Guid.Parse("96bbcd9d-662d-46ad-8f1e-f7b60803d56b"), // Khớp với `PostId` của bài viết
                AspectRatio = "16:9",
                AltImage = "2",
                UrlImage = "https://i.ibb.co/wrRYRm4g/417471411-1052058436030827-603959030097972062-n.jpg"
            },
            new PostImage
            {
                ImagePostId = Guid.NewGuid(),
                PostId = Guid.Parse("ceb542b4-71eb-4201-990f-e8a6033d9053"), // Khớp với `PostId` của bài viết
                AspectRatio = "16:9",
                AltImage = "2",
                UrlImage = "https://i.ibb.co/qMxg99cr/455357552-1418960339494748-959228536279100603-n.jpg"
            },
            new PostImage
            {
                ImagePostId = Guid.NewGuid(),
                PostId = Guid.Parse("ceb542b4-71eb-4201-990f-e8a6033d9053"), // Khớp với `PostId` của bài viết
                AspectRatio = "16:9",
                AltImage = "2",
                UrlImage = "https://i.ibb.co/qMxg99cr/455357552-1418960339494748-959228536279100603-n.jpg"
            },
            new PostImage
            {
                ImagePostId = Guid.NewGuid(),
                PostId = Guid.Parse("bdbb2f86-be2b-49ef-adf9-7a2d0e1cd1ca"), // Khớp với `PostId` của bài viết
                AspectRatio = "16:9",
                AltImage = "2",
                UrlImage = "https://i.ibb.co/LhrM9k5m/NQ-2.jpg"
            },
            new PostImage
            {
                ImagePostId = Guid.NewGuid(),
                PostId = Guid.Parse("498089e6-2c96-4836-a943-59efc2b0f3dc"), // Khớp với `PostId` của bài viết
                AspectRatio = "16:9",
                AltImage = "2",
                UrlImage = "https://i.ibb.co/spRP6Rn6/476435881-18039274208375792-5199770415983499224-n.jpg"
            },
            new PostImage
            {
                ImagePostId = Guid.NewGuid(),
                PostId = Guid.Parse("f890459c-9dff-4d2c-9faf-61b39e2c203d"), // Khớp với `PostId` của bài viết
                AspectRatio = "16:9",
                AltImage = "2",
                UrlImage = "https://i.ibb.co/q3YLqmXL/10dc8b846979d16d52c44a7761a763b2.jpg"
            },
            new PostImage
            {
                ImagePostId = Guid.NewGuid(),
                PostId = Guid.Parse("093eb660-5870-4255-9a7f-87af2a2f3112"), // Khớp với `PostId` của bài viết
                AspectRatio = "16:9",
                AltImage = "2",
                UrlImage = "https://i.ibb.co/Q7HSsykW/75b329ee2d738916d524202b07161246.jpg"
            },
            new PostImage
            {
                ImagePostId = Guid.NewGuid(),
                PostId = Guid.Parse("7615a51f-2980-4edd-8a79-1f518f700aef"), // Khớp với `PostId` của bài viết
                AspectRatio = "16:9",
                AltImage = "2",
                UrlImage = "https://i.ibb.co/cKGk8JSN/360f43933f5387b84dd582a7be208643.jpg"
            },
            new PostImage
            {
                ImagePostId = Guid.NewGuid(),
                PostId = Guid.Parse("a5e63d45-516b-4323-9a9b-22bf43f0ddf0"), // Khớp với `PostId` của bài viết
                AspectRatio = "16:9",
                AltImage = "2",
                UrlImage = "https://i.ibb.co/gZsYPnCF/95903362d54fe84da466746609b6f21b.jpg"
            },
            new PostImage
            {
                ImagePostId = Guid.NewGuid(),
                PostId = Guid.Parse("6d2d1944-9398-4b1a-b498-a22f669893c8"), // Khớp với `PostId` của bài viết
                AspectRatio = "16:9",
                AltImage = "2",
                UrlImage = "https://i.ibb.co/QjQKZs5q/c759a36bffd4d9627f6a36c5837672d8.jpg"
            },
            new PostImage
            {
                ImagePostId = Guid.NewGuid(),
                PostId = Guid.Parse("dc359935-04f8-41cc-816a-993405de2673"), // Khớp với `PostId` của bài viết
                AspectRatio = "16:9",
                AltImage = "2",
                UrlImage = "https://i.ibb.co/FLYB8tNm/dcf09b5d50e96a179bbeca5b7904a546.jpg"
            },
            new PostImage
            {
                ImagePostId = Guid.NewGuid(),
                PostId = Guid.Parse("fc8dff53-387b-4f58-bad9-e1938d2a336a"), // Khớp với `PostId` của bài viết
                AspectRatio = "16:9",
                AltImage = "2",
                UrlImage = "https://i.ibb.co/WpGBkW8D/481857923-1318883669390262-6646797846098878202-n.jpg"
            },
            new PostImage
            {
                ImagePostId = Guid.NewGuid(),
                PostId = Guid.Parse("f37099a2-f5f7-465a-9829-339eb423186b"), // Khớp với `PostId` của bài viết
                AspectRatio = "16:9",
                AltImage = "2",
                UrlImage = "https://i.ibb.co/KxcJ6FCn/1991d4776aeb477640aef8ea8175a3b3.jpg"
            },
            new PostImage
            {
                ImagePostId = Guid.NewGuid(),
                PostId = Guid.Parse("07b99ca1-de5a-4905-a56c-9494592304d2"), // Khớp với `PostId` của bài viết
                AspectRatio = "16:9",
                AltImage = "2",
                UrlImage = "https://i.ibb.co/FqkFcg4s/6246bb6adf1eec8fed575f8dbf1568ca.jpg"
            },
            new PostImage
            {
                ImagePostId = Guid.NewGuid(),
                PostId = Guid.Parse("c9449176-2e00-4b7b-bc83-e34a5bcd1305"), // Khớp với `PostId` của bài viết
                AspectRatio = "16:9",
                AltImage = "2",
                UrlImage = "https://i.ibb.co/jkhQVtS7/5086048f275cdf955891f71d183faa79.jpg"
            },
            new PostImage
            {
                ImagePostId = Guid.NewGuid(),
                PostId = Guid.Parse("0195ddd5-e8a8-4450-830b-ce7d9aacb039"), // Khớp với `PostId` của bài viết
                AspectRatio = "16:9",
                AltImage = "2",
                UrlImage = "https://i.ibb.co/n4Z1pwq/081233849d607bd0ace1fdc145eb133c.jpg"
            },
            new PostImage
            {
                ImagePostId = Guid.NewGuid(),
                PostId = Guid.Parse("307ae225-7691-4236-88aa-36506890fa64"), // Khớp với `PostId` của bài viết
                AspectRatio = "16:9",
                AltImage = "2",
                UrlImage = "https://i.ibb.co/fYn6cd2v/be5d26f1b88f97f40ac363485c745317.jpg"
            },
            new PostImage
            {
                ImagePostId = Guid.NewGuid(),
                PostId = Guid.Parse("a479f484-326d-4119-8afb-cd6f3fe63532"), // Khớp với `PostId` của bài viết
                AspectRatio = "16:9",
                AltImage = "2",
                UrlImage = "https://i.ibb.co/nsgTkBft/e2ee18ca536831e81818c02216fc0083.jpg"
            },
            new PostImage
            {
                ImagePostId = Guid.NewGuid(),
                PostId = Guid.Parse("71cda676-2a3e-48b7-b66a-7d4965d02698"), // Khớp với `PostId` của bài viết
                AspectRatio = "16:9",
                AltImage = "2",
                UrlImage = "https://i.ibb.co/8gKSNPZc/2ea97dfa59496b3558c5f50f368289e1.jpg"
            },
            new PostImage
            {
                ImagePostId = Guid.NewGuid(),
                PostId = Guid.Parse("4c3c0968-7694-4fcd-b49c-ac8354ef0311"), // Khớp với `PostId` của bài viết
                AspectRatio = "16:9",
                AltImage = "2",
                UrlImage = "https://i.ibb.co/xtkMXNXC/840a21781effed054d27c46e849667cd.jpg"
            },
            new PostImage
            {
                ImagePostId = Guid.NewGuid(),
                PostId = Guid.Parse("ccce4a73-de31-4282-aa08-abe659efb1ca"), // Khớp với `PostId` của bài viết
                AspectRatio = "16:9",
                AltImage = "2",
                UrlImage = "https://i.ibb.co/5hJNv91R/3e16b1eef41a43cdd434d59a98e89e9b.jpg"
            },
            new PostImage
            {
                ImagePostId = Guid.NewGuid(),
                PostId = Guid.Parse("19028697-7c61-457a-80b0-c2b26e94ebd5"), // Khớp với `PostId` của bài viết
                AspectRatio = "16:9",
                AltImage = "2",
                UrlImage = "https://i.ibb.co/SDYXQWvF/3fa60aec6d451daf3b8ece22939d0f3d.jpg"
            }
        };

        public static PostImage GetIndex(int index)
        {
            if (index < 0 || index >= PostImages.Length)
            {
                throw new IndexOutOfRangeException("Index out of range for seed data.");
            }
            return PostImages[index];
        }

        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PostImage>().HasData(PostImages);
        }
    }
}