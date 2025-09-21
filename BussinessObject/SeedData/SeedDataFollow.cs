using BussinessObject.Model;
using BussinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace BussinessObject.SeedData
{
    public static class SeedDataFollow
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserFollow>().HasData(
                // User1 follows others
                new UserFollow
                {
                    FollowingId = new Guid("C76DD8D3-A7F4-4F95-BAEA-8E52B31730C6"), // User2
                    FollowerId = new Guid("C33912D3-4525-43F1-B893-07580F2C4226"), // User1
                    FollowDate = DateTime.Now.AddDays(-10)
                 
                },
                new UserFollow
                {
                    FollowingId = new Guid("7ED45DA6-D22C-43C6-91F1-A1FD396CE414"), // User3
                    FollowerId = new Guid("C33912D3-4525-43F1-B893-07580F2C4226"), // User1
                    FollowDate = DateTime.Now.AddDays(-9)
                   
                },
                new UserFollow
                {
                    FollowingId = new Guid("5EB29BD0-1C6B-42BF-A2C7-C71E05D4B10D"), // User4
                    FollowerId = new Guid("C33912D3-4525-43F1-B893-07580F2C4226"), // User1
                    FollowDate = DateTime.Now.AddDays(-8)
                   
                },
                // User2 follows others
                new UserFollow
                {
                    FollowingId = new Guid("C33912D3-4525-43F1-B893-07580F2C4226"), // User1
                    FollowerId = new Guid("C76DD8D3-A7F4-4F95-BAEA-8E52B31730C6"), // User2
                    FollowDate = DateTime.Now.AddDays(-7)
                   
                },
                new UserFollow
                {
                    FollowingId = new Guid("7ED45DA6-D22C-43C6-91F1-A1FD396CE414"), // User3
                    FollowerId = new Guid("C76DD8D3-A7F4-4F95-BAEA-8E52B31730C6"), // User2
                    FollowDate = DateTime.Now.AddDays(-6)
                  
                },
                // User3 follows others
                new UserFollow
                {
                    FollowingId = new Guid("C33912D3-4525-43F1-B893-07580F2C4226"), // User1
                    FollowerId = new Guid("7ED45DA6-D22C-43C6-91F1-A1FD396CE414"), // User3
                    FollowDate = DateTime.Now.AddDays(-4)
                   
                },
                new UserFollow
                {
                    FollowingId = new Guid("C76DD8D3-A7F4-4F95-BAEA-8E52B31730C6"), // User2
                    FollowerId = new Guid("7ED45DA6-D22C-43C6-91F1-A1FD396CE414"), // User3
                    FollowDate = DateTime.Now.AddDays(-3)
                },
                new UserFollow
                {
                    FollowingId = new Guid("5EB29BD0-1C6B-42BF-A2C7-C71E05D4B10D"), // User4
                    FollowerId = new Guid("7ED45DA6-D22C-43C6-91F1-A1FD396CE414"), // User3
                    FollowDate = DateTime.Now.AddDays(-2),
                },
                // User4 follows others
                new UserFollow
                {
                    FollowingId = new Guid("C33912D3-4525-43F1-B893-07580F2C4226"), // User1
                    FollowerId = new Guid("5EB29BD0-1C6B-42BF-A2C7-C71E05D4B10D"), // User4
                    FollowDate = DateTime.Now.AddDays(-1)
                },
                new UserFollow
                {
                    FollowingId = new Guid("7ED45DA6-D22C-43C6-91F1-A1FD396CE414"), // User3
                    FollowerId = new Guid("5EB29BD0-1C6B-42BF-A2C7-C71E05D4B10D"), // User4
                    FollowDate = DateTime.Now
                },
                new UserFollow
                {
                    FollowingId = new Guid("72f81a38-545d-491a-a51f-2c97382a07cf"), // User3
                    FollowerId = new Guid("5EB29BD0-1C6B-42BF-A2C7-C71E05D4B10D"), // User4
                    FollowDate = DateTime.Now
                },
                new UserFollow
                {
                    FollowingId = new Guid("5EB29BD0-1C6B-42BF-A2C7-C71E05D4B10D"), 
                    FollowerId = new Guid("72f81a38-545d-491a-a51f-2c97382a07cf"), 
                    FollowDate = DateTime.Now
                },
                new UserFollow
                {
                    FollowingId = new Guid("2e833883-8ec0-496f-90d8-1665c4a236eb"), 
                    FollowerId = new Guid("72f81a38-545d-491a-a51f-2c97382a07cf"), 
                    FollowDate = DateTime.Now
                },
                new UserFollow
                {
                    FollowingId = new Guid("2e833883-8ec0-496f-90d8-1665c4a236eb"), 
                    FollowerId = new Guid("a659d92f-2df3-44e5-96c6-40aa4800ae6e"), 
                    FollowDate = DateTime.Now
                },
                new UserFollow
                {
                    FollowingId = new Guid("3F2504E0-4F89-11D3-9A0C-0305E82C3301"), 
                    FollowerId = new Guid("a659d92f-2df3-44e5-96c6-40aa4800ae6e"), 
                    FollowDate = DateTime.Now
                },
                new UserFollow
                {
                    FollowingId = new Guid("5EB29BD0-1C6B-42BF-A2C7-C71E05D4B10D"), 
                    FollowerId = new Guid("3F2504E0-4F89-11D3-9A0C-0305E82C3301"), 
                    FollowDate = DateTime.Now
                },
                new UserFollow
                {
                    FollowingId = new Guid("7ED45DA6-D22C-43C6-91F1-A1FD396CE414"), 
                    FollowerId = new Guid("3F2504E0-4F89-11D3-9A0C-0305E82C3301"), 
                    FollowDate = DateTime.Now
                },
                new UserFollow
                {
                    FollowingId = new Guid("7ED45DA6-D22C-43C6-91F1-A1FD396CE414"), 
                    FollowerId = new Guid("0c4a9f9c-fa19-475b-a1b0-e40e8cd751de"), 
                    FollowDate = DateTime.Now
                },
                new UserFollow
                {
                    FollowingId = new Guid("0c4a9f9c-fa19-475b-a1b0-e40e8cd751de"), 
                    FollowerId = new Guid("7ED45DA6-D22C-43C6-91F1-A1FD396CE414"), 
                    FollowDate = DateTime.Now
                },
                new UserFollow
                {
                    FollowingId = new Guid("3a80d09d-9d05-4fc9-8a19-889dac09ab37"), 
                    FollowerId = new Guid("68557c40-20ea-455d-9556-60def44eb928"), 
                    FollowDate = DateTime.Now
                },
                new UserFollow
                {
                    FollowingId = new Guid("68557c40-20ea-455d-9556-60def44eb928"), 
                    FollowerId = new Guid("3a80d09d-9d05-4fc9-8a19-889dac09ab37"), 
                    FollowDate = DateTime.Now
                }
            );
        }
    }
}
