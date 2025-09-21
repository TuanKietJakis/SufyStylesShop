using BussinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace BussinessObject.SeedData
{
    public static class SeedDataPaymentMethod
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PaymentMethod>().HasData(
                new PaymentMethod
                {
                    PaymentMethodId = Guid.Parse("D1E2F3A4-B5C6-7890-1234-56789ABCDEF0"), 
                    PaymentName = "Cash"
                },
                new PaymentMethod
                {
                    PaymentMethodId = Guid.Parse("F1E2D3C4-B5A6-7890-1234-56789ABCDEF1"), 
                    PaymentName = "VNPay"
                }
            );
        }
    }
}
