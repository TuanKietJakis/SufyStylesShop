using BussinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace BussinessObject.SeedData
{
    public static class SeedDataProductVendor
    {
        // Tạo mảng tĩnh lưu dữ liệu ProductVendor
        public static readonly ProductVendor[] ProductVendors = new ProductVendor[]
        {
            new ProductVendor
            {
                ProductVendorId = Guid.NewGuid(), //0
                ProductVendorName = "Calem_Club",
                UrlImage = "https://i.ibb.co/QvBkp1Sj/Calem.jpg",
                SaveDate = DateTime.Now
            },
            new ProductVendor
            {
                ProductVendorId = Guid.NewGuid(), //1
                ProductVendorName = "JULIDO",
                UrlImage= "https://i.ibb.co/C5D0Gv39/JULIDO.jpg",
                SaveDate = DateTime.Now
            },
            new ProductVendor
            {
                ProductVendorId = Guid.NewGuid(), //2
                ProductVendorName = "Yody",
                UrlImage= "https://i.ibb.co/wZCszsbx/yody.jpg",
                SaveDate = DateTime.Now
            },
            new ProductVendor
            {
                ProductVendorId = Guid.NewGuid(),//3
                ProductVendorName = "Bitis",
                 UrlImage= "https://i.ibb.co/0jCF68xP/bitis2.png",
                SaveDate = DateTime.Now
            },
            new ProductVendor
            {
                ProductVendorId = Guid.NewGuid(),
                ProductVendorName = "Anh Thơ Leather",
                 UrlImage= "https://i.ibb.co/yF4YLCG1/Anh-Th-Leather.png",
                SaveDate = DateTime.Now
            }
        };

        public static void Seed(ModelBuilder modelBuilder)
        {
            // Sử dụng dữ liệu từ mảng ProductVendors
            modelBuilder.Entity<ProductVendor>().HasData(ProductVendors);
        }

        // Phương thức GetIndex để lấy ProductVendor dựa trên chỉ số
        public static ProductVendor GetIndex(int index)
        {
            if (index < 0 || index >= ProductVendors.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Index must be within the range of product vendors.");
            }

            return ProductVendors[index];
        }
    }
}
