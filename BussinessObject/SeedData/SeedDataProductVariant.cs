using BussinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace BussinessObject.SeedData
{
    public static class SeedDataProductVariant
    {
        public static readonly ProductVariant[] ProductVariants = new ProductVariant[]
        { 
            new ProductVariant
            {
                VariantId = Guid.NewGuid(), //0
                ProductId = SeedDataProduct.GetIndex(0).ProductId,
                Price = 84000,
                Quantity = 30,
                UrlImage = "https://i.ibb.co/kVj9Yy5S/vn-11134207-7r98o-lyjovxwtwyap58-resize-w450-nl.webp",
                Option1 = "Size",
                OptionValue1 = "S",
                Option2 = "Color",
                OptionValue2 = "Xám nhạt",
                Option3 = "Material",
                OptionValue3 = "Jeans"
            },
            new ProductVariant
            {
                VariantId = Guid.NewGuid(), //1
                ProductId = SeedDataProduct.GetIndex(0).ProductId,
                Price = 84000,
                Quantity = 30,
                UrlImage = "https://i.ibb.co/kVj9Yy5S/vn-11134207-7r98o-lyjovxwtwyap58-resize-w450-nl.webp",
                Option1 = "Size",
                OptionValue1 = "M",
                Option2 = "Color",
                OptionValue2 = "Xám nhạt",
                Option3 = "Material",
                OptionValue3 = "Jeans"
            },
            new ProductVariant
            {
                VariantId = Guid.NewGuid(), //2
                ProductId = SeedDataProduct.GetIndex(0).ProductId,
                Price = 84000,
                Quantity = 35,
                UrlImage = "https://i.ibb.co/kVj9Yy5S/vn-11134207-7r98o-lyjovxwtwyap58-resize-w450-nl.webp",
                Option1 = "Size",
                OptionValue1 = "L",
                Option2 = "Color",
                OptionValue2 = "Xám nhạt",
                Option3 = "Material",
                OptionValue3 = "Jeans"
            },
            new ProductVariant
            {
                VariantId = Guid.NewGuid(), //3
                ProductId = SeedDataProduct.GetIndex(0).ProductId,
                Price = 170000,
                Quantity = 31,
                UrlImage = "https://i.ibb.co/TB4fx2CL/vn-11134207-7r98o-lyjow1zbvqz1d2-resize-w450-nl.webp",
                Option1 = "Size",
                OptionValue1 = "S",
                Option2 = "Color",
                OptionValue2 = "Vàng nhạt",
                Option3 = "Material",
                OptionValue3 = "Jeans"
            },
            new ProductVariant
            {
                VariantId = Guid.NewGuid(), //4
                ProductId = SeedDataProduct.GetIndex(0).ProductId,
                Price = 170000,
                Quantity = 31,
                UrlImage = "https://i.ibb.co/TB4fx2CL/vn-11134207-7r98o-lyjow1zbvqz1d2-resize-w450-nl.webp",
                Option1 = "Size",
                OptionValue1 = "M",
                Option2 = "Color",
                OptionValue2 = "Vàng nhạt",
                Option3 = "Material",
                OptionValue3 = "Jeans"
            },
            new ProductVariant
            {
                VariantId = Guid.NewGuid(), //5
                ProductId = SeedDataProduct.GetIndex(0).ProductId,
                Price = 170000,
                Quantity = 31,
                UrlImage = "https://i.ibb.co/TB4fx2CL/vn-11134207-7r98o-lyjow1zbvqz1d2-resize-w450-nl.webp",
                Option1 = "Size",
                OptionValue1 = "L",
                Option2 = "Color",
                OptionValue2 = "Vàng nhạt",
                Option3 = "Material",
                OptionValue3 = "Jeans"
            },
            new ProductVariant
            {
                VariantId = Guid.NewGuid(), //6
                ProductId = SeedDataProduct.GetIndex(0).ProductId,
                Price = 170000,
                Quantity = 31,
                UrlImage = "https://i.ibb.co/DgwprN9Z/vn-11134207-7r98o-lyjow7frwa75de-resize-w450-nl.webp",
                Option1 = "Size",
                OptionValue1 = "S",
                Option2 = "Color",
                OptionValue2 = "Rêu nhạt",
                Option3 = "Material",
                OptionValue3 = "Jeans"
            },
            new ProductVariant
            {
                VariantId = Guid.Parse("4A6ED1D5-2B39-4256-BFDF-9E5071196C66"), //7
                ProductId = SeedDataProduct.GetIndex(0).ProductId,
                Price = 170000,
                Quantity = 31,
                UrlImage = "https://i.ibb.co/DgwprN9Z/vn-11134207-7r98o-lyjow7frwa75de-resize-w450-nl.webp",
                Option1 = "Size",
                OptionValue1 = "M",
                Option2 = "Color",
                OptionValue2 = "Rêu nhạt",
                Option3 = "Material",
                OptionValue3 = "Jeans"
            },
            new ProductVariant
            {
                VariantId = Guid.NewGuid(), //8
                ProductId = SeedDataProduct.GetIndex(0).ProductId,
                Price = 170000,
                Quantity = 31,
                UrlImage = "https://i.ibb.co/DgwprN9Z/vn-11134207-7r98o-lyjow7frwa75de-resize-w450-nl.webp",
                Option1 = "Size",
                OptionValue1 = "L",
                Option2 = "Color",
                OptionValue2 = "Rêu nhạt",
                Option3 = "Material",
                OptionValue3 = "Jeans"
            },

            new ProductVariant
            {
                VariantId = Guid.Parse("5B7D2A9E-1C4F-3A8B-6F7D-2C9E45B1A7F3"), //9
                ProductId = SeedDataProduct.GetIndex(1).ProductId,
                Price = 156000,
                Quantity = 31,
                UrlImage = "https://i.ibb.co/4nf94Hdm/vn-11134207-7ras8-m3abtk1o14h89a-resize-w450-nl.webp",
                Option1 = "Size",
                OptionValue1 = "S",
                Option2 = "Color",
                OptionValue2 = "Đen",
                Option3 = "Material",
                OptionValue3 = "Bomber"
            },
            new ProductVariant
            {
                VariantId = Guid.NewGuid(), //10
                ProductId = SeedDataProduct.GetIndex(1).ProductId,
                Price = 156000,
                Quantity = 31,
                UrlImage = "https://i.ibb.co/4nf94Hdm/vn-11134207-7ras8-m3abtk1o14h89a-resize-w450-nl.webp",
                Option1 = "Size",
                OptionValue1 = "M",
                Option2 = "Color",
                OptionValue2 = "Đen",
                Option3 = "Material",
                OptionValue3 = "Bomber"
            },
            new ProductVariant
            {
                VariantId = Guid.NewGuid(), //11
                ProductId = SeedDataProduct.GetIndex(1).ProductId,
                Price = 156000,
                Quantity = 31,
                UrlImage = "https://i.ibb.co/4nf94Hdm/vn-11134207-7ras8-m3abtk1o14h89a-resize-w450-nl.webp",
                Option1 = "Size",
                OptionValue1 = "L",
                Option2 = "Color",
                OptionValue2 = "Đen",
                Option3 = "Material",
                OptionValue3 = "Bomber"
            },
            new ProductVariant
            {
                VariantId = Guid.NewGuid(), //12
                ProductId = SeedDataProduct.GetIndex(1).ProductId,
                Price = 16400,
                Quantity = 50,
                UrlImage = "https://i.ibb.co/4wKs9Gwq/vn-11134207-7ras8-m3abtm6iy224ea-resize-w450-nl.webp",
                Option1 = "Size",
                OptionValue1 = "S",
                Option2 = "Color",
                OptionValue2 = "Muối Tiêu",
                Option3 = "Material",
                OptionValue3 = "Bomber"
            },
            new ProductVariant
            {
                VariantId = Guid.NewGuid(), //13
                ProductId = SeedDataProduct.GetIndex(1).ProductId,
                Price = 16400,
                Quantity = 50,
                UrlImage = "https://i.ibb.co/4wKs9Gwq/vn-11134207-7ras8-m3abtm6iy224ea-resize-w450-nl.webp",
                Option1 = "Size",
                OptionValue1 = "M",
                Option2 = "Color",
                OptionValue2 = "Muối Tiêu",
                Option3 = "Material",
                OptionValue3 = "Bomber"
            },
            new ProductVariant
            {
                VariantId = Guid.NewGuid(), //14
                ProductId = SeedDataProduct.GetIndex(1).ProductId,
                Price = 16400,
                Quantity = 50,
                UrlImage = "https://i.ibb.co/4wKs9Gwq/vn-11134207-7ras8-m3abtm6iy224ea-resize-w450-nl.webp",
                Option1 = "Size",
                OptionValue1 = "L",
                Option2 = "Color",
                OptionValue2 = "Muối Tiêu",
                Option3 = "Material",
                OptionValue3 = "Bomber"
            },
            new ProductVariant
            {
                VariantId = Guid.NewGuid(), //15
                ProductId = SeedDataProduct.GetIndex(1).ProductId,
                Price = 16700,
                Quantity = 20,
                UrlImage = "https://i.ibb.co/dsxjSnRX/vn-11134207-7ras8-m3abtnsil71oa7-resize-w450-nl.webp",
                Option1 = "Size",
                OptionValue1 = "S",
                Option2 = "Color",
                OptionValue2 = "Be",
                Option3 = "Material",
                OptionValue3 = "Bomber"
            },
            new ProductVariant
            {
                VariantId = Guid.NewGuid(), //16
                ProductId = SeedDataProduct.GetIndex(1).ProductId,
                Price = 16700,
                Quantity = 20,
                UrlImage = "https://i.ibb.co/dsxjSnRX/vn-11134207-7ras8-m3abtnsil71oa7-resize-w450-nl.webp",
                Option1 = "Size",
                OptionValue1 = "M",
                Option2 = "Color",
                OptionValue2 = "Be",
                Option3 = "Material",
                OptionValue3 = "Bomber"
            },
            new ProductVariant
            {
                VariantId = Guid.NewGuid(), //17
                ProductId = SeedDataProduct.GetIndex(1).ProductId,
                Price = 16700,
                Quantity = 20,
                UrlImage = "https://i.ibb.co/dsxjSnRX/vn-11134207-7ras8-m3abtnsil71oa7-resize-w450-nl.webp",
                Option1 = "Size",
                OptionValue1 = "L",
                Option2 = "Color",
                OptionValue2 = "Be",
                Option3 = "Material",
                OptionValue3 = "Bomber"
            },
              new ProductVariant
            {
                VariantId = Guid.NewGuid(), //18
                ProductId = SeedDataProduct.GetIndex(2).ProductId,
                Price = 299000,
                Quantity = 50,
                UrlImage = "https://i.ibb.co/x8mf8SGR/vn-11134201-7ras8-m4fwphe1o1wg7f-resize-w450-nl.webp",
                Option1 = "Size",
                OptionValue1 = "S",
                Option2 = "Color",
                OptionValue2 = "Xanh navi",
                Option3 = "Material",
                OptionValue3 = "Cotton"
            },
              new ProductVariant
            {
                VariantId = Guid.Parse("A1B2C3D4-E5F6-7890-1234-56789ABCDEF0"), //19
                ProductId = SeedDataProduct.GetIndex(2).ProductId,
                Price = 299000,
                Quantity = 50,
                UrlImage = "https://i.ibb.co/x8mf8SGR/vn-11134201-7ras8-m4fwphe1o1wg7f-resize-w450-nl.webp",
                Option1 = "Size",
                OptionValue1 = "M",
                Option2 = "Color",
                OptionValue2 = "Xanh navi",
                Option3 = "Material",
                OptionValue3 = "Cotton"
            },
              new ProductVariant
            {
                VariantId = Guid.NewGuid(), //20
                ProductId = SeedDataProduct.GetIndex(2).ProductId,
                Price = 299000,
                Quantity = 50,
                UrlImage = "https://i.ibb.co/x8mf8SGR/vn-11134201-7ras8-m4fwphe1o1wg7f-resize-w450-nl.webp",
                Option1 = "Size",
                OptionValue1 = "L",
                Option2 = "Color",
                OptionValue2 = "Xanh navi",
                Option3 = "Material",
                OptionValue3 = "Cotton"
            },
              new ProductVariant
            {
                VariantId = Guid.NewGuid(), //21
                ProductId = SeedDataProduct.GetIndex(2).ProductId,
                Price = 299000,
                Quantity = 50,
                UrlImage = "https://i.ibb.co/dJ1yyB1N/vn-11134201-7ras8-m4fwphkzduyv41-resize-w450-nl.webp",
                Option1 = "Size",
                OptionValue1 = "S",
                Option2 = "Color",
                OptionValue2 = "Trắng",
                Option3 = "Material",
                OptionValue3 = "Cotton"
            },
              new ProductVariant
            {
                VariantId = Guid.NewGuid(), //22
                ProductId = SeedDataProduct.GetIndex(2).ProductId,
                Price = 270000,
                Quantity = 50,
                UrlImage = "https://i.ibb.co/dJ1yyB1N/vn-11134201-7ras8-m4fwphkzduyv41-resize-w450-nl.webp",
                Option1 = "Size",
                OptionValue1 = "M",
                Option2 = "Color",
                OptionValue2 = "Trắng",
                Option3 = "Material",
                OptionValue3 = "Cotton"
            },
              new ProductVariant
            {
                VariantId = Guid.NewGuid(), //23
                ProductId = SeedDataProduct.GetIndex(2).ProductId,
                Price = 280000,
                Quantity = 50,
                UrlImage = "https://i.ibb.co/dJ1yyB1N/vn-11134201-7ras8-m4fwphkzduyv41-resize-w450-nl.webp",
                Option1 = "Size",
                OptionValue1 = "L",
                Option2 = "Color",
                OptionValue2 = "Trắng",
                Option3 = "Material",
                OptionValue3 = "Cotton"
            },
              new ProductVariant
            {
                VariantId = Guid.NewGuid(), //24
                ProductId = SeedDataProduct.GetIndex(2).ProductId,
                Price = 295000,
                Quantity = 50,
                UrlImage = "https://i.ibb.co/xtxHz2vk/vn-11134207-7ras8-m4k37b7vkj34db-resize-w450-nl.webp",
                Option1 = "Size",
                OptionValue1 = "S",
                Option2 = "Color",
                OptionValue2 = "Xanh lá",
                Option3 = "Material",
                OptionValue3 = "Cotton"
            },
              new ProductVariant
            {
                VariantId = Guid.NewGuid(), //25
                ProductId = SeedDataProduct.GetIndex(2).ProductId,
                Price = 290000,
                Quantity = 50,
                UrlImage = "https://i.ibb.co/xtxHz2vk/vn-11134207-7ras8-m4k37b7vkj34db-resize-w450-nl.webp",
                Option1 = "Size",
                OptionValue1 = "M",
                Option2 = "Color",
                OptionValue2 = "Xanh lá",
                Option3 = "Material",
                OptionValue3 = "Cotton"
            },
              new ProductVariant
            {
                VariantId = Guid.NewGuid(), //26
                ProductId = SeedDataProduct.GetIndex(2).ProductId,
                Price = 260000,
                Quantity = 50,
                UrlImage = "https://i.ibb.co/xtxHz2vk/vn-11134207-7ras8-m4k37b7vkj34db-resize-w450-nl.webp",
                Option1 = "Size",
                OptionValue1 = "L",
                Option2 = "Color",
                OptionValue2 = "Xanh lá",
                Option3 = "Material",
                OptionValue3 = "Cotton"
            },
              
            new ProductVariant
            {
                VariantId = Guid.NewGuid(), //27
                ProductId = SeedDataProduct.GetIndex(3).ProductId,
                Price = 1179000,
                Quantity = 33,
                UrlImage = "https://i.ibb.co/SXzwZXvF/bitis.webp",
                Option1 = "Size",
                OptionValue1 = "36",
                Option2 = "Color",
                OptionValue2 = "Trắng",
                Option3 = "Material",
                OptionValue3 = "Quai vải dệt"
            },
            new ProductVariant
            {
                VariantId = Guid.NewGuid(), //28
                ProductId = SeedDataProduct.GetIndex(3).ProductId,
                Price = 1179000,
                Quantity = 33,
                UrlImage = "https://i.ibb.co/SXzwZXvF/bitis.webp",
                Option1 = "Size",
                OptionValue1 = "37",
                Option2 = "Color",
                OptionValue2 = "Trắng",
                Option3 = "Material",
                OptionValue3 = "Quai vải dệt"
            },
            new ProductVariant
            {
                VariantId = Guid.NewGuid(), //29
                ProductId = SeedDataProduct.GetIndex(3).ProductId,
                Price = 1179000,
                Quantity = 33,
                UrlImage = "https://i.ibb.co/SXzwZXvF/bitis.webp",
                Option1 = "Size",
                OptionValue1 = "38",
                Option2 = "Color",
                OptionValue2 = "Trắng",
                Option3 = "Material",
                OptionValue3 = "Quai vải dệt"
            },
            new ProductVariant
            {
                VariantId = Guid.NewGuid(), //30
                ProductId = SeedDataProduct.GetIndex(4).ProductId,
                Price = 804000,
                Quantity = 33,
                UrlImage = "https://i.ibb.co/FLmDcq6K/sg-11134201-7rbma-lq8rgpyall461d.webp",
                Option1 = "Size",
                OptionValue1 = "39",
                Option2 = "Color",
                OptionValue2 = "Xám",
                Option3 = "Material",
                OptionValue3 = "Quai vải dệt"
            },
            new ProductVariant
            {
                VariantId = Guid.Parse("6A1FD4B2-99E8-4C3B-A6E2-8575D9E6A7D4"), //31
                ProductId = SeedDataProduct.GetIndex(4).ProductId,
                Price = 804000,
                Quantity = 33,
                UrlImage = "GetIndex(0)",
                Option1 = "Size",
                OptionValue1 = "40",
                Option2 = "Color",
                OptionValue2 = "Xám",
                Option3 = "Material",
                OptionValue3 = "Quai vải dệt"
            },
            new ProductVariant
            {
                VariantId = Guid.NewGuid(), //32
                ProductId = SeedDataProduct.GetIndex(4).ProductId,
                Price = 804000,
                Quantity = 330,
                UrlImage = "https://i.ibb.co/FLmDcq6K/sg-11134201-7rbma-lq8rgpyall461d.webp",
                Option1 = "Size",
                OptionValue1 = "41",
                Option2 = "Color",
                OptionValue2 = "Xám",
                Option3 = "Material",
                OptionValue3 = "Quai vải dệt"
            },
           
            new ProductVariant
            {
                VariantId = Guid.NewGuid(), //33
                ProductId = SeedDataProduct.GetIndex(5).ProductId,
                Price = 229000,
                Quantity = 31,
                UrlImage = "https://i.ibb.co/hFvfhTqn/vn-11134207-7ras8-m3hjkt9girs198.webp",
                Option1 = "Size",
                OptionValue1 = "32cm", 
                Option2 = "Color",
                OptionValue2 = "Đen", 
                Option3 = "Material",
                OptionValue3 = "Da"
            },
            new ProductVariant
            {
                VariantId = Guid.NewGuid(), //34
                ProductId = SeedDataProduct.GetIndex(5).ProductId,
                Price = 229000,
                Quantity = 23,
                UrlImage = "https://i.ibb.co/hFvfhTqn/vn-11134207-7ras8-m3hjkt9girs198.webp",
                Option1 = "Size",
                OptionValue1 = "38cm",
                Option2 = "Color",
                OptionValue2 = "Đen",
                Option3 = "Material",
                OptionValue3 = "Da"
            },
            new ProductVariant
            {
                VariantId = Guid.NewGuid(), //35
                ProductId = SeedDataProduct.GetIndex(5).ProductId,
                Price = 229000,
                Quantity = 78,
                UrlImage = "https://i.ibb.co/hFvfhTqn/vn-11134207-7ras8-m3hjkt9girs198.webp",
                Option1 = "Size",
                OptionValue1 = "40cm",
                Option2 = "Color",
                OptionValue2 = "Đen",
                Option3 = "Material",
                OptionValue3 = "Da"
            },
            
            new ProductVariant
            {
                VariantId = Guid.NewGuid(), //36
                ProductId = SeedDataProduct.GetIndex(6).ProductId,
                Price = 108,
                Quantity = 80,
                UrlImage = "https://i.ibb.co/zTTXpmrn/ct058-ylw-a0-1.jpg",
                Option1 = "Size",
                OptionValue1 = "S",
                Option2 = "Color",
                OptionValue2 = "Yellow",
                Option3 = "Material",
                OptionValue3 = "Cotton"
            },
            new ProductVariant
            {
                VariantId = Guid.NewGuid(), //37
                ProductId = SeedDataProduct.GetIndex(6).ProductId,
                Price = 10800,
                Quantity = 98,
                UrlImage = "https://i.ibb.co/zTTXpmrn/ct058-ylw-a0-1.jpg",
                Option1 = "Size",
                OptionValue1 = "M",
                Option2 = "Color",
                OptionValue2 = "Yellow",
                Option3 = "Material",
                OptionValue3 = "Cotton"
            },
            new ProductVariant
            {
                VariantId = Guid.NewGuid(), //38
                ProductId = SeedDataProduct.GetIndex(6).ProductId,
                Price = 10880,
                Quantity = 60,
                UrlImage = "https://i.ibb.co/zTTXpmrn/ct058-ylw-a0-1.jpg",
                Option1 = "Size",
                OptionValue1 = "L",
                Option2 = "Color",
                OptionValue2 = "Yellow",
                Option3 = "Material",
                OptionValue3 = "Cotton"
            },
            new ProductVariant
            {
                VariantId = Guid.NewGuid(), //39
                ProductId = SeedDataProduct.GetIndex(6).ProductId,
                Price = 10890,
                Quantity = 30,
                UrlImage = "https://i.ibb.co/zTTXpmrn/ct058-ylw-a0-1.jpg",
                Option1 = "Size",
                OptionValue1 = "XL",
                Option2 = "Color",
                OptionValue2 = "Yellow",
                Option3 = "Material",
                OptionValue3 = "Cotton"
            },

            new ProductVariant
            {
                VariantId = Guid.NewGuid(), //40
                ProductId = SeedDataProduct.GetIndex(7).ProductId,
                Price = 22000,
                Quantity = 307,
                UrlImage = "https://i.ibb.co/nsSqFnTR/M-NK-DF-UV-PRIMARY-FZ-HOODIE.jpg",
                Option1 = "Size",
                OptionValue1 = "S",
                Option2 = "Color",
                OptionValue2 = "Green",
                Option3 = "Material",
                OptionValue3 = "Polyamide"
            },
            new ProductVariant
            {
                VariantId = Guid.NewGuid(), //41
                ProductId = SeedDataProduct.GetIndex(7).ProductId,
                Price = 22090,
                Quantity = 3233,
                UrlImage = "https://i.ibb.co/nsSqFnTR/M-NK-DF-UV-PRIMARY-FZ-HOODIE.jpg",
                Option1 = "Size",
                OptionValue1 = "M",
                Option2 = "Color",
                OptionValue2 = "Green",
                Option3 = "Material",
                OptionValue3 = "Polyamide"
            },
            new ProductVariant
            {
                VariantId = Guid.NewGuid(), //42
                ProductId = SeedDataProduct.GetIndex(7).ProductId,
                Price = 22080,
                Quantity = 35,
                UrlImage = "https://i.ibb.co/nsSqFnTR/M-NK-DF-UV-PRIMARY-FZ-HOODIE.jpg",
                Option1 = "Size",
                OptionValue1 = "L",
                Option2 = "Color",
                OptionValue2 = "Green",
                Option3 = "Material",
                OptionValue3 = "Polyamide"
            },
            new ProductVariant
            {
                VariantId = Guid.NewGuid(), //43
                ProductId = SeedDataProduct.GetIndex(7).ProductId,
                Price = 22070,
                Quantity = 70,
                UrlImage = "https://i.ibb.co/nsSqFnTR/M-NK-DF-UV-PRIMARY-FZ-HOODIE.jpg",
                Option1 = "Size",
                OptionValue1 = "XL",
                Option2 = "Color",
                OptionValue2 = "Green",
                Option3 = "Material",
                OptionValue3 = "Polyamide"
            },
            new ProductVariant
            {
                VariantId = Guid.NewGuid(), //44
                ProductId = SeedDataProduct.GetIndex(7).ProductId,
                Price = 22060,
                Quantity = 50,
                UrlImage = "https://i.ibb.co/d0bLctdZ/M-NK-DF-UV-PRIMARY-FZ-HOODIE.jpg",
                Option1 = "Size",
                OptionValue1 = "S",
                Option2 = "Color",
                OptionValue2 = "Pink",
                Option3 = "Material",
                OptionValue3 = "Polyamide"
            },
            new ProductVariant
            {
                VariantId = Guid.NewGuid(), //45
                ProductId = SeedDataProduct.GetIndex(7).ProductId,
                Price = 22070,
                Quantity = 40,
                UrlImage = "https://i.ibb.co/d0bLctdZ/M-NK-DF-UV-PRIMARY-FZ-HOODIE.jpg",
                Option1 = "Size",
                OptionValue1 = "M",
                Option2 = "Color",
                OptionValue2 = "Pink",
                Option3 = "Material",
                OptionValue3 = "Polyamide"
            },
            new ProductVariant
            {
                VariantId = Guid.NewGuid(), //46
                ProductId = SeedDataProduct.GetIndex(7).ProductId,
                Price = 22060,
                Quantity = 80,
                UrlImage = "https://i.ibb.co/d0bLctdZ/M-NK-DF-UV-PRIMARY-FZ-HOODIE.jpg",
                Option1 = "Size",
                OptionValue1 = "L",
                Option2 = "Color",
                OptionValue2 = "Pink",
                Option3 = "Material",
                OptionValue3 = "Polyamide"
            },
            new ProductVariant
            {
                VariantId = Guid.NewGuid(), //47
                ProductId = SeedDataProduct.GetIndex(7).ProductId,
                Price = 22050,
                Quantity = 67,
                UrlImage = "https://i.ibb.co/d0bLctdZ/M-NK-DF-UV-PRIMARY-FZ-HOODIE.jpg",
                Option1 = "Size",
                OptionValue1 = "XL",
                Option2 = "Color",
                OptionValue2 = "Pink",
                Option3 = "Material",
                OptionValue3 = "Polyamide"
            },
            new ProductVariant
            {
                VariantId = Guid.NewGuid(), //48
                ProductId = SeedDataProduct.GetIndex(7).ProductId,
                Price = 22000,
                Quantity = 76,
                UrlImage = "https://i.ibb.co/s91SnQr3/M-NK-DF-UV-PRIMARY-FZ-HOODIE.jpg",
                Option1 = "Size",
                OptionValue1 = "S",
                Option2 = "Color",
                OptionValue2 = "White",
                Option3 = "Material",
                OptionValue3 = "Polyamide"
            },
            new ProductVariant
            {
                VariantId = Guid.NewGuid(), //49
                ProductId = SeedDataProduct.GetIndex(7).ProductId,
                Price = 22090,
                Quantity = 90,
                UrlImage = "https://i.ibb.co/s91SnQr3/M-NK-DF-UV-PRIMARY-FZ-HOODIE.jpg",
                Option1 = "Size",
                OptionValue1 = "M",
                Option2 = "Color",
                OptionValue2 = "White",
                Option3 = "Material",
                OptionValue3 = "Polyamide"
            },
            new ProductVariant
            {
                VariantId = Guid.NewGuid(), //50
                ProductId = SeedDataProduct.GetIndex(7).ProductId,
                Price = 22080,
                Quantity = 67,
                UrlImage = "https://i.ibb.co/s91SnQr3/M-NK-DF-UV-PRIMARY-FZ-HOODIE.jpg",
                Option1 = "Size",
                OptionValue1 = "L",
                Option2 = "Color",
                OptionValue2 = "White",
                Option3 = "Material",
                OptionValue3 = "Polyamide"
            },
            new ProductVariant
            {
                VariantId = Guid.NewGuid(), //51
                ProductId = SeedDataProduct.GetIndex(7).ProductId,
                Price = 22070,
                Quantity = 56,
                UrlImage = "https://i.ibb.co/s91SnQr3/M-NK-DF-UV-PRIMARY-FZ-HOODIE.jpg",
                Option1 = "Size",
                OptionValue1 = "XL",
                Option2 = "Color",
                OptionValue2 = "White",
                Option3 = "Material",
                OptionValue3 = "Polyamide"
            },

            new ProductVariant
            {
                VariantId = Guid.NewGuid(), //52
                ProductId = SeedDataProduct.GetIndex(8).ProductId,
                Price = 55060,
                Quantity = 89,
                UrlImage = "https://i.ibb.co/CsWwRJxD/M-NK-DF-TEE-DFC-CREW-SOLID.jpg",
                Option1 = "Size",
                OptionValue1 = "S",
                Option2 = "Color",
                OptionValue2 = "Black",
                Option3 = "Material",
                OptionValue3 = "Cotton"
            },
            new ProductVariant
            {
                VariantId = Guid.NewGuid(), //53
                ProductId = SeedDataProduct.GetIndex(8).ProductId,
                Price = 55000,
                Quantity = 87,
                UrlImage = "https://i.ibb.co/CsWwRJxD/M-NK-DF-TEE-DFC-CREW-SOLID.jpg",
                Option1 = "Size",
                OptionValue1 = "M",
                Option2 = "Color",
                OptionValue2 = "Black",
                Option3 = "Material",
                OptionValue3 = "Cotton"
            },
            new ProductVariant
            {
                VariantId = Guid.NewGuid(), //54
                ProductId = SeedDataProduct.GetIndex(8).ProductId,
                Price = 55080,
                Quantity = 78,
                UrlImage = "https://i.ibb.co/CsWwRJxD/M-NK-DF-TEE-DFC-CREW-SOLID.jpg",
                Option1 = "Size",
                OptionValue1 = "L",
                Option2 = "Color",
                OptionValue2 = "Black",
                Option3 = "Material",
                OptionValue3 = "Cotton"
            },
            new ProductVariant
            {
                VariantId = Guid.NewGuid(), //55
                ProductId = SeedDataProduct.GetIndex(8).ProductId,
                Price = 55090,
                Quantity = 45,
                UrlImage = "https://i.ibb.co/CsWwRJxD/M-NK-DF-TEE-DFC-CREW-SOLID.jpg",
                Option1 = "Size",
                OptionValue1 = "XL",
                Option2 = "Color",
                OptionValue2 = "Black",
                Option3 = "Material",
                OptionValue3 = "Cotton"
            },
            new ProductVariant
            {
                VariantId = Guid.NewGuid(), //56
                ProductId = SeedDataProduct.GetIndex(8).ProductId,
                Price = 55000,
                Quantity = 54,
                UrlImage = "https://i.ibb.co/ynQSFx0k/M-NK-DF-TEE-DFC-CREW-SOLID.jpg",
                Option1 = "Size",
                OptionValue1 = "S",
                Option2 = "Color",
                OptionValue2 = "Blue",
                Option3 = "Material",
                OptionValue3 = "Cotton"
            },
            new ProductVariant
            {
                VariantId = Guid.NewGuid(), //57
                ProductId = SeedDataProduct.GetIndex(8).ProductId,
                Price = 55090,
                Quantity = 6,
                UrlImage = "https://i.ibb.co/ynQSFx0k/M-NK-DF-TEE-DFC-CREW-SOLID.jpg",
                Option1 = "Size",
                OptionValue1 = "M",
                Option2 = "Color",
                OptionValue2 = "Blue",
                Option3 = "Material",
                OptionValue3 = "Cotton"
            },
            new ProductVariant
            {
                VariantId = Guid.NewGuid(), //58
                ProductId = SeedDataProduct.GetIndex(8).ProductId,
                Price = 55080,
                Quantity = 7,
                UrlImage = "https://i.ibb.co/ynQSFx0k/M-NK-DF-TEE-DFC-CREW-SOLID.jpg",
                Option1 = "Size",
                OptionValue1 = "L",
                Option2 = "Color",
                OptionValue2 = "Blue",
                Option3 = "Material",
                OptionValue3 = "Cotton"
            },
            new ProductVariant
            {
                VariantId = Guid.NewGuid(), //59
                ProductId = SeedDataProduct.GetIndex(8).ProductId,
                Price = 55070,
                Quantity = 56,
                UrlImage = "https://i.ibb.co/ynQSFx0k/M-NK-DF-TEE-DFC-CREW-SOLID.jpg",
                Option1 = "Size",
                OptionValue1 = "XL",
                Option2 = "Color",
                OptionValue2 = "Blue",
                Option3 = "Material",
                OptionValue3 = "Cotton"
            },
            new ProductVariant
            {
                VariantId = Guid.NewGuid(), //60
                ProductId = SeedDataProduct.GetIndex(8).ProductId,
                Price = 55070,
                Quantity = 56,
                UrlImage = "https://i.ibb.co/xxLYYQs/M-NK-DF-TEE-DFC-CREW-SOLID.jpg",
                Option1 = "Size",
                OptionValue1 = "S",
                Option2 = "Color",
                OptionValue2 = "Grey",
                Option3 = "Material",
                OptionValue3 = "Cotton"
            },
            new ProductVariant
            {
                VariantId = Guid.NewGuid(), //61
                ProductId = SeedDataProduct.GetIndex(8).ProductId,
                Price = 55880,
                Quantity = 435,
                UrlImage = "https://i.ibb.co/xxLYYQs/M-NK-DF-TEE-DFC-CREW-SOLID.jpg",
                Option1 = "Size",
                OptionValue1 = "M",
                Option2 = "Color",
                OptionValue2 = "Grey",
                Option3 = "Material",
                OptionValue3 = "Cotton"
            },
            new ProductVariant
            {
                VariantId = Guid.NewGuid(), //62
                ProductId = SeedDataProduct.GetIndex(8).ProductId,
                Price = 55088,
                Quantity = 78,
                UrlImage = "https://i.ibb.co/xxLYYQs/M-NK-DF-TEE-DFC-CREW-SOLID.jpg",
                Option1 = "Size",
                OptionValue1 = "L",
                Option2 = "Color",
                OptionValue2 = "Grey",
                Option3 = "Material",
                OptionValue3 = "Cotton"
            },
            new ProductVariant
            {
                VariantId = Guid.NewGuid(), //63
                ProductId = SeedDataProduct.GetIndex(8).ProductId,
                Price = 55770,
                Quantity = 67,
                UrlImage = "https://i.ibb.co/xxLYYQs/M-NK-DF-TEE-DFC-CREW-SOLID.jpg",
                Option1 = "Size",
                OptionValue1 = "XL",
                Option2 = "Color",
                OptionValue2 = "Grey",
                Option3 = "Material",
                OptionValue3 = "Cotton"
            },

            new ProductVariant
            {
                VariantId = Guid.NewGuid(), //64
                ProductId = SeedDataProduct.GetIndex(9).ProductId,
                Price = 28820,
                Quantity = 34,
                UrlImage = "https://i.ibb.co/tpJLdK0B/M-NK-TCH-WVN-WR-FZ-JKT.jpg",
                Option1 = "Size",
                OptionValue1 = "S",
                Option2 = "Color",
                OptionValue2 = "Black",
                Option3 = "Material",
                OptionValue3 = "Sheep Leather"
            },
            new ProductVariant
            {
                VariantId = Guid.NewGuid(), //65
                ProductId = SeedDataProduct.GetIndex(9).ProductId,
                Price = 22880,
                Quantity = 23,
                UrlImage = "https://i.ibb.co/tpJLdK0B/M-NK-TCH-WVN-WR-FZ-JKT.jpg",
                Option1 = "Size",
                OptionValue1 = "M",
                Option2 = "Color",
                OptionValue2 = "Black",
                Option3 = "Material",
                OptionValue3 = "Sheep Leather"
            },
            new ProductVariant
            {
                VariantId = Guid.NewGuid(), //66
                ProductId = SeedDataProduct.GetIndex(9).ProductId,
                Price = 22000,
                Quantity = 45,
                UrlImage = "https://i.ibb.co/tpJLdK0B/M-NK-TCH-WVN-WR-FZ-JKT.jpg",
                Option1 = "Size",
                OptionValue1 = "L",
                Option2 = "Color",
                OptionValue2 = "Black",
                Option3 = "Material",
                OptionValue3 = "Sheep Leather"
            },
            new ProductVariant
            {
                VariantId = Guid.NewGuid(), //67
                ProductId = SeedDataProduct.GetIndex(9).ProductId,
                Price = 22880,
                Quantity = 38,
                UrlImage = "https://i.ibb.co/tpJLdK0B/M-NK-TCH-WVN-WR-FZ-JKT.jpg",
                Option1 = "Size",
                OptionValue1 = "XL",
                Option2 = "Color",
                OptionValue2 = "Black",
                Option3 = "Material",
                OptionValue3 = "Sheep Leather"
            },
            new ProductVariant
            {
                VariantId = Guid.NewGuid(), //68
                ProductId = SeedDataProduct.GetIndex(9).ProductId,
                Price = 22990,
                Quantity = 75,
                UrlImage = "https://i.ibb.co/Kcw53ttd/M-NK-TCH-WVN-WR-FZ-JKT.jpg",
                Option1 = "Size",
                OptionValue1 = "S",
                Option2 = "Color",
                OptionValue2 = "Blue",
                Option3 = "Material",
                OptionValue3 = "Sheep Leather"
            },
            new ProductVariant
            {
                VariantId = Guid.NewGuid(), //69
                ProductId = SeedDataProduct.GetIndex(9).ProductId,
                Price = 22990,
                Quantity = 89,
                UrlImage = "https://i.ibb.co/Kcw53ttd/M-NK-TCH-WVN-WR-FZ-JKT.jpg",
                Option1 = "Size",
                OptionValue1 = "M",
                Option2 = "Color",
                OptionValue2 = "Blue",
                Option3 = "Material",
                OptionValue3 = "Sheep Leather"
            },
            new ProductVariant
            {
                VariantId = Guid.NewGuid(), //70
                ProductId = SeedDataProduct.GetIndex(9).ProductId,
                Price = 22880,
                Quantity = 345,
                UrlImage = "https://i.ibb.co/Kcw53ttd/M-NK-TCH-WVN-WR-FZ-JKT.jpg",
                Option1 = "Size",
                OptionValue1 = "L",
                Option2 = "Color",
                OptionValue2 = "Blue",
                Option3 = "Material",
                OptionValue3 = "Sheep Leather"
            },
            new ProductVariant
            {
                VariantId = Guid.NewGuid(), //71
                ProductId = SeedDataProduct.GetIndex(9).ProductId,
                Price = 22780,
                Quantity = 68,
                UrlImage = "https://i.ibb.co/Kcw53ttd/M-NK-TCH-WVN-WR-FZ-JKT.jpg",
                Option1 = "Size",
                OptionValue1 = "XL",
                Option2 = "Color",
                OptionValue2 = "Blue",
                Option3 = "Material",
                OptionValue3 = "Sheep Leather"
            },
            new ProductVariant
            {
                VariantId = Guid.NewGuid(), //72
                ProductId = SeedDataProduct.GetIndex(9).ProductId,
                Price = 22900,
                Quantity = 63,
                UrlImage = "https://i.ibb.co/wZH98w0m/M-NK-TCH-WVN-WR-FZ-JKT.jpg",
                Option1 = "Size",
                OptionValue1 = "S",
                Option2 = "Color",
                OptionValue2 = "Red",
                Option3 = "Material",
                OptionValue3 = "Sheep Leather"
            },
            new ProductVariant
            {
                VariantId = Guid.NewGuid(), //73
                ProductId = SeedDataProduct.GetIndex(9).ProductId,
                Price = 22780,
                Quantity = 81,
                UrlImage = "https://i.ibb.co/wZH98w0m/M-NK-TCH-WVN-WR-FZ-JKT.jpg",
                Option1 = "Size",
                OptionValue1 = "M",
                Option2 = "Color",
                OptionValue2 = "Red",
                Option3 = "Material",
                OptionValue3 = "Sheep Leather"
            },
            new ProductVariant
            {
                VariantId = Guid.NewGuid(), //74
                ProductId = SeedDataProduct.GetIndex(9).ProductId,
                Price = 22023,
                Quantity = 91,
                UrlImage = "https://i.ibb.co/wZH98w0m/M-NK-TCH-WVN-WR-FZ-JKT.jpg",
                Option1 = "Size",
                OptionValue1 = "L",
                Option2 = "Color",
                OptionValue2 = "Red",
                Option3 = "Material",
                OptionValue3 = "Sheep Leather"
            },
            new ProductVariant
            {
                VariantId = Guid.NewGuid(), //75
                ProductId = SeedDataProduct.GetIndex(9).ProductId,
                Price = 22330,
                Quantity = 83,
                UrlImage = "https://i.ibb.co/wZH98w0m/M-NK-TCH-WVN-WR-FZ-JKT.jpg",
                Option1 = "Size",
                OptionValue1 = "XL",
                Option2 = "Color",
                OptionValue2 = "Red",
                Option3 = "Material",
                OptionValue3 = "Sheep Leather"
            },

            new ProductVariant
            {
                VariantId = Guid.NewGuid(), //76
                ProductId = SeedDataProduct.GetIndex(10).ProductId,
                Price = 15855,
                Quantity = 63,
                UrlImage = "https://i.ibb.co/8n0LTWD3/cae11-b5h-a0-fmt-jpg-wid-711-hei-888-qlt-80-1-op-sharpen-0-res-Mode-bicub-op-usm-5-0.webp",
                Option1 = "Size",
                OptionValue1 = "L",
                Option2 = "Color",
                OptionValue2 = "Blue",
                Option3 = "Material",
                OptionValue3 = "Cotton"
            },

            new ProductVariant
            {
                VariantId = Guid.NewGuid(), //77
                ProductId = SeedDataProduct.GetIndex(11).ProductId,
                Price = 11558,
                Quantity = 798,
                UrlImage = "https://i.ibb.co/Cs9jDDP1/ct059-ylw-a0-fmt-jpg-wid-711-hei-888-qlt-80-1-op-sharpen-0-res-Mode-bicub-op-usm-5-0.webp",
                Option1 = "Size",
                OptionValue1 = "S",
                Option2 = "Color",
                OptionValue2 = "Yellow",
                Option3 = "Material",
                OptionValue3 = "Cotton"
            },

            new ProductVariant
            {
                VariantId = Guid.NewGuid(), //78
                ProductId = SeedDataProduct.GetIndex(12).ProductId,
                Price = 39555,
                Quantity = 24,
                UrlImage = "https://i.ibb.co/0VtD7KDx/cp979-r8e-a0-fmt-jpg-wid-711-hei-888-qlt-80-1-op-sharpen-0-res-Mode-bicub-op-usm-5-0.webp",
                Option1 = "Size",
                OptionValue1 = "L",
                Option2 = "Color",
                OptionValue2 = "Black",
                Option3 = "Material",
                OptionValue3 = "Cotton"
            },

            new ProductVariant
            {
                VariantId = Guid.NewGuid(), //79
                ProductId = SeedDataProduct.GetIndex(13).ProductId,
                Price = 11800,
                Quantity = 75,
                UrlImage = "https://i.ibb.co/399vf6kV/ct205-blk-a0-fmt-jpg-wid-711-hei-888-qlt-80-1-op-sharpen-0-res-Mode-bicub-op-usm-5-0.webp",
                Option1 = "Size",
                OptionValue1 = "M",
                Option2 = "Color",
                OptionValue2 = "Black",
                Option3 = "Material",
                OptionValue3 = "Cotton"
            },

            new ProductVariant
            {
                VariantId = Guid.NewGuid(), //80
                ProductId = SeedDataProduct.GetIndex(14).ProductId,
                Price = 29466,
                Quantity = 47,
                UrlImage = "https://i.ibb.co/BHSV88jH/cr356-p9j-a0-fmt-jpg-wid-711-hei-888-qlt-80-1-op-sharpen-0-res-Mode-bicub-op-usm-5-0.webp",
                Option1 = "Size",
                OptionValue1 = "M",
                Option2 = "Color",
                OptionValue2 = "Blue",
                Option3 = "Material",
                OptionValue3 = "Polymaide"
            },

            new ProductVariant
            {
                VariantId = Guid.NewGuid(), //81
                ProductId = SeedDataProduct.GetIndex(15).ProductId,
                Price = 15899,
                Quantity = 84,
                UrlImage = "https://i.ibb.co/xqBH436m/cb815-vee-a0-fmt-jpg-wid-711-hei-888-qlt-80-1-op-sharpen-0-res-Mode-bicub-op-usm-5-0.webp",
                Option1 = "Size",
                OptionValue1 = "S",
                Option2 = "Color",
                OptionValue2 = "Orange",
                Option3 = "Material",
                OptionValue3 = "Polyamide"
            },

            new ProductVariant
            {
                VariantId = Guid.NewGuid(), //82
                ProductId = SeedDataProduct.GetIndex(16).ProductId,
                Price = 11800,
                Quantity = 36,
                UrlImage = "https://i.ibb.co/5ggZDXTb/cr733-kha-a0-fmt-jpg-wid-711-hei-888-qlt-80-1-op-sharpen-0-res-Mode-bicub-op-usm-5-0.webp",
                Option1 = "Size",
                OptionValue1 = "M",
                Option2 = "Color",
                OptionValue2 = "White",
                Option3 = "Material",
                OptionValue3 = "Poly ester"
            },
            new ProductVariant
            {
                VariantId = Guid.NewGuid(), //83
                ProductId = SeedDataProduct.GetIndex(16).ProductId,
                Price = 11899,
                Quantity = 557,
                UrlImage = "https://i.ibb.co/5ggZDXTb/cr733-kha-a0-fmt-jpg-wid-711-hei-888-qlt-80-1-op-sharpen-0-res-Mode-bicub-op-usm-5-0.webp",
                Option1 = "Size",
                OptionValue1 = "M",
                Option2 = "Color",
                OptionValue2 = "White",
                Option3 = "Material",
                OptionValue3 = "Viscose"
            },
            new ProductVariant
            {
                VariantId = Guid.NewGuid(), //84
                ProductId = SeedDataProduct.GetIndex(16).ProductId,
                Price = 11800,
                Quantity = 1,
                UrlImage = "https://i.ibb.co/5ggZDXTb/cr733-kha-a0-fmt-jpg-wid-711-hei-888-qlt-80-1-op-sharpen-0-res-Mode-bicub-op-usm-5-0.webp",
                Option1 = "Size",
                OptionValue1 = "M",
                Option2 = "Color",
                OptionValue2 = "White",
                Option3 = "Material",
                OptionValue3 = "Elastane"
            },


            new ProductVariant
            {
                VariantId = Guid.NewGuid(), //85
                ProductId = SeedDataProduct.GetIndex(17).ProductId,
                Price = 39500,
                Quantity = 27,
                UrlImage = "https://i.ibb.co/Z6QNjy96/cs646-qr7-a0-fmt-jpg-wid-711-hei-888-qlt-80-1-op-sharpen-0-res-Mode-bicub-op-usm-5-0.webp",
                Option1 = "Size",
                OptionValue1 = "M",
                Option2 = "Color",
                OptionValue2 = "Pink",
                Option3 = "Material",
                OptionValue3 = "Cotton"
            },

            new ProductVariant
            {
                VariantId = new Guid("6ec0bbcb-3f03-4467-b9c9-5540a65e8763"), //86
                ProductId = SeedDataProduct.GetIndex(18).ProductId,
                Price = 395000,
                Quantity = 55,
                UrlImage = "https://i.ibb.co/1GKYP6YH/cn484-nvwt-a0-fmt-jpg-wid-711-hei-888-qlt-80-1-op-sharpen-0-res-Mode-bicub-op-usm-5-0.webp",
                Option1 = "Size",
                OptionValue1 = "S",
                Option2 = "Color",
                OptionValue2 = "Blue",
                Option3 = "Material",
                OptionValue3 = "Poly ester"
            },
            new ProductVariant
            {
                VariantId = Guid.NewGuid(), //87
                ProductId = SeedDataProduct.GetIndex(18).ProductId,
                Price = 39500,
                Quantity = 75,
                UrlImage = "https://i.ibb.co/1GKYP6YH/cn484-nvwt-a0-fmt-jpg-wid-711-hei-888-qlt-80-1-op-sharpen-0-res-Mode-bicub-op-usm-5-0.webp",
                Option1 = "Size",
                OptionValue1 = "S",
                Option2 = "Color",
                OptionValue2 = "Blue",
                Option3 = "Material",
                OptionValue3 = "Viscose"
            },
            new ProductVariant
            {
                VariantId = Guid.NewGuid(), //88
                ProductId = SeedDataProduct.GetIndex(18).ProductId,
                Price = 39500,
                Quantity = 74,
                UrlImage = "https://i.ibb.co/1GKYP6YH/cn484-nvwt-a0-fmt-jpg-wid-711-hei-888-qlt-80-1-op-sharpen-0-res-Mode-bicub-op-usm-5-0.webp",
                Option1 = "Size",
                OptionValue1 = "S",
                Option2 = "Color",
                OptionValue2 = "Blue",
                Option3 = "Material",
                OptionValue3 = "Elastane"
            },

            new ProductVariant
            {
                VariantId = new Guid("2ca08911-a12a-4674-99fd-bfc2ebe7ef6c"), //89
                ProductId = SeedDataProduct.GetIndex(19).ProductId,
                Price = 47588,
                Quantity = 376,
                UrlImage = "https://i.ibb.co/kgPx8b3c/ct588-tv4-a0-fmt-jpg-wid-711-hei-888-qlt-80-1-op-sharpen-0-res-Mode-bicub-op-usm-5-0.webp",
                Option1 = "Size",
                OptionValue1 = "L",
                Option2 = "Color",
                OptionValue2 = "Green",
                Option3 = "Material",
                OptionValue3 = "Cotton"
            },

            new ProductVariant
            {
                VariantId = new Guid("1af3662c-0abe-4297-ad27-96118d8339b1"), //90
                ProductId = SeedDataProduct.GetIndex(20).ProductId,
                Price = 47885,
                Quantity = 27,
                UrlImage = "https://i.ibb.co/Pzr9mNqb/cs020-blk-a0-fmt-jpg-wid-711-hei-888-qlt-80-1-op-sharpen-0-res-Mode-bicub-op-usm-5-0.webp",
                Option1 = "Size",
                OptionValue1 = "41",
                Option2 = "Color",
                OptionValue2 = "Black",
                Option3 = "Material",
                OptionValue3 = "Leather Upper"
            },

            new ProductVariant
            {
                VariantId = new Guid("ab62e24a-678a-4e1e-9439-6ea9826f0cb4"), //91
                ProductId = SeedDataProduct.GetIndex(21).ProductId,
                Price = 47588,
                Quantity = 27,
                UrlImage = "https://i.ibb.co/YBhZL7hZ/cu012-xgn-a0-fmt-jpg-wid-711-hei-888-qlt-80-1-op-sharpen-0-res-Mode-bicub-op-usm-5-0.webp",
                Option1 = "Size",
                OptionValue1 = "39",
                Option2 = "Color",
                OptionValue2 = "Black",
                Option3 = "Material",
                OptionValue3 = "Leather"
            },

            new ProductVariant
            {
                VariantId = Guid.NewGuid(), //92
                ProductId = SeedDataProduct.GetIndex(21).ProductId,
                Price = 47599,
                Quantity = 15,
                UrlImage = "https://i.ibb.co/YBhZL7hZ/cu012-xgn-a0-fmt-jpg-wid-711-hei-888-qlt-80-1-op-sharpen-0-res-Mode-bicub-op-usm-5-0.webp",
                Option1 = "Size",
                OptionValue1 = "39",
                Option2 = "Color",
                OptionValue2 = "Black",
                Option3 = "Material",
                OptionValue3 = "Mesh Upper"
            },

            new ProductVariant
            {
                VariantId = Guid.NewGuid(), //93
                ProductId = SeedDataProduct.GetIndex(22).ProductId,
                Price = 39500,
                Quantity = 64,
                UrlImage = "https://i.ibb.co/35n5GNkb/cu362-xc3-a0-fmt-jpg-wid-711-hei-888-qlt-80-1-op-sharpen-0-res-Mode-bicub-op-usm-5-0.webp",
                Option1 = "Size",
                OptionValue1 = "40",
                Option2 = "Color",
                OptionValue2 = "Blue",
                Option3 = "Material",
                OptionValue3 = "Nylon"
            },

            new ProductVariant
            {
                VariantId = Guid.NewGuid(), //94
                ProductId = SeedDataProduct.GetIndex(22).ProductId,
                Price = 39500,
                Quantity = 63,
                UrlImage = "https://i.ibb.co/35n5GNkb/cu362-xc3-a0-fmt-jpg-wid-711-hei-888-qlt-80-1-op-sharpen-0-res-Mode-bicub-op-usm-5-0.webp",
                Option1 = "Size",
                OptionValue1 = "40",
                Option2 = "Color",
                OptionValue2 = "Blue",
                Option3 = "Material",
                OptionValue3 = "Suede"
            },

            new ProductVariant
            {
                VariantId = Guid.NewGuid(), //95
                ProductId = SeedDataProduct.GetIndex(22).ProductId,
                Price = 39588,
                Quantity = 30,
                UrlImage = "https://i.ibb.co/35n5GNkb/cu362-xc3-a0-fmt-jpg-wid-711-hei-888-qlt-80-1-op-sharpen-0-res-Mode-bicub-op-usm-5-0.webp",
                Option1 = "Size",
                OptionValue1 = "40",
                Option2 = "Color",
                OptionValue2 = "Blue",
                Option3 = "Material",
                OptionValue3 = "Leathe Upper"
            },

            new ProductVariant
            {
                VariantId = Guid.NewGuid(), //96
                ProductId = SeedDataProduct.GetIndex(23).ProductId,
                Price = 35090,
                Quantity = 30,
                UrlImage = "https://i.ibb.co/4RXrPmfK/ct281-blk-a0-fmt-jpg-wid-711-hei-888-qlt-80-1-op-sharpen-0-res-Mode-bicub-op-usm-5-0.webp",
                Option1 = "Size",
                OptionValue1 = "41",
                Option2 = "Color",
                OptionValue2 = "Black",
                Option3 = "Material",
                OptionValue3 = "Jacquard"
            },

            new ProductVariant
            {
                VariantId = Guid.NewGuid(), //97
                ProductId = SeedDataProduct.GetIndex(23).ProductId,
                Price = 35099,
                Quantity = 30,
                UrlImage = "https://i.ibb.co/4RXrPmfK/ct281-blk-a0-fmt-jpg-wid-711-hei-888-qlt-80-1-op-sharpen-0-res-Mode-bicub-op-usm-5-0.webp",
                Option1 = "Size",
                OptionValue1 = "41",
                Option2 = "Color",
                OptionValue2 = "Black",
                Option3 = "Material",
                OptionValue3 = "Leathe Upper"
            },

            new ProductVariant
            {
                VariantId = new Guid("91242e70-719f-4deb-acc2-3e1a81b416d4"), //98
                ProductId = SeedDataProduct.GetIndex(24).ProductId,
                Price = 42500,
                Quantity = 30,
                UrlImage = "https://i.ibb.co/YBqfbH6B/cs004-ary-a0-fmt-jpg-wid-711-hei-888-qlt-80-1-op-sharpen-0-res-Mode-bicub-op-usm-5-0.webp",
                Option1 = "Size",
                OptionValue1 = "42",
                Option2 = "Color",
                OptionValue2 = "Green",
                Option3 = "Material",
                OptionValue3 = "Leathe Upper"
            },

            new ProductVariant
            {
                VariantId = Guid.NewGuid(), //99
                ProductId = SeedDataProduct.GetIndex(25).ProductId,
                Price = 35990,
                Quantity = 30,
                UrlImage = "https://i.ibb.co/Pz48Tkhs/cs029-rm3-a0-fmt-jpg-wid-711-hei-888-qlt-80-1-op-sharpen-0-res-Mode-bicub-op-usm-5-0.webp",
                Option1 = "Size",
                OptionValue1 = "40",
                Option2 = "Color",
                OptionValue2 = "Green",
                Option3 = "Material",
                OptionValue3 = "Suede Upper"
            },

            new ProductVariant
            {
                VariantId = Guid.NewGuid(), //100
                ProductId = SeedDataProduct.GetIndex(26).ProductId,
                Price = 39500,
                Quantity = 30,
                UrlImage = "https://i.ibb.co/ynYgyppW/cr998-w35-a0-fmt-jpg-wid-711-hei-888-qlt-80-1-op-sharpen-0-res-Mode-bicub-op-usm-5-0.webp",
                Option1 = "Size",
                OptionValue1 = "38",
                Option2 = "Color",
                OptionValue2 = "Yellow",
                Option3 = "Material",
                OptionValue3 = "Nylon"
            },
            new ProductVariant
            {
                VariantId = Guid.NewGuid(), //101
                ProductId = SeedDataProduct.GetIndex(26).ProductId,
                Price = 39775,
                Quantity = 30,
                UrlImage = "https://i.ibb.co/ynYgyppW/cr998-w35-a0-fmt-jpg-wid-711-hei-888-qlt-80-1-op-sharpen-0-res-Mode-bicub-op-usm-5-0.webp",
                Option1 = "Size",
                OptionValue1 = "38",
                Option2 = "Color",
                OptionValue2 = "Yellow",
                Option3 = "Material",
                OptionValue3 = "Suede"
            },
            new ProductVariant
            {
                VariantId = Guid.NewGuid(), //102
                ProductId = SeedDataProduct.GetIndex(26).ProductId,
                Price = 39588,
                Quantity = 30,
                UrlImage = "https://i.ibb.co/ynYgyppW/cr998-w35-a0-fmt-jpg-wid-711-hei-888-qlt-80-1-op-sharpen-0-res-Mode-bicub-op-usm-5-0.webp",
                Option1 = "Size",
                OptionValue1 = "39",
                Option2 = "Color",
                OptionValue2 = "Yellow",
                Option3 = "Material",
                OptionValue3 = "Leather Upper"
            },

            new ProductVariant
            {
                VariantId = Guid.NewGuid(), //103
                ProductId = SeedDataProduct.GetIndex(27).ProductId,
                Price = 39590,
                Quantity = 30,
                UrlImage = "https://i.ibb.co/My5m9pmp/cr991-chk-a0-fmt-jpg-wid-711-hei-888-qlt-80-1-op-sharpen-0-res-Mode-bicub-op-usm-5-0.webp",
                Option1 = "Size",
                OptionValue1 = "42",
                Option2 = "Color",
                OptionValue2 = "White",
                Option3 = "Material",
                OptionValue3 = "Rubber Upper"
            },

            new ProductVariant
            {
                VariantId = Guid.NewGuid(), //104
                ProductId = SeedDataProduct.GetIndex(27).ProductId,
                Price = 39590,
                Quantity = 30,
                UrlImage = "https://i.ibb.co/My5m9pmp/cr991-chk-a0-fmt-jpg-wid-711-hei-888-qlt-80-1-op-sharpen-0-res-Mode-bicub-op-usm-5-0.webp",
                Option1 = "Size",
                OptionValue1 = "42",
                Option2 = "Color",
                OptionValue2 = "White",
                Option3 = "Material",
                OptionValue3 = "Canvas"
            },

            new ProductVariant
            {
                VariantId = Guid.NewGuid(), //105
                ProductId = SeedDataProduct.GetIndex(27).ProductId,
                Price = 39509,
                Quantity = 30,
                UrlImage = "https://i.ibb.co/My5m9pmp/cr991-chk-a0-fmt-jpg-wid-711-hei-888-qlt-80-1-op-sharpen-0-res-Mode-bicub-op-usm-5-0.webp",
                Option1 = "Size",
                OptionValue1 = "42",
                Option2 = "Color",
                OptionValue2 = "White",
                Option3 = "Material",
                OptionValue3 = "Suede"
            },

            new ProductVariant
            {
                VariantId = Guid.NewGuid(), //106
                ProductId = SeedDataProduct.GetIndex(27).ProductId,
                Price = 39500,
                Quantity = 30,
                UrlImage = "https://i.ibb.co/My5m9pmp/cr991-chk-a0-fmt-jpg-wid-711-hei-888-qlt-80-1-op-sharpen-0-res-Mode-bicub-op-usm-5-0.webp",
                Option1 = "Size",
                OptionValue1 = "42",
                Option2 = "Color",
                OptionValue2 = "White",
                Option3 = "Material",
                OptionValue3 = "Leather"
            },

            new ProductVariant
            {
                VariantId = new Guid("bd4af864-ed2b-48a7-840e-c57bcab84064"), //107
                ProductId = SeedDataProduct.GetIndex(28).ProductId,
                Price = 29500,
                Quantity = 45,
                UrlImage = "https://i.ibb.co/CpWxxn9m/cn116-blh-a0-fmt-jpg-wid-711-hei-888-qlt-80-1-op-sharpen-0-res-Mode-bicub-op-usm-5-0.webp",
                Option1 = "Size",
                OptionValue1 = "38",
                Option2 = "Color",
                OptionValue2 = "Pink",
                Option3 = "Material",
                OptionValue3 = "Leather Upper"
            }, 

            new ProductVariant
            {
                VariantId = Guid.NewGuid(), //108
                ProductId = SeedDataProduct.GetIndex(29).ProductId,
                Price = 35000,
                Quantity = 30,
                UrlImage = "https://i.ibb.co/gbP3c3Zk/cz373-rby-a0-fmt-jpg-wid-711-hei-888-qlt-80-1-op-sharpen-0-res-Mode-bicub-op-usm-5-0.webp",
                Option1 = "Size",
                OptionValue1 = "39",
                Option2 = "Color",
                OptionValue2 = "Red",
                Option3 = "Material",
                OptionValue3 = "Leather Upper"
            },

            new ProductVariant
            {
                VariantId = new Guid("88abde00-3156-4f51-bb30-2c99e8b6dc6d"), //109
                ProductId = SeedDataProduct.GetIndex(29).ProductId,
                Price = 35079,
                Quantity = 30,
                UrlImage = "https://i.ibb.co/gbP3c3Zk/cz373-rby-a0-fmt-jpg-wid-711-hei-888-qlt-80-1-op-sharpen-0-res-Mode-bicub-op-usm-5-0.webp",
                Option1 = "Size",
                OptionValue1 = "39",
                Option2 = "Color",
                OptionValue2 = "Red",
                Option3 = "Material",
                OptionValue3 = "Jacquard"
            },

            new ProductVariant
            {
                VariantId = Guid.NewGuid(), //110
                ProductId = SeedDataProduct.GetIndex(30).ProductId,
                Price = 35800,
                Quantity = 30,
                UrlImage = "https://i.ibb.co/Kmj5z60/288436-xydcs1.jpg",
                Option1 = "Size",
                OptionValue1 = "6",
                Option2 = "Color",
                OptionValue2 = "Black",
                Option3 = "Material",
                OptionValue3 = "Cotton"
            },

            new ProductVariant
            {
                VariantId = new Guid("314863c3-cd35-49b6-ae3d-59c4031eef61"), //111
                ProductId = SeedDataProduct.GetIndex(30).ProductId,
                Price = 35900,
                Quantity = 200,
                UrlImage = "https://i.ibb.co/Kmj5z60/288436-xydcs1.jpg",
                Option1 = "Size",
                OptionValue1 = "6",
                Option2 = "Color",
                OptionValue2 = "Black",
                Option3 = "Material",
                OptionValue3 = "Mesh"
            },

            new ProductVariant
            {
                VariantId = new Guid("2c81513c-3e14-46cb-9abd-160b1420c084"), //112
                ProductId = SeedDataProduct.GetIndex(32).ProductId,
                Price = 35090,
                Quantity = 12,
                UrlImage = "https://i.ibb.co/VJLBrb9/1144694-pkzrtj.jpg",
                Option1 = "Size",
                OptionValue1 = "3",
                Option2 = "Color",
                OptionValue2 = "White",
                Option3 = "Material",
                OptionValue3 = "Nylon"
            },

            new ProductVariant
            {
                VariantId = Guid.NewGuid(), //113
                ProductId = SeedDataProduct.GetIndex(31).ProductId,
                Price = 35780,
                Quantity = 30,
                UrlImage = "https://i.ibb.co/GtSmn4J/1150338-rdngd8.jpg",
                Option1 = "Size",
                OptionValue1 = "5",
                Option2 = "Color",
                OptionValue2 = "Yellow",
                Option3 = "Material",
                OptionValue3 = "Cotton"
            },

            new ProductVariant
            {
                VariantId = new Guid("24cfaec6-a55f-4743-adaa-e9462b859ae7"), //114
                ProductId = SeedDataProduct.GetIndex(34).ProductId,
                Price = 35780,
                Quantity = 312,
                UrlImage = "https://i.ibb.co/98DDFDw/image.png",
                Option1 = "Size",
                OptionValue1 = "5",
                Option2 = "Color",
                OptionValue2 = "Black",
                Option3 = "Material",
                OptionValue3 = "Cotton"
            },

            new ProductVariant
            {
                VariantId = new Guid("1fb1cb3e-d1a1-4e77-9215-ca1577281b96"), //115
                ProductId = SeedDataProduct.GetIndex(35).ProductId,
                Price = 35780,
                Quantity = 30,
                UrlImage = "https://i.ibb.co/51HqJkg/s7-1404068-lifestyle-rl-1x1-pdp.webp",
                Option1 = "Size",
                OptionValue1 = "4",
                Option2 = "Color",
                OptionValue2 = "Grey",
                Option3 = "Material",
                OptionValue3 = "Cotton"
            },

            new ProductVariant
            {
                VariantId = Guid.NewGuid(), //116
                ProductId = SeedDataProduct.GetIndex(36).ProductId,
                Price = 35078,
                Quantity = 30,
                UrlImage = "https://i.ibb.co/r7xcYsj/s7-1443323-lifestyle-rl-1x1-pdp.webp",
                Option1 = "Size",
                OptionValue1 = "4",
                Option2 = "Color",
                OptionValue2 = "Brown",
                Option3 = "Material",
                OptionValue3 = "Cotton"
            },

            new ProductVariant
            {
                VariantId = Guid.NewGuid(), //117
                ProductId = SeedDataProduct.GetIndex(37).ProductId,
                Price = 35078,
                Quantity = 30,
                UrlImage = "https://i.ibb.co/JcFWLvs/s7-1478247-lifestyle-rl-1x1-pdp.webp",
                Option1 = "Size",
                OptionValue1 = "6",
                Option2 = "Color",
                OptionValue2 = "Blue",
                Option3 = "Material",
                OptionValue3 = "Cotton"
            },

            new ProductVariant
            {
                VariantId = Guid.NewGuid(), //118
                ProductId = SeedDataProduct.GetIndex(38).ProductId,
                Price = 35780,
                Quantity = 30,
                UrlImage = "https://i.ibb.co/DCgBvJT/casquette-bmw-m-motorsport-statement.jpg",
                Option1 = "Size",
                OptionValue1 = "5",
                Option2 = "Color",
                OptionValue2 = "Black",
                Option3 = "Material",
                OptionValue3 = "Cotton"
            },

            new ProductVariant
            {
                VariantId = Guid.NewGuid(), //119
                ProductId = SeedDataProduct.GetIndex(39).ProductId,
                Price = 35900,
                Quantity = 30,
                UrlImage = "https://i.ibb.co/VShCrTP/612-N3-Wb-CD2-L-AC-SX569.jpg",
                Option1 = "Size",
                OptionValue1 = "4",
                Option2 = "Color",
                OptionValue2 = "Black",
                Option3 = "Material",
                OptionValue3 = "Acrylic"
            },

            new ProductVariant
            {
                VariantId = Guid.NewGuid(), //119
                ProductId = new Guid("fce3f1a4-fdfc-4b93-8552-4ed748bb6a8b"),
                Price = 35900,
                Quantity = 30,
                UrlImage = "https://i.ibb.co/Pn8p37k/vn-11134207-7ras8-m0iodayfxlgt1c.webp",
                Option1 = "Size",
                OptionValue1 = "S",
                Option2 = "Color",
                OptionValue2 = "Black",
                Option3 = "Material",
                OptionValue3 = "Cotton"
            }

        };

        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductVariant>().HasData(ProductVariants);
        }
        public static ProductVariant GetIndex(int index)
        {
            if (index < 0 || index >= ProductVariants.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Index must be within the range of product variants.");
            }

            return ProductVariants[index];
        }
    }
}
