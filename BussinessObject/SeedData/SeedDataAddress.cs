using BussinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace BussinessObject.SeedData
{
    public static class SeedDataAddress
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserAddress>().HasData(
                new UserAddress
                {
                    AddressId = Guid.NewGuid(),
                    UserId = SeedDataUser.GetIndex(0).UserId,
                    Fullname = "Nguyen Van A",
                    Phone = "0123456789",
                    AddressName = "123 Đường ABC, Phường 1, Quận 1, TP.HCM"
                },
                new UserAddress
                {
                    AddressId = Guid.NewGuid(),
                    UserId = SeedDataUser.GetIndex(3).UserId,
                    Fullname = "Tran Thi B",
                    Phone = "0987654321",
                    AddressName = "456 Đường XYZ, Phường 2, Quận 2, TP.HCM"
                },
                new UserAddress
                {
                    AddressId = Guid.NewGuid(),
                    UserId = SeedDataUser.GetIndex(2).UserId,
                    Fullname = "Le Van C",
                    Phone = "0912345678",
                    AddressName = "789 Đường QWE, Phường 3, Quận 3, TP.HCM"
                },

                //
                new UserAddress
                {
                    AddressId = Guid.NewGuid(),
                    UserId = SeedDataUser.GetIndex(4).UserId,
                    Fullname = "Pham Thi D",
                    Phone = "0938765432",
                    AddressName = "321 Đường GHI, Phường 4, Quận 4, TP.HCM"
                },
                new UserAddress
                {
                    AddressId = Guid.NewGuid(),
                    UserId = SeedDataUser.GetIndex(5).UserId,
                    Fullname = "Nguyen Van E",
                    Phone = "0945671234",
                    AddressName = "654 Đường JKL, Phường 5, Quận 5, TP.HCM"
                },
                new UserAddress
                {
                    AddressId = Guid.NewGuid(), 
                    UserId = SeedDataUser.GetIndex(5).UserId, 
                    Fullname = "Hoang Van F",
                    Phone = "0954321765",
                    AddressName = "987 Đường MNO, Phường 6, Quận 6, TP.HCM"
                }
            );
        }
    }
}
