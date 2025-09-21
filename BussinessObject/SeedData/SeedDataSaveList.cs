using BussinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace BussinessObject.SeedData
{
    public static class SeedDataSaveList
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PostBookmark>().HasData(
                new PostBookmark
                {
                    UserId = SeedDataUser.GetIndex(6).UserId, 
                    PostId = SeedDataPost.GetIndex(1).PostId, 
                    SaveDate = DateTime.Now.AddDays(-10)
                },
                new PostBookmark
                {
                    UserId = SeedDataUser.GetIndex(6).UserId, 
                    PostId = SeedDataPost.GetIndex(0).PostId,
                    SaveDate = DateTime.Now.AddDays(-5)
                },
                new PostBookmark
                {
                    UserId = SeedDataUser.GetIndex(5).UserId,
                    PostId = SeedDataPost.GetIndex(1).PostId, 
                    SaveDate = DateTime.Now.AddDays(-2)
                },
                new PostBookmark
                {
                    UserId = SeedDataUser.GetIndex(5).UserId, 
                    PostId = SeedDataPost.GetIndex(3).PostId,
                    SaveDate = DateTime.Now.AddDays(-2)
                },
                new PostBookmark
                {
                    UserId = SeedDataUser.GetIndex(4).UserId, 
                    PostId = SeedDataPost.GetIndex(1).PostId, 
                    SaveDate = DateTime.Now.AddDays(-2)
                }
            );
        }
    }
}
