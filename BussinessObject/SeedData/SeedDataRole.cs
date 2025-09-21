using BussinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace BussinessObject.SeedData
{
    public static class SeedDataRole
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(
                new Role
                {
                    RoleId = new Guid("A1B2C3D4-E5F6-4789-ABCD-1234567890AB"),
                    RoleName = "Admin"
                },
                new Role
                {
                    RoleId = new Guid("B2C3D4E5-F6A7-4890-BCDE-234567890ABC"),
                    RoleName = "Staff"
                },
                new Role
                {
                    RoleId = new Guid("C3D4E5F6-A7B8-4901-CDEF-34567890ABCD"),
                    RoleName = "Customer"
                }
            );
        }
    }
}
