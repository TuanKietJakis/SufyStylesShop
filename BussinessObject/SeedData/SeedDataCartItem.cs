using BussinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace BussinessObject.SeedData
{
    public static class SeedDataCartItem
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CartItem>().HasData(
                new CartItem
                {
                    CartItemId = Guid.NewGuid(),
                    UserId = SeedDataUser.GetIndex(0).UserId,
                    ProductId = SeedDataProduct.GetIndex(0).ProductId,                
                    Quantity = 2,
                    VariantId = SeedDataProductVariant.GetIndex(0).VariantId,
               
                },
                new CartItem
                {
                    CartItemId = Guid.NewGuid(),
                    UserId = SeedDataUser.GetIndex(0).UserId, 
                    ProductId = SeedDataProduct.GetIndex(0).ProductId,            
                    Quantity = 1,
                    VariantId = SeedDataProductVariant.GetIndex(1).VariantId,
                
                },
                new CartItem
                {
                    CartItemId = Guid.NewGuid(), 
                    UserId = SeedDataUser.GetIndex(1).UserId,
                    ProductId = SeedDataProduct.GetIndex(0).ProductId,              
                    Quantity = 3,
                    VariantId = SeedDataProductVariant.GetIndex(2).VariantId,
 
                },
                new CartItem
                {
                    CartItemId = Guid.NewGuid(), 
                    UserId = SeedDataUser.GetIndex(2).UserId, 
                    ProductId = SeedDataProduct.GetIndex(0).ProductId,              
                    Quantity = 3,
                    VariantId = SeedDataProductVariant.GetIndex(3).VariantId

                },
                
                new CartItem
                {
                    CartItemId = Guid.NewGuid(),
                    UserId = SeedDataUser.GetIndex(2).UserId,
                    ProductId = SeedDataProduct.GetIndex(1).ProductId,
                    Quantity = 3,
                    VariantId = SeedDataProductVariant.GetIndex(13).VariantId
                },
                new CartItem
                {
                    CartItemId = Guid.NewGuid(),
                    UserId = SeedDataUser.GetIndex(4).UserId,
                    ProductId = SeedDataProduct.GetIndex(0).ProductId,
                    Quantity = 3,
                    VariantId = SeedDataProductVariant.GetIndex(0).VariantId
                }, 
                new CartItem
                {
                    CartItemId = Guid.NewGuid(),
                    UserId = SeedDataUser.GetIndex(4).UserId,
                    ProductId = SeedDataProduct.GetIndex(1).ProductId,
                    Quantity = 3,
                    VariantId = SeedDataProductVariant.GetIndex(15).VariantId
                },
                new CartItem
                {
                    CartItemId = Guid.NewGuid(),
                    UserId = SeedDataUser.GetIndex(3).UserId,
                    ProductId = SeedDataProduct.GetIndex(1).ProductId,
                    Quantity = 3,
                    VariantId = SeedDataProductVariant.GetIndex(16).VariantId
                },
                new CartItem
                {
                    CartItemId = Guid.NewGuid(),
                    UserId = SeedDataUser.GetIndex(5).UserId,
                    ProductId = SeedDataProduct.GetIndex(0).ProductId,
                    Quantity = 3,
                    VariantId = SeedDataProductVariant.GetIndex(1).VariantId
                },
                 new CartItem
                 {
                     CartItemId = Guid.NewGuid(),
                     UserId = SeedDataUser.GetIndex(5).UserId,
                     ProductId = SeedDataProduct.GetIndex(0).ProductId,
                     Quantity = 3,
                     VariantId = SeedDataProductVariant.GetIndex(6).VariantId
                 },
                  new CartItem
                  {
                      CartItemId = Guid.NewGuid(),
                      UserId = SeedDataUser.GetIndex(5).UserId,
                      ProductId = SeedDataProduct.GetIndex(0).ProductId,
                      Quantity = 5,
                      VariantId = SeedDataProductVariant.GetIndex(7).VariantId
                  },
                  new CartItem
                  {
                      CartItemId = Guid.NewGuid(),
                      UserId = SeedDataUser.GetIndex(5).UserId,
                      ProductId = SeedDataProduct.GetIndex(0).ProductId,
                      Quantity = 5,
                      VariantId = SeedDataProductVariant.GetIndex(2).VariantId
                  },
                  new CartItem
                  {
                      CartItemId = Guid.NewGuid(),
                      UserId = SeedDataUser.GetIndex(6).UserId,
                      ProductId = SeedDataProduct.GetIndex(2).ProductId,
                      Quantity = 5,
                      VariantId = SeedDataProductVariant.GetIndex(18).VariantId
                  },
                   new CartItem
                   {
                       CartItemId = Guid.NewGuid(),
                       UserId = SeedDataUser.GetIndex(6).UserId,
                       ProductId = SeedDataProduct.GetIndex(3).ProductId,
                       Quantity = 3,
                       VariantId = SeedDataProductVariant.GetIndex(28).VariantId
                   },
                  new CartItem
                  {
                      CartItemId = Guid.NewGuid(),
                      UserId = SeedDataUser.GetIndex(6).UserId,
                      ProductId = SeedDataProduct.GetIndex(4).ProductId,
                      Quantity = 5,
                      VariantId = SeedDataProductVariant.GetIndex(30).VariantId
                  },
                   new CartItem
                   {
                       CartItemId = Guid.NewGuid(),
                       UserId = SeedDataUser.GetIndex(7).UserId,
                       ProductId = SeedDataProduct.GetIndex(5).ProductId,
                       Quantity = 3,
                       VariantId = SeedDataProductVariant.GetIndex(35).VariantId
                   },
                  new CartItem
                  {
                      CartItemId = Guid.NewGuid(),
                      UserId = SeedDataUser.GetIndex(7).UserId,
                      ProductId = SeedDataProduct.GetIndex(37).ProductId,
                      Quantity = 5,
                      VariantId = SeedDataProductVariant.GetIndex(6).VariantId
                  }

            );
        }
    }
}
