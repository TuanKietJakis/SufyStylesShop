using BussinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace BussinessObject.SeedData
{
    public static class SeedDataWishList
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserWishList>().HasData(
                new UserWishList
                {
                    UserId = SeedDataUser.GetIndex(0).UserId,
                    ProductId = SeedDataProduct.GetIndex(0).ProductId,
                    SaveDate = DateTime.Now.AddDays(-15)
                },
                new UserWishList
                {
                    UserId = SeedDataUser.GetIndex(1).UserId,
                    ProductId = SeedDataProduct.GetIndex(0).ProductId,
                    SaveDate = DateTime.Now.AddDays(-10)            
                },
                new UserWishList
                {
                    UserId = SeedDataUser.GetIndex(0).UserId,
                    ProductId = SeedDataProduct.GetIndex(2).ProductId,
                    SaveDate = DateTime.Now.AddDays(-5)
                },
                new UserWishList
                {
                    UserId = SeedDataUser.GetIndex(0).UserId,
                    ProductId = SeedDataProduct.GetIndex(3).ProductId,
                    SaveDate = DateTime.Now.AddDays(-5)
                },
                 new UserWishList
                 {
                     UserId = SeedDataUser.GetIndex(0).UserId,
                     ProductId = SeedDataProduct.GetIndex(4).ProductId,
                     SaveDate = DateTime.Now.AddDays(-5)
                 },
                 new UserWishList
                {
                    UserId = SeedDataUser.GetIndex(5).UserId,
                    ProductId = SeedDataProduct.GetIndex(3).ProductId,
                    SaveDate = DateTime.Now.AddDays(-5)
                },
                 new UserWishList
                 {
                     UserId = SeedDataUser.GetIndex(5).UserId,
                     ProductId = SeedDataProduct.GetIndex(4).ProductId,
                     SaveDate = DateTime.Now.AddDays(-5)
                 },
                 new UserWishList
                {
                    UserId = SeedDataUser.GetIndex(5).UserId,
                    ProductId = SeedDataProduct.GetIndex(6).ProductId,
                    SaveDate = DateTime.Now.AddDays(-5)
                },
                 new UserWishList
                 {
                     UserId = SeedDataUser.GetIndex(5).UserId,
                     ProductId = SeedDataProduct.GetIndex(7).ProductId,
                     SaveDate = DateTime.Now.AddDays(-5)
                 } ,
                 new UserWishList
                {
                    UserId = SeedDataUser.GetIndex(6).UserId,
                    ProductId = SeedDataProduct.GetIndex(6).ProductId,
                    SaveDate = DateTime.Now.AddDays(-5)
                },
                 new UserWishList
                 {
                     UserId = SeedDataUser.GetIndex(6).UserId,
                     ProductId = SeedDataProduct.GetIndex(7).ProductId,
                     SaveDate = DateTime.Now.AddDays(-5)
                 }
            );
        }
    }
}
