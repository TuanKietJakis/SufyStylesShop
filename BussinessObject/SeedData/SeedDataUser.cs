using BussinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject.SeedData
{
    public static class SeedDataUser
    {
        public static readonly User[] Users = new User[]
        {
            new User
            {
                UserId = new Guid("C33912D3-4525-43F1-B893-07580F2C4226"), //0
                Username = "Ngọc Quỳnh",
                ProfileName = "Ngọc Quỳnh",
                Email = "user1@example.com",
                Password = "a440bb6054b3e01d6368f074ce6b4c08f367ee8a6cc7a404b4587ef36ace210b35f5ade8beeec438721d561d90ed7598cba568c042293714eb014c72ac990183", // 12345678aA@
                UrlImage = "https://i.ibb.co/TNgP0k6/alinakim.jpg",
                Phone = "0945732336",
                Firstname = "First",
                Lastname = "User",
                Birthday = new DateOnly(1990, 1, 1),
                Gender = true,          
                CreatedDate = DateTime.UtcNow,
                IsAcceptMarketing = true,
                RoleId = new Guid("C3D4E5F6-A7B8-4901-CDEF-34567890ABCD"),
                IsBanned = false,
                ReasonBan = null
            },
            new User
            {
                UserId = new Guid("C76DD8D3-A7F4-4F95-BAEA-8E52B31730C6"), //1
                Username = "Kim",
                ProfileName = "Kim",
                Email = "user2@example.com",
                Password = "a440bb6054b3e01d6368f074ce6b4c08f367ee8a6cc7a404b4587ef36ace210b35f5ade8beeec438721d561d90ed7598cba568c042293714eb014c72ac990183", // 12345678A
                UrlImage = "https://i.ibb.co/Pcnb1bt/a5bacdf2f826.jpg",
                Phone = "0945732337",
                Firstname = "Second",
                Lastname = "User",
                Birthday = new DateOnly(1992, 2, 2),
                Gender = false,
             
                CreatedDate = DateTime.UtcNow,
                IsAcceptMarketing = false,
                RoleId = new Guid("C3D4E5F6-A7B8-4901-CDEF-34567890ABCD"),
                IsBanned = false,
                ReasonBan = null

            },
            new User
            {
                UserId = new Guid("7ED45DA6-D22C-43C6-91F1-A1FD396CE414"), //2
                Username = "user1234567890123456789012345678901234567890123456",
                ProfileName = "Hiệp",
                Email = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa@example.com",
                Password = "a440bb6054b3e01d6368f074ce6b4c08f367ee8a6cc7a404b4587ef36ace210b35f5ade8beeec438721d561d90ed7598cba568c042293714eb014c72ac990183", // 12345678A
                UrlImage = "https://i.ibb.co/GvLsVPHY/t-i-xu-ng-2.jpg",
                Phone = "0945732338",
                Firstname = "Third",
                Lastname = "User",
                Birthday = new DateOnly(1993, 3, 3),
                Gender = true,          
                CreatedDate = DateTime.UtcNow,
                IsAcceptMarketing = true,
                RoleId = new Guid("C3D4E5F6-A7B8-4901-CDEF-34567890ABCD"),
                IsBanned = false,
                ReasonBan = null
            },
            new User
            {
                UserId = new Guid("5EB29BD0-1C6B-42BF-A2C7-C71E05D4B10D"), //3
                Username = "My",
                ProfileName = "My",
                Email = "user4@example.com",
                Password = "a440bb6054b3e01d6368f074ce6b4c08f367ee8a6cc7a404b4587ef36ace210b35f5ade8beeec438721d561d90ed7598cba568c042293714eb014c72ac990183", // 12345678A
                UrlImage = "https://i.ibb.co/Cb5MZ0N/9dc5aea48fee.jpg",
                Phone = "0945732330",
                Firstname = "Fourth",
                Lastname = "User",
                Birthday = new DateOnly(1994, 4, 4),
                Gender = false,          
                CreatedDate = DateTime.UtcNow,
                IsAcceptMarketing = true,
                RoleId = new Guid("C3D4E5F6-A7B8-4901-CDEF-34567890ABCD"),
                IsBanned = false,
                ReasonBan = null
            },
            new User
            {
                UserId = new Guid("72AB8BAE-9706-4709-9734-D6E986F539EA"), //4
                Username = "Anh",
                ProfileName = "Anh",
                Email = "user5@example.com",
                Password = "a440bb6054b3e01d6368f074ce6b4c08f367ee8a6cc7a404b4587ef36ace210b35f5ade8beeec438721d561d90ed7598cba568c042293714eb014c72ac990183", // 12345678A
                UrlImage = "https://i.ibb.co/Cb5MZ0N/9dc5aea48fee.jpg",
                Phone = "0914097440",
                Firstname = "Fifth",
                Lastname = "User",
                Birthday = new DateOnly(1995, 5, 5),
                Gender = true,           
                CreatedDate = DateTime.UtcNow,
                IsAcceptMarketing = false,
                RoleId = new Guid("C3D4E5F6-A7B8-4901-CDEF-34567890ABCD"),
                IsBanned = true,
                ReasonBan = "chịu rồi"
            },
            new User
            {
                UserId = new Guid("3F2504E0-4F89-11D3-9A0C-0305E82C3301"), //5
                Username = "Tuan Kiet",
                ProfileName = "Tuan Kiet",
                Email = "trantuankietznagokunec2@gmail.com",
                Password = "a440bb6054b3e01d6368f074ce6b4c08f367ee8a6cc7a404b4587ef36ace210b35f5ade8beeec438721d561d90ed7598cba568c042293714eb014c72ac990183", // 12345678A
                UrlImage = "https://i.ibb.co/7xSKSc2m/chu-ng-d-t-2.png",
                Phone = "0914097441",
                Firstname = "First",
                Lastname = "User",
                Birthday = new DateOnly(1990, 1, 1),
                Gender = true,
                CreatedDate = DateTime.UtcNow,
                IsAcceptMarketing = true,
                RoleId = new Guid("C3D4E5F6-A7B8-4901-CDEF-34567890ABCD"),
                IsBanned = false,
                ReasonBan = null
            },
/*            new User
            {
                UserId = Guid.NewGuid(), //6
                Username = "Kim",
                ProfileName = "Kim",
                Email = "hhhhh@gmail.com",
                Password = "bcc67d8524948bbd873e4df12c89b182", // 12345678A
                UrlImage = "https://i.ibb.co/Pcnb1bt/a5bacdf2f826.jpg",
                Phone = "0123456788",
                Firstname = "First",
                Lastname = "User",
                Birthday = new DateOnly(1990, 1, 1),
                Gender = true,
                CreatedDate = DateTime.UtcNow,
                IsAcceptMarketing = true,
                RoleId = new Guid("C3D4E5F6-A7B8-4901-CDEF-34567890ABCD"),
                IsBanned = false,
                ReasonBan = null,
                IsDeleted = false
            },
            new User
            {
                UserId = Guid.NewGuid(), //7
                Username = "user8",
                ProfileName = "User 8",
                Email = "hhhhh@gmail.com",
                Password = "bcc67d8524948bbd873e4df12c89b182", // 12345678A
                Phone = "0987654325",
                Firstname = "First",
                Lastname = "User",
                Birthday = new DateOnly(1990, 1, 1),
                Gender = true,
                CreatedDate = DateTime.UtcNow,
                IsAcceptMarketing = true,
                RoleId = new Guid("C3D4E5F6-A7B8-4901-CDEF-34567890ABCD"),
                IsBanned = false,
                ReasonBan = null,
                IsDeleted = false
            },*/
            new User
            {
                UserId = Guid.NewGuid(),//6
                Username = "9",
                ProfileName = "User One",
                Email = "duongsitien@gmail.com",
                Password = "a440bb6054b3e01d6368f074ce6b4c08f367ee8a6cc7a404b4587ef36ace210b35f5ade8beeec438721d561d90ed7598cba568c042293714eb014c72ac990183", 
                Phone = "0914097447",
                Firstname = "First",
                Lastname = "User",
                Birthday = new DateOnly(1990, 1, 1),
                Gender = true,
                CreatedDate = DateTime.UtcNow,
                IsAcceptMarketing = true,
                RoleId = new Guid("A1B2C3D4-E5F6-4789-ABCD-1234567890AB"),
                IsBanned = false,
                ReasonBan = null,
                IsDeleted = false
            },
            new User
            {
                UserId = Guid.NewGuid(),//7
                Username = "Tien10",
                ProfileName = "Tien",
                Email = "duongsitien123@gmail.com",
                Password = "a440bb6054b3e01d6368f074ce6b4c08f367ee8a6cc7a404b4587ef36ace210b35f5ade8beeec438721d561d90ed7598cba568c042293714eb014c72ac990183",
                UrlImage = "https://i.ibb.co/Cb5MZ0N/9dc5aea48fee.jpg",
                Phone = "0914097442",
                Firstname = "First",
                Lastname = "User",
                Birthday = new DateOnly(1990, 1, 1),
                Gender = true,
                CreatedDate = DateTime.UtcNow,
                IsAcceptMarketing = true,
                RoleId = new Guid("B2C3D4E5-F6A7-4890-BCDE-234567890ABC"),
                IsBanned = false,
                ReasonBan = null
            },
             new User
            {
                UserId = new Guid("3F1A7D9B-8E2C-4D5A-9B2F-6C8D4E1F5A3C"),//8
                Username = "11",
                ProfileName = "User 11",
                Email = "duongsitien321@gmail.com",
                Password = "a440bb6054b3e01d6368f074ce6b4c08f367ee8a6cc7a404b4587ef36ace210b35f5ade8beeec438721d561d90ed7598cba568c042293714eb014c72ac990183",
                Phone = "0945732336",
                Firstname = "First",
                Lastname = "User",
                Birthday = new DateOnly(1990, 1, 1),
                Gender = true,
                CreatedDate = DateTime.UtcNow,
                IsAcceptMarketing = true,
                RoleId = new Guid("B2C3D4E5-F6A7-4890-BCDE-234567890ABC"),
                IsBanned = false,
                ReasonBan = null,
                IsDeleted = false
            },
             new User
            {
                UserId = new Guid("0c4a9f9c-fa19-475b-a1b0-e40e8cd751de"),//9
                Username = "Monta",
                ProfileName = "Monta",
                Email = "monta@gmail.com",
                Password = "a440bb6054b3e01d6368f074ce6b4c08f367ee8a6cc7a404b4587ef36ace210b35f5ade8beeec438721d561d90ed7598cba568c042293714eb014c72ac990183",
                UrlImage = "https://i.ibb.co/wrRYRm4g/417471411-1052058436030827-603959030097972062-n.jpg",
                Phone = "0945732399",
                Firstname = "Mon",
                Lastname = "ta",
                Birthday = new DateOnly(1990, 1, 1),
                Gender = true,
                CreatedDate = DateTime.UtcNow,
                IsAcceptMarketing = true,
                RoleId = new Guid("C3D4E5F6-A7B8-4901-CDEF-34567890ABCD"),
                IsBanned = false,
                ReasonBan = null,
                IsDeleted = false
            },
             new User
            {
                UserId = new Guid("68557c40-20ea-455d-9556-60def44eb928"),//10
                Username = "Ngọc Quý",
                ProfileName = "Ngọc Quý",
                Email = "quy@gmail.com",
                Password = "a440bb6054b3e01d6368f074ce6b4c08f367ee8a6cc7a404b4587ef36ace210b35f5ade8beeec438721d561d90ed7598cba568c042293714eb014c72ac990183",
                UrlImage = "https://i.ibb.co/LhrM9k5m/NQ-2.jpg",
                Phone = "0945732399",
                Firstname = "Ngọc",
                Lastname = "Quý",
                Birthday = new DateOnly(1990, 1, 1),
                Gender = true,
                CreatedDate = DateTime.UtcNow,
                IsAcceptMarketing = true,
                RoleId = new Guid("C3D4E5F6-A7B8-4901-CDEF-34567890ABCD"),
                IsBanned = false,
                ReasonBan = null,
                IsDeleted = false
            },
             new User
            {
                UserId = new Guid("3a80d09d-9d05-4fc9-8a19-889dac09ab37"),//11
                Username = "Ngọc Trâm",
                ProfileName = "Ngọc Trâm",
                Email = "trâm@gmail.com",
                Password = "a440bb6054b3e01d6368f074ce6b4c08f367ee8a6cc7a404b4587ef36ace210b35f5ade8beeec438721d561d90ed7598cba568c042293714eb014c72ac990183",
                UrlImage = "https://i.ibb.co/jkhQVtS7/5086048f275cdf955891f71d183faa79.jpg",
                Phone = "0945732399",
                Firstname = "Ngọc",
                Lastname = "Trâm",
                Birthday = new DateOnly(1990, 1, 1),
                Gender = true,
                CreatedDate = DateTime.UtcNow,
                IsAcceptMarketing = true,
                RoleId = new Guid("C3D4E5F6-A7B8-4901-CDEF-34567890ABCD"),
                IsBanned = false,
                ReasonBan = null,
                IsDeleted = false
            },
             new User
            {
                UserId = new Guid("a659d92f-2df3-44e5-96c6-40aa4800ae6e"),//12
                Username = "Trà My",
                ProfileName = "Trà My",
                Email = "trâm@gmail.com",
                Password = "a440bb6054b3e01d6368f074ce6b4c08f367ee8a6cc7a404b4587ef36ace210b35f5ade8beeec438721d561d90ed7598cba568c042293714eb014c72ac990183",
                UrlImage = "https://i.ibb.co/nsgTkBft/e2ee18ca536831e81818c02216fc0083.jpg",
                Phone = "0945732399",
                Firstname = "Trà",
                Lastname = "My",
                Birthday = new DateOnly(1990, 1, 1),
                Gender = true,
                CreatedDate = DateTime.UtcNow,
                IsAcceptMarketing = true,
                RoleId = new Guid("C3D4E5F6-A7B8-4901-CDEF-34567890ABCD"),
                IsBanned = false,
                ReasonBan = null,
                IsDeleted = false
            },
             new User
            {
                UserId = new Guid("2e833883-8ec0-496f-90d8-1665c4a236eb"),//13
                Username = "Hoàng Anh",
                ProfileName = "Hoàng Anh",
                Email = "trâm@gmail.com",
                Password = "a440bb6054b3e01d6368f074ce6b4c08f367ee8a6cc7a404b4587ef36ace210b35f5ade8beeec438721d561d90ed7598cba568c042293714eb014c72ac990183",
                UrlImage = "https://i.ibb.co/spRP6Rn6/476435881-18039274208375792-5199770415983499224-n.jpg",
                Phone = "0945732399",
                Firstname = "Hoàng",
                Lastname = "Anh",
                Birthday = new DateOnly(1990, 1, 1),
                Gender = true,
                CreatedDate = DateTime.UtcNow,
                IsAcceptMarketing = true,
                RoleId = new Guid("C3D4E5F6-A7B8-4901-CDEF-34567890ABCD"),
                IsBanned = false,
                ReasonBan = null,
                IsDeleted = false
            },
             new User
            {
                UserId = new Guid("72f81a38-545d-491a-a51f-2c97382a07cf"),//14
                Username = "Sĩ Tiến",
                ProfileName = "Sĩ Tiến",
                Email = "trâm@gmail.com",
                Password = "a440bb6054b3e01d6368f074ce6b4c08f367ee8a6cc7a404b4587ef36ace210b35f5ade8beeec438721d561d90ed7598cba568c042293714eb014c72ac990183",
                UrlImage = "https://i.ibb.co/5hJNv91R/3e16b1eef41a43cdd434d59a98e89e9b.jpg",
                Phone = "0945732399",
                Firstname = "Sĩ",
                Lastname = "Tiến",
                Birthday = new DateOnly(1990, 1, 1),
                Gender = true,
                CreatedDate = DateTime.UtcNow,
                IsAcceptMarketing = true,
                RoleId = new Guid("C3D4E5F6-A7B8-4901-CDEF-34567890ABCD"),
                IsBanned = false,
                ReasonBan = null,
                IsDeleted = false
            }
        };

        public static User GetIndex(int index)
        {
            if (index >= 0 && index < Users.Length)
            {
                return Users[index];
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Chỉ số không hợp lệ.");
            }
        }

        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(Users);
        }
    }
}
