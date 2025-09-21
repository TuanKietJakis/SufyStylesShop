using BussinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace BussinessObject.SeedData
{
    public static class SeedDataLikeList
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PostLike>().HasData(
                new PostLike
                {
                    UserId = new Guid("7ED45DA6-D22C-43C6-91F1-A1FD396CE414"), // Existing UserId from User table
                    PostId = new Guid("1F1021A2-FD1B-4142-B1DF-019E763053FB")  // Existing PostId from Post table
                },
                new PostLike
                {
                    UserId = new Guid("C76DD8D3-A7F4-4F95-BAEA-8E52B31730C6"), // Another existing UserId
                    PostId = new Guid("1F1021A2-FD1B-4142-B1DF-019E763053FB")  // Another existing PostId
                },
                new PostLike
                {
                    UserId = new Guid("C33912D3-4525-43F1-B893-07580F2C4226"), // Another existing UserId
                    PostId = new Guid("1F1021A2-FD1B-4142-B1DF-019E763053FB")  // Same PostId as the first entry
                },
                new PostLike
                {
                    UserId = new Guid("C33912D3-4525-43F1-B893-07580F2C4226"), // New UserId
                    PostId = new Guid("7B1021A2-FD1B-4142-B1DF-019E763053FB")  // New PostId
                },
                new PostLike
                {
                    UserId = new Guid("C76DD8D3-A7F4-4F95-BAEA-8E52B31730C6"), // Existing UserId
                    PostId = new Guid("7D1021A2-FD1B-4142-B1DF-019E763053FB")  // New PostId
                },
                new PostLike
                {
                    UserId = new Guid("C76DD8D3-A7F4-4F95-BAEA-8E52B31730C6"), // Existing UserId
                    PostId = new Guid("BCB12B9B-D374-4505-9051-3A7CDE836F21")  // New PostId
                }
            );
        }
    }
}
