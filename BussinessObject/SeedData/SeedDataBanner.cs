using BussinessObject.Model;
using BussinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject.SeedData
{
    public static class SeedDataBanner
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Banner>().HasData(
                new Banner
                {
                    Id = new Guid("89DF6059-AA11-447D-BEBF-0245D58C3CD9"),
                    UpdatedUserId = new Guid("3F1A7D9B-8E2C-4D5A-9B2F-6C8D4E1F5A3C"),
                    CreatedAt = DateTime.UtcNow, // Sử dụng UTC để đồng bộ thời gian
                    IsVisible = true,
                    Name = "Default Banner", 
                    Position = "middle",
                    UrlImage = "https://i.ibb.co/PvvGqNKq/snapedit-1740048255310.png" // Thêm URL ảnh mặc định
                },
                 new Banner
                 {
                     Id = new Guid("CA580F95-CEC1-4F8E-882E-81902369931C"),
                     UpdatedUserId = new Guid("3F1A7D9B-8E2C-4D5A-9B2F-6C8D4E1F5A3C"),
                     CreatedAt = DateTime.UtcNow, // Sử dụng UTC để đồng bộ thời gian
                     IsVisible = true,
                     Name = "Default Banner",
                     Position = "main",
                     UrlImage = "https://i.ibb.co/38tSrC7/snapedit-1740047950782.png" // Thêm URL ảnh mặc định
                 },
                  new Banner
                  {
                      Id = new Guid("2BCBBC17-3328-4B4F-ABFF-BDCD24039A11"),
                      UpdatedUserId = new Guid("3F1A7D9B-8E2C-4D5A-9B2F-6C8D4E1F5A3C"),
                      CreatedAt = DateTime.UtcNow, // Sử dụng UTC để đồng bộ thời gian
                      IsVisible = true,
                      Name = "Default Banner",
                      Position = "bottom",
                      UrlImage = "https://i.ibb.co/k2HhvNdn/snapedit-1740048273832.png" // Thêm URL ảnh mặc định
                  },
                  new Banner
                  {
                      Id = Guid.NewGuid(),
                      UpdatedUserId = new Guid("3F1A7D9B-8E2C-4D5A-9B2F-6C8D4E1F5A3C"),
                      CreatedAt = DateTime.UtcNow, // Sử dụng UTC để đồng bộ thời gian
                      IsVisible = true,
                      Name = "Default Banner",
                      Position = "shop",
                      UrlImage = "https://i.ibb.co/rf0GnfGw/z6480777208634-0229fae4fa72911ba5131ec5155a9627.jpg" // Thêm URL ảnh mặc định
                  }
            );
        }
    }

}
