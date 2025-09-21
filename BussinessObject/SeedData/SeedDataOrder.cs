using BussinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace BussinessObject.SeedData
{
    public static class SeedDataOrder
    {
        public static readonly Order[] Orders = new Order[]
        {
            new Order
            {
                OrderId = Guid.Parse("1669A143-21A3-4404-B200-6100CD2DCCDB"),
                UserId = new Guid("3F2504E0-4F89-11D3-9A0C-0305E82C3301"),
                PaymentMethodId = Guid.Parse("D1E2F3A4-B5C6-7890-1234-56789ABCDEF0"),
                Address = "123 Main St, New York",
                Fullname = "John Doe",
                OrderStatus = 2,
                PaymentStatus = "Cash",
                OrderShippingFee = 10.00,
                SubTotal = 100.00,
                OrderTotalPrice = 110.00,
                CreatedDate = new DateTime(2024, 08, 22),
                Phone = "0123456789"
            },
             new Order
            {
                OrderId = Guid.Parse("3F2A7E9B-5C6D-4A1F-9F78-3B1C45D7E8A2"),
                UserId = new Guid("3F2504E0-4F89-11D3-9A0C-0305E82C3301"),
                PaymentMethodId = Guid.Parse("D1E2F3A4-B5C6-7890-1234-56789ABCDEF0"),
                Address = "123 Kien Luong, Kien Giang",
                Fullname = "Nguyen Van A",
                OrderStatus = 1,
                PaymentStatus = "Cash",
                OrderShippingFee = 0,
                SubTotal = 170000,
                OrderTotalPrice = 170000,
                CreatedDate = new DateTime(2025, 03, 13),
                Phone = "0123456789"
            },
             new Order
            {
                OrderId = Guid.Parse("7E2C4A5D-8B1F-47A3-9D65-BF6E12C7D4A9"),
                UserId = new Guid("3F2504E0-4F89-11D3-9A0C-0305E82C3301"),
                PaymentMethodId = Guid.Parse("D1E2F3A4-B5C6-7890-1234-56789ABCDEF0"),
                Address = "123 Kien Luong, Kien Giang",
                Fullname = "Nguyen Van A",
                OrderStatus = 2,
                PaymentStatus = "Cash",
                OrderShippingFee = 0,
                SubTotal = 156000,
                OrderTotalPrice = 156000,
                CreatedDate = new DateTime(2025, 03, 12),
                Phone = "1234567890"
            },
             new Order
            {
                OrderId = Guid.Parse("1A9E5F7B-4C3D-2A6F-8B7D-C9E12F4A3B5D"),
                UserId = new Guid("C76DD8D3-A7F4-4F95-BAEA-8E52B31730C6"),
                PaymentMethodId = Guid.Parse("D1E2F3A4-B5C6-7890-1234-56789ABCDEF0"),
                Address = "456 Chau Thanh, Ben Tre",
                Fullname = "Nguyen Van B",
                OrderStatus = -1,
                ReasonCancel = "Nhiều lần không nhận hàng ",
                PaymentStatus = "Cash",
                OrderShippingFee = 0,
                SubTotal = 156000,
                OrderTotalPrice = 156000,
                CreatedDate = new DateTime(2025, 03, 13),
                Phone = "1234567830"
            },
             new Order
            {
                OrderId = Guid.Parse("F7B5C3D2-1A9E-4F6A-8B7D-2C9E5F4A3B1D"),
                UserId = new Guid("C76DD8D3-A7F4-4F95-BAEA-8E52B31730C6"),
                PaymentMethodId = Guid.Parse("D1E2F3A4-B5C6-7890-1234-56789ABCDEF0"),
                Address = "456 Chau Thanh, Ben Tre",
                Fullname = "Nguyen Van B",
                OrderStatus = -2,
                ReasonCancel = "Giao hàng thất bại",
                PaymentStatus = "Cash",
                OrderShippingFee = 0,
                SubTotal = 170000,
                OrderTotalPrice = 170000,
                CreatedDate = new DateTime(2025, 03, 01),
                Phone = "1234567830"
            },
             new Order
            {
                OrderId = Guid.Parse("B7D5F3A2-9C4E-1A6F-8B7D-2C9E5F4A3D1B"),
                UserId = new Guid("C76DD8D3-A7F4-4F95-BAEA-8E52B31730C6"),
                PaymentMethodId = Guid.Parse("D1E2F3A4-B5C6-7890-1234-56789ABCDEF0"),
                Address = "456 Chau Thanh, Ben Tre",
                Fullname = "Nguyen Van B",
                OrderStatus = 1,
                PaymentStatus = "Cash",
                OrderShippingFee = 0,
                SubTotal = 299000,
                OrderTotalPrice = 299000,
                CreatedDate = new DateTime(2025, 02, 21),
                Phone = "1234567830"
            },
             new Order
            {
                OrderId = Guid.Parse("ABCDEF12-3456-7890-ABCD-EF1234567890"),
                UserId = new Guid("7ED45DA6-D22C-43C6-91F1-A1FD396CE414"),
                PaymentMethodId = Guid.Parse("D1E2F3A4-B5C6-7890-1234-56789ABCDEF0"),
                Address = "678 Chau Thanh, Ben Tre",
                Fullname = "Nguyen Van C",
                OrderStatus = 1,
                PaymentStatus = "Cash",
                OrderShippingFee = 0,
                SubTotal = 170000,
                OrderTotalPrice = 170000,
                CreatedDate = new DateTime(2025, 03, 01),
                Phone = "1234587830"
            },
             new Order
            {
                OrderId = Guid.Parse("98765432-10FE-DCBA-9876-543210FEDCBA"),
                UserId = new Guid("7ED45DA6-D22C-43C6-91F1-A1FD396CE414"),
                PaymentMethodId = Guid.Parse("D1E2F3A4-B5C6-7890-1234-56789ABCDEF0"),
                Address = "678 Chau Thanh, Ben Tre",
                Fullname = "Nguyen Van C",
                OrderStatus = 1,
                PaymentStatus = "Cash",
                OrderShippingFee = 0,
                SubTotal = 156000,
                OrderTotalPrice = 156000,
                CreatedDate = new DateTime(2025, 03, 01),
                Phone = "1234587830"
            },
             new Order
            {
                OrderId = Guid.Parse("5E4D3C2B-1A09-8765-4321-0FEDCBA98765"),
                UserId = new Guid("7ED45DA6-D22C-43C6-91F1-A1FD396CE414"),
                PaymentMethodId = Guid.Parse("D1E2F3A4-B5C6-7890-1234-56789ABCDEF0"),
                Address = "678 Chau Thanh, Ben Tre",
                Fullname = "Nguyen Van C",
                OrderStatus = 1,
                PaymentStatus = "Cash",
                OrderShippingFee = 0,
                SubTotal = 299000,
                OrderTotalPrice = 299000,
                CreatedDate = new DateTime(2025, 02, 24),
                Phone = "1234587830"
            },
             new Order
            {
                OrderId = Guid.Parse("3F2504E0-4F89-41D3-9A0C-0305E82C3301"),
                UserId = new Guid("7ED45DA6-D22C-43C6-91F1-A1FD396CE414"),
                PaymentMethodId = Guid.Parse("D1E2F3A4-B5C6-7890-1234-56789ABCDEF0"),
                Address = "678 Chau Thanh, Ben Tre",
                Fullname = "Nguyen Van C",
                OrderStatus = 1,
                PaymentStatus = "Cash",
                OrderShippingFee = 0,
                SubTotal = 804000,
                OrderTotalPrice = 804000,
                CreatedDate = new DateTime(2025, 02, 28),
                Phone = "1234587830"
            },
             new Order
            {
                OrderId = Guid.Parse("A3F1D2B7-4C89-41D3-9A0C-5E72F8A1C6D4"),
                UserId = new Guid("5EB29BD0-1C6B-42BF-A2C7-C71E05D4B10D"),
                PaymentMethodId = Guid.Parse("D1E2F3A4-B5C6-7890-1234-56789ABCDEF0"),
                Address = "678 Ninh Kieu, Can Tho",
                Fullname = "Nguyen Van M",
                OrderStatus = 1,
                PaymentStatus = "Cash",
                OrderShippingFee = 0,
                SubTotal = 804000,
                OrderTotalPrice = 804000,
                CreatedDate = new DateTime(2024, 09, 14),
                Phone = "1233587830"
            },
             new Order
            {
                OrderId = Guid.Parse("D9B2A1F7-3C5D-4E19-824E-7F6A9CDB50E8"),
                UserId = new Guid("3F2504E0-4F89-11D3-9A0C-0305E82C3301"),
                PaymentMethodId = Guid.Parse("D1E2F3A4-B5C6-7890-1234-56789ABCDEF0"),
                Address = "678 Chau Thanh, kien Giang",
                Fullname = "Nguyen Van M",
                OrderStatus = 1,
                PaymentStatus = "Cash",
                OrderShippingFee = 0,
                SubTotal = 804000,
                OrderTotalPrice = 804000,
                CreatedDate = new DateTime(2025, 03, 14),
                Phone = "1433587830"
            },
             new Order
            {
                OrderId = Guid.Parse("8bee2131-f980-4009-a87d-f80fe21d7b54"),
                UserId = new Guid("3a80d09d-9d05-4fc9-8a19-889dac09ab37"),
                PaymentMethodId = Guid.Parse("D1E2F3A4-B5C6-7890-1234-56789ABCDEF0"),
                Address = "678 Chau Thanh, kien Giang",
                Fullname = "Nguyen Van M",
                OrderStatus = 0,
                PaymentStatus = "Cash",
                OrderShippingFee = 15000,
                SubTotal = 35780,
                OrderTotalPrice = 35795,
                CreatedDate = new DateTime(2025, 03, 15),
                Phone = "1433587030"
            },
             new Order
            {
                OrderId = Guid.Parse("281dad57-cfc2-42c1-8296-b5d34477a9a7"),
                UserId = new Guid("3a80d09d-9d05-4fc9-8a19-889dac09ab37"),
                PaymentMethodId = Guid.Parse("D1E2F3A4-B5C6-7890-1234-56789ABCDEF0"),
                Address = "678 Chau Thanh, kien Giang",
                Fullname = "Nguyen Van M",
                OrderStatus = 1,
                PaymentStatus = "Cash",
                OrderShippingFee = 15000,
                SubTotal = 35090,
                OrderTotalPrice = 50090,
                CreatedDate = new DateTime(2025, 03, 09),
                Phone = "1433587030"
            },
             new Order
            {
                OrderId = Guid.Parse("9319055b-75b9-4a73-aca8-2c347b563430"),
                UserId = new Guid("3a80d09d-9d05-4fc9-8a19-889dac09ab37"),
                PaymentMethodId = Guid.Parse("D1E2F3A4-B5C6-7890-1234-56789ABCDEF0"),
                Address = "678 Chau Thanh, kien Giang",
                Fullname = "Nguyen Van M",
                OrderStatus = 1,
                PaymentStatus = "Cash",
                OrderShippingFee = 15000,
                SubTotal = 35780,
                OrderTotalPrice = 50780,
                CreatedDate = new DateTime(2025, 03, 10),
                Phone = "1433587030"
            },
             new Order
            {
                OrderId = Guid.Parse("8405b9cc-3c7e-4d31-bdf0-c87165497c49"),
                UserId = new Guid("3a80d09d-9d05-4fc9-8a19-889dac09ab37"),
                PaymentMethodId = Guid.Parse("D1E2F3A4-B5C6-7890-1234-56789ABCDEF0"),
                Address = "678 Chau Thanh, kien Giang",
                Fullname = "Nguyen Van M",
                OrderStatus = 1,
                PaymentStatus = "Cash",
                OrderShippingFee = 15000,
                SubTotal = 35900,
                OrderTotalPrice = 50900,
                CreatedDate = new DateTime(2025, 03, 08),
                Phone = "1433587030"
            },
             new Order
            {
                OrderId = Guid.Parse("fc8ecfb8-c122-4d67-a636-6cf8ee3488bd"),
                UserId = new Guid("3a80d09d-9d05-4fc9-8a19-889dac09ab37"),
                PaymentMethodId = Guid.Parse("D1E2F3A4-B5C6-7890-1234-56789ABCDEF0"),
                Address = "678 Chau Thanh, kien Giang",
                Fullname = "Nguyen Van M",
                OrderStatus = 1,
                PaymentStatus = "Cash",
                OrderShippingFee = 15000,
                SubTotal = 35079,
                OrderTotalPrice = 50079,
                CreatedDate = new DateTime(2024, 09, 15),
                Phone = "1433587030"
            },
             new Order
            {
                OrderId = Guid.Parse("0ee1a9d2-7ae0-4e72-8dd4-796f4107071d"),
                UserId = new Guid("a659d92f-2df3-44e5-96c6-40aa4800ae6e"),
                PaymentMethodId = Guid.Parse("D1E2F3A4-B5C6-7890-1234-56789ABCDEF0"),
                Address = "678 Chau Thanh, kien Giang",
                Fullname = "Nguyen Ngọc My",
                OrderStatus = 1,
                PaymentStatus = "Cash",
                OrderShippingFee = 15000,
                SubTotal = 29500,
                OrderTotalPrice = 44500,
                CreatedDate = new DateTime(2025, 03, 17),
                Phone = "1433557030"
            },
             new Order
            {
                OrderId = Guid.Parse("ba362a9b-f690-4410-8357-be0154e5fcfb"),
                UserId = new Guid("72f81a38-545d-491a-a51f-2c97382a07cf"),
                PaymentMethodId = Guid.Parse("D1E2F3A4-B5C6-7890-1234-56789ABCDEF0"),
                Address = "678 Chau Thanh, Bến Tre",
                Fullname = "Nguyen Văn Tiến",
                OrderStatus = -2,
                PaymentStatus = "Cash",
                OrderShippingFee = 15000,
                SubTotal = 29500,
                OrderTotalPrice = 44500,
                CreatedDate = new DateTime(2025, 03, 15),
                Phone = "1433567030"
            },
             new Order
            {
                OrderId = Guid.Parse("3320194b-bfb7-4d57-b186-14af4f6a2a8c"),
                UserId = new Guid("72f81a38-545d-491a-a51f-2c97382a07cf"),
                PaymentMethodId = Guid.Parse("D1E2F3A4-B5C6-7890-1234-56789ABCDEF0"),
                Address = "678 Chau Thanh, Bến Tre",
                Fullname = "Nguyen Văn Tiến",
                OrderStatus = 0,
                PaymentStatus = "Cash",
                OrderShippingFee = 15000,
                SubTotal = 47885,
                OrderTotalPrice = 62885,
                CreatedDate = new DateTime(2024, 10, 14),
                Phone = "1433567030"
            },
             new Order
            {
                OrderId = Guid.Parse("9033e2f1-3d32-4be3-829f-5d33e1feae51"),
                UserId = new Guid("2e833883-8ec0-496f-90d8-1665c4a236eb"),
                PaymentMethodId = Guid.Parse("D1E2F3A4-B5C6-7890-1234-56789ABCDEF0"),
                Address = "34 Ninh Kiền, Cần Thơ",
                Fullname = "Nguyen Văn Anh",
                OrderStatus = 0,
                PaymentStatus = "Cash",
                OrderShippingFee = 15000,
                SubTotal = 395000,
                OrderTotalPrice = 410000,
                CreatedDate = new DateTime(2025, 03, 14),
                Phone = "1433564030"
            },/*
             new Order
            {
                OrderId = Guid.Parse("64ecfb4d-f392-4417-8c29-50ff1f3963c0"),
                UserId = new Guid("2e833883-8ec0-496f-90d8-1665c4a236eb"),
                PaymentMethodId = Guid.Parse("D1E2F3A4-B5C6-7890-1234-56789ABCDEF0"),
                Address = "34 Ninh Kiền, Cần Thơ",
                Fullname = "Nguyen Văn Anh",
                OrderStatus = 1,
                PaymentStatus = "Cash",
                OrderShippingFee = 15000,
                SubTotal = 47588,
                OrderTotalPrice = 62588,
                CreatedDate = new DateTime(2025, 03, 13),
                Phone = "1433564030"
            },*/
             new Order
            {
                OrderId = Guid.Parse("64ecfb4d-f392-4417-8c29-50ff1f3963c0"),
                UserId = new Guid("68557c40-20ea-455d-9556-60def44eb928"),
                PaymentMethodId = Guid.Parse("D1E2F3A4-B5C6-7890-1234-56789ABCDEF0"),
                Address = "98 Ninh Kiền, Cần Thơ",
                Fullname = "Nguyen Ngọc Quý",
                OrderStatus = -2,
                PaymentStatus = "Cash",
                OrderShippingFee = 15000,
                SubTotal = 42500,
                OrderTotalPrice = 57500,
                CreatedDate = new DateTime(2025, 02, 13),
                Phone = "1493564030"
            },
             new Order
            {
                OrderId = Guid.Parse("9c351f73-5de0-40dc-b019-1a7c793b45a1"),
                UserId = new Guid("68557c40-20ea-455d-9556-60def44eb928"),
                PaymentMethodId = Guid.Parse("D1E2F3A4-B5C6-7890-1234-56789ABCDEF0"),
                Address = "98 Ninh Kiền, Cần Thơ",
                Fullname = "Nguyen Ngọc Quý",
                OrderStatus = -1,
                PaymentStatus = "Cash",
                OrderShippingFee = 15000,
                SubTotal = 47588,
                OrderTotalPrice = 62588,
                CreatedDate = new DateTime(2025, 02, 10),
                Phone = "1493564030"
            },
             new Order
            {
                OrderId = Guid.Parse("ddbfbcf5-fc2a-4230-b1f6-f6cbc8cd076e"),
                UserId = new Guid("68557c40-20ea-455d-9556-60def44eb928"),
                PaymentMethodId = Guid.Parse("D1E2F3A4-B5C6-7890-1234-56789ABCDEF0"),
                Address = "98 Ninh Kiền, Cần Thơ",
                Fullname = "Nguyen Ngọc Quý",
                OrderStatus = 1,
                PaymentStatus = "Cash",
                OrderShippingFee = 15000,
                SubTotal = 47885,
                OrderTotalPrice = 62885,
                CreatedDate = new DateTime(2024, 12, 10),
                Phone = "1493564030"
            },
             new Order
            {
                OrderId = Guid.Parse("7c415451-17a1-457f-b3cd-f1052077b1e1"),
                UserId = new Guid("68557c40-20ea-455d-9556-60def44eb928"),
                PaymentMethodId = Guid.Parse("D1E2F3A4-B5C6-7890-1234-56789ABCDEF0"),
                Address = "98 Ninh Kiền, Cần Thơ",
                Fullname = "Nguyen Ngọc Quý",
                OrderStatus = 1,
                PaymentStatus = "Cash",
                OrderShippingFee = 15000,
                SubTotal = 47588,
                OrderTotalPrice = 62885,
                CreatedDate = new DateTime(2024, 12, 10),
                Phone = "1493564030"
            },
             new Order
            {
                OrderId = Guid.Parse("02745899-7490-4745-8b4f-42e15cbe8b0b"),
                UserId = new Guid("68557c40-20ea-455d-9556-60def44eb928"),
                PaymentMethodId = Guid.Parse("D1E2F3A4-B5C6-7890-1234-56789ABCDEF0"),
                Address = "98 Ninh Kiền, Cần Thơ",
                Fullname = "Nguyen Ngọc Quý",
                OrderStatus = 2,
                PaymentStatus = "Cash",
                OrderShippingFee = 15000,
                SubTotal = 47588,
                OrderTotalPrice = 62885,
                CreatedDate = new DateTime(2024, 11, 10),
                Phone = "1493564030"
            }
        };

        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>().HasData(Orders);
        }

        public static Order GetIndex(int index)
        {
            if (index < 0 || index >= Orders.Length)
                throw new ArgumentOutOfRangeException(nameof(index), "Index must be within the range of orders.");

            return Orders[index];
        }
    }

    public static class SeedDataOrderedDetail
    {
        public static readonly OrderedDetail[] OrderedDetails = new OrderedDetail[]
        {
            new OrderedDetail
             {
                OrderedProductId = Guid.Parse("88d38e51-3bab-46fe-8caa-327513a5cd37"),
                ProductId = Guid.Parse("7F825305-1CAC-4F46-AAC3-A2AC23E0BF19"),
                VariantId = Guid.Parse("ab62e24a-678a-4e1e-9439-6ea9826f0cb4"),
                OrderId = Guid.Parse("02745899-7490-4745-8b4f-42e15cbe8b0b"),
                ProductName = "C301 SNEAKER",
                Quantity = 20,
                ProductPrice = 47588
            },
            new OrderedDetail
             {
                OrderedProductId = Guid.Parse("e439418b-93c1-4322-9296-16b15ea48e3a"),
                ProductId = Guid.Parse("7F825305-1CAC-4F46-AAC3-A2AC23E0BF19"),
                VariantId = Guid.Parse("ab62e24a-678a-4e1e-9439-6ea9826f0cb4"),
                OrderId = Guid.Parse("7c415451-17a1-457f-b3cd-f1052077b1e1"),
                ProductName = "C301 SNEAKER",
                Quantity = 20,
                ProductPrice = 47588
            },
            new OrderedDetail
             {
                OrderedProductId = Guid.Parse("582dcb6a-473f-4307-be0f-aae9c0be503e"),
                ProductId = Guid.Parse("C5133F2F-2EC8-4A6F-89DD-DAF5019E4D0B"),
                VariantId = Guid.Parse("1af3662c-0abe-4297-ad27-96118d8339b1"),
                OrderId = Guid.Parse("ddbfbcf5-fc2a-4230-b1f6-f6cbc8cd076e"),
                ProductName = "TANNER LOAFER",
                Quantity = 20,
                ProductPrice = 47588
            },
            new OrderedDetail
             {
                OrderedProductId = Guid.Parse("14c7d914-b561-43b5-af3c-02da136d9177"),
                ProductId = Guid.Parse("24FCE224-8454-46AE-94E3-51561C4323FF"),
                VariantId = Guid.Parse("2ca08911-a12a-4674-99fd-bfc2ebe7ef6c"),
                OrderId = Guid.Parse("9c351f73-5de0-40dc-b019-1a7c793b45a1"),
                ProductName = "CARGO PANT ASIA FIT",
                Quantity = 7,
                ProductPrice = 47588
            },
            new OrderedDetail
             {
                OrderedProductId = Guid.Parse("511e0982-34a6-4c6c-a3a0-e262bd269627"),
                ProductId = Guid.Parse("BB64E3A4-B8CB-4630-AF6F-08A6831BDF8D"),
                VariantId = Guid.Parse("91242e70-719f-4deb-acc2-3e1a81b416d4"),
                OrderId = Guid.Parse("64ecfb4d-f392-4417-8c29-50ff1f3963c0"),
                ProductName = "LUCA DRIVER",
                Quantity = 1,
                ProductPrice = 42500
            }/*,
            new OrderedDetail
             {
                OrderedProductId = Guid.Parse("ca62bae3-5a22-4f31-9208-d9e574cd56cc"),
                ProductId = Guid.Parse("7F825305-1CAC-4F46-AAC3-A2AC23E0BF19"),
                VariantId = Guid.Parse("ab62e24a-678a-4e1e-9439-6ea9826f0cb4"),
                OrderId = Guid.Parse("64ecfb4d-f392-4417-8c29-50ff1f3963c0"),
                ProductName = "C301 SNEAKER",
                Quantity = 2,
                ProductPrice = 47588
            }*/,
            new OrderedDetail
             {
                OrderedProductId = Guid.Parse("ac6a3a4d-6fdf-4bd7-a90c-818876ef86ee"),
                ProductId = Guid.Parse("52939CDC-B01F-4A93-874F-2E1B8A8ECA5D"),
                VariantId = Guid.Parse("6ec0bbcb-3f03-4467-b9c9-5540a65e8763"),
                OrderId = Guid.Parse("9033e2f1-3d32-4be3-829f-5d33e1feae51"),
                ProductName = "TANNER LOAFER",
                Quantity = 1,
                ProductPrice = 395000
            },
            new OrderedDetail
             {
                OrderedProductId = Guid.Parse("033cc7d1-1aca-4da1-8042-e24c7a8613d3"),
                ProductId = Guid.Parse("52939CDC-B01F-4A93-874F-2E1B8A8ECA5D"),
                VariantId = Guid.Parse("1af3662c-0abe-4297-ad27-96118d8339b1"),
                OrderId = Guid.Parse("3320194b-bfb7-4d57-b186-14af4f6a2a8c"),
                ProductName = "SHORT INSEAM WIDE LEG TROUSERS",
                Quantity = 5,
                ProductPrice = 47885
            },
            new OrderedDetail
            {
                OrderedProductId = Guid.Parse("f458d04a-f6e5-4582-8e38-392ef4983d49"),
                ProductId = Guid.Parse("0D9DBE13-446B-41F4-9CDB-188265CE870D"),
                VariantId = Guid.Parse("bd4af864-ed2b-48a7-840e-c57bcab84064"),
                OrderId = Guid.Parse("ba362a9b-f690-4410-8357-be0154e5fcfb"),
                ProductName = "EMILIA MARY JANE",
                Quantity = 2,
                ProductPrice = 44500
            },
            new OrderedDetail
            {
                OrderedProductId = Guid.Parse("4f85633c-fba4-4c80-9dc4-80591933fbca"),
                ProductId = Guid.Parse("0D9DBE13-446B-41F4-9CDB-188265CE870D"),
                VariantId = Guid.Parse("bd4af864-ed2b-48a7-840e-c57bcab84064"),
                OrderId = Guid.Parse("0ee1a9d2-7ae0-4e72-8dd4-796f4107071d"),
                ProductName = "EMILIA MARY JANE",
                Quantity = 1,
                ProductPrice = 29500
            },
            new OrderedDetail
            {
                OrderedProductId = Guid.Parse("3974e163-7ef3-4344-851d-3aa61db9b188"),
                ProductId = Guid.Parse("5b7acda4-8b50-4c4e-a01f-cbc4c363d6df"),
                VariantId = Guid.Parse("88abde00-3156-4f51-bb30-2c99e8b6dc6d"),
                OrderId = Guid.Parse("fc8ecfb8-c122-4d67-a636-6cf8ee3488bd"),
                ProductName = "MARGOT SANDAL IN SIGNATURE TEXTILE JACQUARD",
                Quantity = 2,
                ProductPrice = 35079
            },
            new OrderedDetail
            {
                OrderedProductId = Guid.Parse("260b0311-a518-4a22-8c32-ec6cbc24aac9"),
                ProductId = Guid.Parse("6EDA30B6-2536-4C59-880D-29C9747D86FA"),
                VariantId = Guid.Parse("314863c3-cd35-49b6-ae3d-59c4031eef61"),
                OrderId = Guid.Parse("8405b9cc-3c7e-4d31-bdf0-c87165497c49"),
                ProductName = "Men's Colorful Mesh Baseball Cap",
                Quantity = 3,
                ProductPrice = 35900
            },
            new OrderedDetail
            {
                OrderedProductId = Guid.Parse("6971efec-c0ca-4783-ab2b-43864b1a2760"),
                ProductId = Guid.Parse("92448B12-C6CF-4D65-B820-B3E29FD258A1"),
                VariantId = Guid.Parse("24cfaec6-a55f-4743-adaa-e9462b859ae7"),
                OrderId = Guid.Parse("9319055b-75b9-4a73-aca8-2c347b563430"),
                ProductName = "Fashion Trend Baseball Cap/Net",
                Quantity = 2,
                ProductPrice = 35780
            },
            new OrderedDetail
            {
                OrderedProductId = Guid.Parse("3f4590f5-7ee1-4452-a20a-5373323ec811"),
                ProductId = Guid.Parse("6938AEA0-5775-42DD-8C94-D64D603A498B"),
                VariantId = Guid.Parse("2c81513c-3e14-46cb-9abd-160b1420c084"),
                OrderId = Guid.Parse("281dad57-cfc2-42c1-8296-b5d34477a9a7"),
                ProductName = "Waterproof Breathing Fishing Cap",
                Quantity = 2,
                ProductPrice = 35090
            },
            new OrderedDetail
            {
                OrderedProductId = Guid.Parse("fcb55a0b-ff83-46da-9a0c-e0af0e71a23e"),
                ProductId = Guid.Parse("db852178-b895-48ab-9bff-7d0211c02a40"),
                VariantId = Guid.Parse("1fb1cb3e-d1a1-4e77-9215-ca1577281b96"),
                OrderId = Guid.Parse("8bee2131-f980-4009-a87d-f80fe21d7b54"),
                ProductName = "Double-Knit Jacquard Ball Cap",
                Quantity = 1,
                ProductPrice = 35780
            },
            new OrderedDetail
            {
                OrderedProductId = Guid.Parse("27413398-8003-46DA-8B8F-3D00593AB09E"),
                ProductId = Guid.Parse("5A7FB27F-BE52-468B-97DE-270F1EFA4854"),
                VariantId = Guid.Parse("4A6ED1D5-2B39-4256-BFDF-9E5071196C66"),
                OrderId = Guid.Parse("1669A143-21A3-4404-B200-6100CD2DCCDB"),
                ProductName = "Calem Club - Quần Jeans Wash cạp cao Ống Rộng tôn dáng form thụng unisex",
                Quantity = 1,
                ProductPrice = 84000.00
            },
            new OrderedDetail
            {
                OrderedProductId = Guid.Parse("A9F1D5B2-4C38-45F7-8A12-E7D6C3B2F9A4"),
                ProductId = Guid.Parse("5A7FB27F-BE52-468B-97DE-270F1EFA4854"),
                VariantId = Guid.Parse("4A6ED1D5-2B39-4256-BFDF-9E5071196C66"),
                OrderId = Guid.Parse("3F2A7E9B-5C6D-4A1F-9F78-3B1C45D7E8A2"),
                ProductName = "Calem Club - Quần Jeans Wash cạp cao Ống Rộng tôn dáng form thụng unisex",
                Quantity = 1,
                ProductPrice = 156000
            },
            new OrderedDetail
            {
                OrderedProductId = Guid.Parse("2A9E5F7B-4C3D-6F1A-8B7D-C9E12F4A3B5D"),
                ProductId = Guid.Parse("5A7FB27F-BE52-468B-97DE-270F1EFA4854"),
                VariantId = Guid.Parse("4A6ED1D5-2B39-4256-BFDF-9E5071196C66"),
                OrderId = Guid.Parse("F7B5C3D2-1A9E-4F6A-8B7D-2C9E5F4A3B1D"),
                ProductName = "Calem Club - Quần Jeans Wash cạp cao Ống Rộng tôn dáng form thụng unisex",
                Quantity = 1,
                ProductPrice = 170000
            },
            new OrderedDetail
            {
                OrderedProductId = Guid.Parse("E3B7F5C2-9A4D-6F1A-2C87-5D9E4B7F3A1C"),
                ProductId = Guid.Parse("71931791-424F-4D04-AD87-5AA8AB6D13E8"),
                VariantId = Guid.Parse("5B7D2A9E-1C4F-3A8B-6F7D-2C9E45B1A7F3"),
                OrderId = Guid.Parse("7E2C4A5D-8B1F-47A3-9D65-BF6E12C7D4A9"),
                ProductName = "Áo khoác BOMBER nỉ 2 da JULIDO áo khoác nỉ logo M thêu nổi dày dặn (FORM BOXY)",
                Quantity = 1,
                ProductPrice = 156000
            },
            new OrderedDetail
            {
                OrderedProductId = Guid.Parse("C4D3A8B7-9F1E-2F5B-6A7D-5E9C4B2F1A3D"),
                ProductId = Guid.Parse("71931791-424F-4D04-AD87-5AA8AB6D13E8"),
                VariantId = Guid.Parse("5B7D2A9E-1C4F-3A8B-6F7D-2C9E45B1A7F3"),
                OrderId = Guid.Parse("1A9E5F7B-4C3D-2A6F-8B7D-C9E12F4A3B5D"),
                ProductName = "Áo khoác BOMBER nỉ 2 da JULIDO áo khoác nỉ logo M thêu nổi dày dặn (FORM BOXY)",
                Quantity = 1,
                ProductPrice = 170000
            },
            new OrderedDetail
            {
                OrderedProductId = Guid.Parse("12345678-90AB-CDEF-1234-567890ABCDEF"),
                ProductId = Guid.Parse("F0E1D2C3-B4A5-6789-0123-456789ABCDE0"),
                VariantId = Guid.Parse("A1B2C3D4-E5F6-7890-1234-56789ABCDEF0"),
                OrderId = Guid.Parse("B7D5F3A2-9C4E-1A6F-8B7D-2C9E5F4A3D1B"),
                ProductName = "Áo POLO nam Scafe- Khử mùi hiệu quả, co giãn, thấm hút mồ phối cổ năng động thương hiệu YODY APM3635",
                Quantity = 1,
                ProductPrice = 299000
            },
            new OrderedDetail
            {
                OrderedProductId = Guid.Parse("0FEDCBA9-8765-4321-0FED-CBA987654321"),
                ProductId = Guid.Parse("5A7FB27F-BE52-468B-97DE-270F1EFA4854"),
                VariantId = Guid.Parse("4A6ED1D5-2B39-4256-BFDF-9E5071196C66"),
                OrderId = Guid.Parse("ABCDEF12-3456-7890-ABCD-EF1234567890"),
                ProductName = "Quần Jean Ống Suông Calem Club wash màu tôn dáng form unisex nam nữ",
                Quantity = 1,
                ProductPrice = 170000
            },
            new OrderedDetail
            {
                OrderedProductId = Guid.Parse("1A2B3C4D-5E6F-7089-1A2B-3C4D5E6F7089"),
                ProductId = Guid.Parse("71931791-424F-4D04-AD87-5AA8AB6D13E8"),
                VariantId = Guid.Parse("5B7D2A9E-1C4F-3A8B-6F7D-2C9E45B1A7F3"),
                OrderId = Guid.Parse("ABCDEF12-3456-7890-ABCD-EF1234567890"),
                ProductName = "Áo khoác BOMBER nỉ 2 da JULIDO áo khoác nỉ logo M thêu nổi dày dặn (FORM BOXY)",
                Quantity = 1,
                ProductPrice = 156000
            },
            new OrderedDetail
            {
                OrderedProductId = Guid.Parse("FEDCBA98-7654-3210-FEDC-BA9876543210"),
                ProductId = Guid.Parse("F0E1D2C3-B4A5-6789-0123-456789ABCDE0"),
                VariantId = Guid.Parse("A1B2C3D4-E5F6-7890-1234-56789ABCDEF0"),
                OrderId = Guid.Parse("5E4D3C2B-1A09-8765-4321-0FEDCBA98765"),
                ProductName = "Áo POLO nam Scafe- Khử mùi hiệu quả, co giãn, thấm hút mồ phối cổ năng động thương hiệu YODY APM3635",
                Quantity = 1,
                ProductPrice = 299000
            },
            new OrderedDetail
            {
                OrderedProductId = Guid.Parse("B7D3F05C-78D9-431F-9910-FA7C51AB9C8D"),
                ProductId = Guid.Parse("E2A1C4F7-3B5D-4E19-824E-68F7A9CDB50F"),
                VariantId = Guid.Parse("6A1FD4B2-99E8-4C3B-A6E2-8575D9E6A7D4"),
                OrderId = Guid.Parse("3F2504E0-4F89-41D3-9A0C-0305E82C3301"),
                ProductName = "Giày Thể Thao Nam Biti's Hunter Core HSM005400XAM",
                Quantity = 1,
                ProductPrice = 804000
            },
            new OrderedDetail
            {
                OrderedProductId = Guid.Parse("F5C7D1A9-6E3B-45F8-92A1-BD7E4C8F5D2A"),
                ProductId = Guid.Parse("E2A1C4F7-3B5D-4E19-824E-68F7A9CDB50F"),
                VariantId = Guid.Parse("6A1FD4B2-99E8-4C3B-A6E2-8575D9E6A7D4"),
                OrderId = Guid.Parse("A3F1D2B7-4C89-41D3-9A0C-5E72F8A1C6D4"),
                ProductName = "Giày Thể Thao Nam Biti's Hunter Core HSM005400XAM",
                Quantity = 1,
                ProductPrice = 804000
            },
            new OrderedDetail
            {
                OrderedProductId = Guid.Parse("B8E4D3C7-5A2F-41F1-BF9A-EC9C628D8A71"),
                ProductId = Guid.Parse("E2A1C4F7-3B5D-4E19-824E-68F7A9CDB50F"),
                VariantId = Guid.Parse("6A1FD4B2-99E8-4C3B-A6E2-8575D9E6A7D4"),
                OrderId = Guid.Parse("D9B2A1F7-3C5D-4E19-824E-7F6A9CDB50E8"),
                ProductName = "Giày Thể Thao Nam Biti's Hunter Core HSM005400XAM",
                Quantity = 1,
                ProductPrice = 804000
            }
        };

        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderedDetail>().HasData(OrderedDetails);
        }
    }
}
