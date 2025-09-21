using BussinessObject.Model;
using BussinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace BussinessObject.SeedData
{
    public static class SeedDataUserVoucher
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserVoucher>().HasData(
                new UserVoucher
                {
                    VoucherId = Guid.NewGuid(),
                    UserCreateId = new Guid("3F1A7D9B-8E2C-4D5A-9B2F-6C8D4E1F5A3C"),
                    DiscountValue = 10000,
                    MinimumOrderValue = 100000,
                    ExpiryDate = DateTime.Now.AddDays(7),
                    StartDate = DateTime.Now,
                    IsActive = false,
                    CurrentUsage = 0,
                    MaxUsage = 10,
                    Description = "Giảm 10000",
                    CreateDate = DateTime.Now,
                },
                new UserVoucher
                {
                    VoucherId = Guid.NewGuid(),
                    UserCreateId = new Guid("3F1A7D9B-8E2C-4D5A-9B2F-6C8D4E1F5A3C"),
                    DiscountValue = 20000,
                    MinimumOrderValue = 200000,
                    ExpiryDate = DateTime.Now.AddDays(14),
                    StartDate = DateTime.Now,
                    IsActive = true,
                    CurrentUsage = 0,
                    MaxUsage = 50,
                    Description = "Giảm 20000",
                    CreateDate = DateTime.Now,
                },
                new UserVoucher
                {
                    VoucherId = Guid.NewGuid(),
                    UserCreateId = new Guid("3F1A7D9B-8E2C-4D5A-9B2F-6C8D4E1F5A3C"),
                    DiscountValue = 5000,
                    MinimumOrderValue = 50000,
                    ExpiryDate = DateTime.Now.AddDays(3),
                    StartDate = DateTime.Now,
                    IsActive = true,
                    CurrentUsage = 1,
                    MaxUsage = 30,
                    Description = "Giảm 5000",
                    CreateDate = DateTime.Now,
                },
                new UserVoucher
                {
                    VoucherId = Guid.NewGuid(),
                    UserCreateId = new Guid("3F1A7D9B-8E2C-4D5A-9B2F-6C8D4E1F5A3C"),
                    DiscountValue = 50000,
                    MinimumOrderValue = 1000000,
                    ExpiryDate = DateTime.Now.AddMonths(1),
                    StartDate = DateTime.Now,
                    IsActive = true,
                    CurrentUsage = 0,
                    MaxUsage = 10,
                    Description = "Giảm 50000",
                    CreateDate = DateTime.Now,
                },
                new UserVoucher
                {
                    VoucherId = Guid.NewGuid(),
                    UserCreateId = new Guid("3F1A7D9B-8E2C-4D5A-9B2F-6C8D4E1F5A3C"),
                    DiscountValue = 30000,
                    MinimumOrderValue = 500000,
                    ExpiryDate = DateTime.Now.AddDays(10),
                    StartDate = DateTime.Now.AddDays(-2),
                    IsActive = false,
                    CurrentUsage = 2,
                    MaxUsage = 50,
                    Description = "Giảm 30000",
                    CreateDate = DateTime.Now,
                },
                new UserVoucher
                {
                    VoucherId = Guid.NewGuid(),
                    UserCreateId = new Guid("3F1A7D9B-8E2C-4D5A-9B2F-6C8D4E1F5A3C"),
                    DiscountValue = 15000,
                    MinimumOrderValue = 150000,
                    ExpiryDate = DateTime.Now.AddDays(20),
                    StartDate = DateTime.Now,
                    IsActive = true,
                    CurrentUsage = 0,
                    MaxUsage = 70,
                    Description = "Giảm giá mùa lễ hội",
                    CreateDate = DateTime.Now,
                }
            );
        }
    }
}
