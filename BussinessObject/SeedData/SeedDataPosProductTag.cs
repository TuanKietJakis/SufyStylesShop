using BussinessObject.Model;
using Microsoft.EntityFrameworkCore;
using System;

namespace BussinessObject.SeedData
{
    public static class SeedDataPostProductTag
    {
        private static readonly PostProductTag[] PostProductTags = new PostProductTag[]
        {
            new PostProductTag
            {
                PostProductTagId = Guid.Parse("5859A90B-8E65-42E7-AF73-2713A1CA30B3"),
                PostId = Guid.Parse("B9F3D0D4-6F68-400F-BAD2-9B83EB673ACA"),
                ProductId = SeedDataProduct.Products[0].ProductId,
                UrlImage = SeedDataProduct.Products[0].UrlImage,
                ProductName = SeedDataProduct.Products[0].ProductName
            },
            new PostProductTag
            {
                PostProductTagId = Guid.NewGuid(),
                PostId = Guid.Parse("19028697-7C61-457A-80B0-C2B26E94EBD5"),
                ProductId = SeedDataProduct.Products[4].ProductId,
                UrlImage = SeedDataProduct.Products[4].UrlImage,
                ProductName = SeedDataProduct.Products[4].ProductName
            },
             new PostProductTag
            {
                PostProductTagId = Guid.NewGuid(),
                PostId = Guid.Parse("ccce4a73-de31-4282-aa08-abe659efb1ca"),
                ProductId = SeedDataProduct.Products[4].ProductId,
                UrlImage = SeedDataProduct.Products[4].UrlImage,
                ProductName = SeedDataProduct.Products[4].ProductName
            },
            new PostProductTag
            {
                PostProductTagId = Guid.NewGuid(),
                PostId = Guid.Parse("4c3c0968-7694-4fcd-b49c-ac8354ef0311"),
                ProductId = SeedDataProduct.Products[10].ProductId,
                UrlImage = SeedDataProduct.Products[10].UrlImage,
                ProductName = SeedDataProduct.Products[10].ProductName
            },
             new PostProductTag
            {
                PostProductTagId = Guid.NewGuid(),
                PostId = Guid.Parse("07b99ca1-de5a-4905-a56c-9494592304d2"),
                ProductId = SeedDataProduct.Products[10].ProductId,
                UrlImage = SeedDataProduct.Products[10].UrlImage,
                ProductName = SeedDataProduct.Products[10].ProductName
            },
             new PostProductTag
            {
                PostProductTagId = Guid.NewGuid(),
                PostId = Guid.Parse("6d2d1944-9398-4b1a-b498-a22f669893c8"),
                ProductId = SeedDataProduct.Products[10].ProductId,
                UrlImage = SeedDataProduct.Products[10].UrlImage,
                ProductName = SeedDataProduct.Products[10].ProductName
            }
        };

        public static PostProductTag GetIndex(int index)
        {
            if (index < 0 || index >= PostProductTags.Length)
            {
                throw new IndexOutOfRangeException("Index out of range for seed data.");
            }
            return PostProductTags[index];
        }

        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PostProductTag>().HasData(PostProductTags);
        }
    }
}
