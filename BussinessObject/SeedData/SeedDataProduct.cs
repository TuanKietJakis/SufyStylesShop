using BussinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject.SeedData
{
    public static class SeedDataProduct
    {
        public static readonly Product[] Products = new Product[]
        {
            // lỗi
            new Product
            {
                ProductId = new Guid("5A7FB27F-BE52-468B-97DE-270F1EFA4854"), //0
                ProductName = "Calem Club - Quần Jeans Wash cạp cao Ống Rộng tôn dáng form thụng unisex",
                Description = "Quần Jean Ống Suông Calem Club wash màu tôn dáng form unisex nam nữ",
                ProductTypeName = "Pants",
                ProductVendorId = SeedDataProductVendor.GetIndex(0).ProductVendorId,
                ProductUrl = "product-link",
                IsVisible = true,
                CreateDate = DateTime.Now,
                SalePricePercent = 10,
                UserId = SeedDataUser.GetIndex(8).UserId,
                UrlImage = "https://i.ibb.co/TB4fx2CL/vn-11134207-7r98o-lyjow1zbvqz1d2-resize-w450-nl.webp",
            },
             new Product
            {
                ProductId = new Guid("71931791-424F-4D04-AD87-5AA8AB6D13E8"), //1
                ProductName = "Áo khoác BOMBER nỉ 2 da JULIDO áo khoác nỉ logo M thêu nổi dày dặn (FORM BOXY)",
                Description = "Áo khoác bomber dạ ép trần bông 3 lớp là món đồ thời trang đẳng cấp, mang đến sự kết hợp hoàn hảo giữa phong cách cổ điển và hiện đại.",
                ProductTypeName = "Jacket",
                ProductVendorId = SeedDataProductVendor.GetIndex(1).ProductVendorId,
                ProductUrl = "product-link",
                IsVisible = true,
                CreateDate = DateTime.Now,
                SalePricePercent = 10,
                UrlImage = "https://i.ibb.co/dsxjSnRX/vn-11134207-7ras8-m3abtnsil71oa7-resize-w450-nl.webp",
                UserId = SeedDataUser.GetIndex(8).UserId
            },
             // lỗi
            new Product
            {
                ProductId = Guid.Parse("F0E1D2C3-B4A5-6789-0123-456789ABCDE0"), //2
                ProductName = "Áo POLO nam Scafe- Khử mùi hiệu quả, co giãn, thấm hút mồ phối cổ năng động thương hiệu YODY APM3635",
                Description = "Áo polo nam Scafe- Khử mùi hiệu quả vải cá sấu cotton interlock xuất xịn, thanh lịch, sang trọng - Yody",
                  ProductTypeName = "Shirt",
                ProductVendorId = SeedDataProductVendor.GetIndex(2).ProductVendorId,
                ProductUrl = "product-link",
                IsVisible = true,
                CreateDate = DateTime.Now,
                SalePricePercent = 10,
                 UrlImage = "https://i.ibb.co/x8mf8SGR/vn-11134201-7ras8-m4fwphe1o1wg7f-resize-w450-nl.webp",
                UserId = SeedDataUser.GetIndex(8).UserId
            },
            // lỗi
            new Product
            {
                
                ProductId = Guid.NewGuid(), //3
                ProductName = "Giày Thể Thao sneaker Nữ Biti's Hunter HSW002301TRG",
                Description = "Giày Thể Thao Nam - Nữ Biti's Hunter Core HSM006200TRG/HSW006200TRG\nMàu sắc: Trắng",
                ProductTypeName = "Shoes",
                ProductVendorId = SeedDataProductVendor.GetIndex(3).ProductVendorId,
                ProductUrl = "product-link",
                IsVisible = true,
                CreateDate = DateTime.Now,
                SalePricePercent = 10,
                 UrlImage = "https://i.ibb.co/SXzwZXvF/bitis.webp",
                UserId = SeedDataUser.GetIndex(8).UserId
            },
            // lỗi
            new Product
            {
                ProductId = Guid.Parse("E2A1C4F7-3B5D-4E19-824E-68F7A9CDB50F"), //4
                ProductName = "Giày Thể Thao Nam Biti's Hunter Core HSM005400XAM",
                Description = "Giày Thể Thao Nam - Nữ Biti's Hunter Core HSM006200TRG/HSW006200TRG\nMàu sắc: Xám",
                ProductTypeName = "Shoes",
                ProductVendorId = SeedDataProductVendor.GetIndex(3).ProductVendorId,
                ProductUrl = "product-link",
                IsVisible = true,
                CreateDate = DateTime.Now,
                SalePricePercent = 10,
                 UrlImage = "https://i.ibb.co/FLmDcq6K/sg-11134201-7rbma-lq8rgpyall461d.webp",
                UserId = SeedDataUser.GetIndex(8).UserId
            },
            //lỗi
            new Product
            {
                ProductId = Guid.NewGuid(), //5
                ProductName = "Thắt lưng nam da bò AT Leather P145",
                Description = "Thắt lưng nam da bò cao cấp mặt khóa đen bạc Williampolo, dây nịt nam khóa tự động họa tiết nổi",
                ProductTypeName = "Belt",
                ProductVendorId = SeedDataProductVendor.GetIndex(4).ProductVendorId,
                ProductUrl = "product-link",
                IsVisible = true,
                CreateDate = DateTime.Now,
                 UrlImage = "https://i.ibb.co/hFvfhTqn/vn-11134207-7ras8-m3hjkt9girs198.webp",
                UserId = SeedDataUser.GetIndex(7).UserId
            },
            new Product
            {
                ProductId = new Guid("41E0B6B8-3188-4F30-BCD7-5E4585977C3E"), //6
                ProductName = "TIE-DYE SHIRT IN ORGANIC COTTON",
                Description = "Featuring a playful collage of Coach icons past and present from artist Cody DeFranco, this long-sleeved T-shirt is crafted of organic cotton made without the use of harmful chemical fertilizers and pesticides. The relaxed-fit silhouette is finished with a ribbed crew neckline.",
                ProductTypeName = "Shirt", 
                ProductVendorId = SeedDataProductVendor.GetIndex(1).ProductVendorId,
                ProductUrl = "product-link",
                IsVisible = true,
                CreateDate = DateTime.Now,
                SalePricePercent = 15,
                 UrlImage = "https://i.ibb.co/zTTXpmrn/ct058-ylw-a0-1.jpg",
                UserId = SeedDataUser.GetIndex(7).UserId
            },
            new Product
            {
                ProductId = Guid.NewGuid(), //7
                ProductName = "WINDBREAKER IN RECYCLED POLYESTER",
                Description = "Finished with our tonal Signature, this lightweight, water-resistant windbreaker is a great transitional piece. Crafted of recycled materials inspired by our commitment to rethinking and reducing our impact on the planet, the zip-front style features a protective funnel collar and zip pockets to safely store small essentials.",
                ProductTypeName = "Shirt",
                ProductVendorId = SeedDataProductVendor.GetIndex(1).ProductVendorId,
                ProductUrl = "product-link",
                IsVisible = true,
                CreateDate = DateTime.Now,
                SalePricePercent = 20,
                 UrlImage = "https://i.ibb.co/nsSqFnTR/M-NK-DF-UV-PRIMARY-FZ-HOODIE.jpg",
                UserId = SeedDataUser.GetIndex(8).UserId
            },

             new Product
            {
                ProductId = new Guid("DC356296-EA2D-40B0-8616-6B9359150300"), //8
                ProductName = "BLACK DENIM JACKET IN ORGANIC COTTON",
                Description = "About the Creative: Cody DeFranco is an independent artist and designer based in upstate New York. A graduate of the Massachusetts College of Art & Design, he specializes in printmaking, producing graphic and textural works with a zine-like appeal.",
                ProductTypeName = "Shirt",
                ProductVendorId = SeedDataProductVendor.GetIndex(1).ProductVendorId,
                ProductUrl = "product-link",
                IsVisible = true,
                CreateDate = DateTime.Now,
                SalePricePercent = 10,
                UrlImage = "https://i.ibb.co/CsWwRJxD/M-NK-DF-TEE-DFC-CREW-SOLID.jpg",
                UserId = SeedDataUser.GetIndex(8).UserId
            },
             new Product
            {
                ProductId = new Guid("290B156E-74B8-4C49-92AA-CCB3731D5C4D"), //9
                ProductName = "REVERSIBLE LEATHER JACKET IN RECYCLED POLYESTER",
                Description = "Finished with our tonal Signature, this lightweight, water-resistant windbreaker is a great transitional piece. Crafted of recycled materials inspired by our commitment to rethinking and reducing our impact on the planet, the zip-front style features a protective funnel collar and zip pockets to safely store small essentials.",
                ProductTypeName = "Shirt",
                ProductVendorId = SeedDataProductVendor.GetIndex(1).ProductVendorId,
                ProductUrl = "product-link",
                IsVisible = true,
                CreateDate = DateTime.Now,
                SalePricePercent = 10,
                UrlImage = "https://i.ibb.co/tpJLdK0B/M-NK-TCH-WVN-WR-FZ-JKT.jpg",
                UserId = SeedDataUser.GetIndex(8).UserId
            },
              new Product
            {
                ProductId = new Guid("BF690DF5-3AD8-4FC3-8D8F-9A03B20A270C"), //10
                ProductName = "CARGO PANTS",
                Description = "Comfortable and versatile cargo pants for daily wear.",
                ProductTypeName = "Pants",
                ProductVendorId = SeedDataProductVendor.GetIndex(1).ProductVendorId,
                ProductUrl = "product-link",
                IsVisible = true,
                CreateDate = DateTime.Now,
                SalePricePercent = 10,
                UrlImage = "https://i.ibb.co/8n0LTWD3/cae11-b5h-a0-fmt-jpg-wid-711-hei-888-qlt-80-1-op-sharpen-0-res-Mode-bicub-op-usm-5-0.webp",
                UserId = SeedDataUser.GetIndex(8).UserId
            },
            new Product
            {
                ProductId = new Guid("D7AB4C81-01D3-46BB-9D65-AF3B02C00FA6"), //11
                ProductName = "TIE-DYE SHORTS IN ORGANIC COTTON",
                Description = "A lightweight warm weather style, these Signature jacquard shorts are crafted of organic cotton made without the use of harmful chemical fertilizers and pesticides. Featuring an elastic drawstring waist, the classic-fit silhouette is finished with cargo pockets and back slip pockets for plenty of on-the-go organization. Pair with the matching top for a coordinated look.",
                ProductTypeName = "Pants",
                ProductVendorId = SeedDataProductVendor.GetIndex(1).ProductVendorId,
                ProductUrl = "product-link",
                IsVisible = true,
                CreateDate = DateTime.Now,
                SalePricePercent = 10,
                UrlImage = "https://i.ibb.co/Cs9jDDP1/ct059-ylw-a0-fmt-jpg-wid-711-hei-888-qlt-80-1-op-sharpen-0-res-Mode-bicub-op-usm-5-0.webp",
                UserId = SeedDataUser.GetIndex(8).UserId
            },
            new Product
            {
                ProductId = new Guid("06D0E5D4-F3A9-418B-9EF8-1ABE80792CAA"), //12
                ProductName = "ESSENTIAL SIGNATURE JOGGERS",
                Description = "A liberal, comfortable and individual fashion style mixed with a bit of sloppiness full of technical art are the words for Fear of God so you can mix and match them with your style. ",
                ProductTypeName = "Pants",
                ProductVendorId = SeedDataProductVendor.GetIndex(0).ProductVendorId,
                ProductUrl = "product-link",
                IsVisible = true,
                CreateDate = DateTime.Now,
                SalePricePercent = 10,
                UrlImage = "https://i.ibb.co/0VtD7KDx/cp979-r8e-a0-fmt-jpg-wid-711-hei-888-qlt-80-1-op-sharpen-0-res-Mode-bicub-op-usm-5-0.webp",
                UserId = SeedDataUser.GetIndex(8).UserId
            },
            new Product
            {
                ProductId = new Guid("1ED492FE-5B8D-4F5B-B546-C0F2D9467FCC"), //13
                ProductName = "BLACK TAPER JEANS",
                Description = "Easy to dress up or dress down, our workwear-inspired jeans are detailed with front paneling, slip pockets and a side loop. Our Coach leather patch adds heritage style.",
                ProductTypeName = "Pants",
                ProductVendorId = SeedDataProductVendor.GetIndex(1).ProductVendorId,
                ProductUrl = "product-link",
                IsVisible = true,
                CreateDate = DateTime.Now,
                SalePricePercent = 10,
                UrlImage = "https://i.ibb.co/399vf6kV/ct205-blk-a0-fmt-jpg-wid-711-hei-888-qlt-80-1-op-sharpen-0-res-Mode-bicub-op-usm-5-0.webp",
                UserId = SeedDataUser.GetIndex(8).UserId
            },
            new Product
            {
                ProductId = new Guid("835045CC-9F17-4EC4-8793-DF54A9ED5C8E"), //14
                ProductName = "DENIM SHORTS",
                Description = "A lightweight warm weather style, these Signature jacquard shorts are crafted of organic cotton made without the use of harmful chemical fertilizers and pesticides. Featuring an elastic drawstring waist, the classic-fit silhouette is finished with cargo pockets and back slip pockets for plenty of on-the-go organization. Pair with the matching top for a coordinated look.",
                ProductTypeName = "Pants",
                ProductVendorId = SeedDataProductVendor.GetIndex(1).ProductVendorId,
                ProductUrl = "product-link",
                IsVisible = true,
                CreateDate = DateTime.Now,
                SalePricePercent = 10,
                UrlImage = "https://i.ibb.co/BHSV88jH/cr356-p9j-a0-fmt-jpg-wid-711-hei-888-qlt-80-1-op-sharpen-0-res-Mode-bicub-op-usm-5-0.webp",
                UserId = SeedDataUser.GetIndex(8).UserId
            },
            new Product
            {
                ProductId = new Guid("DD541FDE-9F56-4063-A409-C9597C04A9BF"), //15
                ProductName = "TRACK JOGGERS",
                Description = "A lightweight warm weather style, these Signature jacquard shorts are crafted of organic cotton made without the use of harmful chemical fertilizers and pesticides. Featuring an elastic drawstring waist, the classic-fit silhouette is finished with cargo pockets and back slip pockets for plenty of on-the-go organization. Pair with the matching top for a coordinated look.",
                ProductTypeName = "Pants",
                ProductVendorId = SeedDataProductVendor.GetIndex(1).ProductVendorId,
                ProductUrl = "product-link",
                IsVisible = true,
                CreateDate = DateTime.Now,
                SalePricePercent = 10,
                UrlImage = "https://i.ibb.co/xqBH436m/cb815-vee-a0-fmt-jpg-wid-711-hei-888-qlt-80-1-op-sharpen-0-res-Mode-bicub-op-usm-5-0.webp",
                UserId = SeedDataUser.GetIndex(8).UserId
            },
            new Product
            {
                ProductId = new Guid("BF87F40A-8726-434E-9750-76ABFAEDDE05"), //16
                ProductName = "TAILORED PANTS",
                Description = "A lightweight warm weather style, these Signature jacquard shorts are crafted of organic cotton made without the use of harmful chemical fertilizers and pesticides. Featuring an elastic drawstring waist, the classic-fit silhouette is finished with cargo pockets and back slip pockets for plenty of on-the-go organization. Pair with the matching top for a coordinated look.",
                ProductTypeName = "Pants",
                ProductVendorId = SeedDataProductVendor.GetIndex(1).ProductVendorId,
                ProductUrl = "product-link",
                IsVisible = true,
                CreateDate = DateTime.Now,
                SalePricePercent = 10,
                UrlImage = "https://i.ibb.co/5ggZDXTb/cr733-kha-a0-fmt-jpg-wid-711-hei-888-qlt-80-1-op-sharpen-0-res-Mode-bicub-op-usm-5-0.webp",
                UserId = SeedDataUser.GetIndex(8).UserId
            },
            new Product
            {
                ProductId = new Guid("63C04F52-E583-4773-9CDD-E4195016F27E"), //17
                ProductName = "BOXER SHORTS IN ORGANIC COTTON",
                Description = "A lightweight warm weather style, these Signature jacquard shorts are crafted of organic cotton made without the use of harmful chemical fertilizers and pesticides. Featuring an elastic drawstring waist, the classic-fit silhouette is finished with cargo pockets and back slip pockets for plenty of on-the-go organization. Pair with the matching top for a coordinated look.",
                ProductTypeName = "Pants",
                ProductVendorId = SeedDataProductVendor.GetIndex(1).ProductVendorId,
                ProductUrl = "product-link",
                IsVisible = true,
                CreateDate = DateTime.Now,
                SalePricePercent = 10,
                UrlImage = "https://i.ibb.co/Z6QNjy96/cs646-qr7-a0-fmt-jpg-wid-711-hei-888-qlt-80-1-op-sharpen-0-res-Mode-bicub-op-usm-5-0.webp",
                UserId = SeedDataUser.GetIndex(8).UserId
            },
            new Product
            {
                ProductId = new Guid("52939CDC-B01F-4A93-874F-2E1B8A8ECA5D"), //18
                ProductName = "SHORT INSEAM WIDE LEG TROUSERS",
                Description = "Trendy wide-leg trousers with a short inseam for a unique look.",
                ProductTypeName = "Pants",
                ProductVendorId = SeedDataProductVendor.GetIndex(1).ProductVendorId,
                ProductUrl = "product-link",
                IsVisible = true,
                CreateDate = DateTime.Now,
                SalePricePercent = 10,
                UrlImage = "https://i.ibb.co/1GKYP6YH/cn484-nvwt-a0-fmt-jpg-wid-711-hei-888-qlt-80-1-op-sharpen-0-res-Mode-bicub-op-usm-5-0.webp",
                UserId = SeedDataUser.GetIndex(8).UserId
            },
            new Product
            {
                ProductId = new Guid("24FCE224-8454-46AE-94E3-51561C4323FF"), //19
                ProductName = "CARGO PANT ASIA FIT",
                Description = "Stylish cargo pants designed with an Asia fit.",
                ProductTypeName = "Pants",
                ProductVendorId = SeedDataProductVendor.GetIndex(1).ProductVendorId,
                ProductUrl = "product-link",
                IsVisible = true,
                CreateDate = DateTime.Now,
                SalePricePercent = 10,
                UrlImage = "https://i.ibb.co/kgPx8b3c/ct588-tv4-a0-fmt-jpg-wid-711-hei-888-qlt-80-1-op-sharpen-0-res-Mode-bicub-op-usm-5-0.webp",
                UserId = SeedDataUser.GetIndex(8).UserId
            },
            new Product
{
    ProductId = new Guid("C5133F2F-2EC8-4A6F-89DD-DAF5019E4D0B"), //20
    ProductName = "TANNER LOAFER",
    Description = "A sophisticated and timeless design, the Tanner loafer is crafted of smooth leather with a sleek silhouette perfect for any occasion.",
    ProductTypeName = "Shoes",
    ProductVendorId = SeedDataProductVendor.GetIndex(1).ProductVendorId,
    ProductUrl = "product-link",
    IsVisible = true,
    CreateDate = DateTime.Now,
    SalePricePercent = 10,
    UrlImage = "https://i.ibb.co/Pzr9mNqb/cs020-blk-a0-fmt-jpg-wid-711-hei-888-qlt-80-1-op-sharpen-0-res-Mode-bicub-op-usm-5-0.webp",
    UserId = SeedDataUser.GetIndex(8).UserId
},
new Product
{
    ProductId = new Guid("7F825305-1CAC-4F46-AAC3-A2AC23E0BF19"), //21
    ProductName = "C301 SNEAKER",
    Description = "A sleek style based on classic running shoes, our sporty C301 sneaker is crafted in a mix of suede, leather and mesh fabric. Detailed with our name at the heel, the lace-up design is finished with our Signature at the side and a lightweight EVA sole for all-day comfort and traction.",
    ProductTypeName = "Shoes",
    ProductVendorId = SeedDataProductVendor.GetIndex(1).ProductVendorId,
    ProductUrl = "product-link",
    IsVisible = true,
    CreateDate = DateTime.Now,
    SalePricePercent = 15,
    UrlImage = "https://i.ibb.co/YBhZL7hZ/cu012-xgn-a0-fmt-jpg-wid-711-hei-888-qlt-80-1-op-sharpen-0-res-Mode-bicub-op-usm-5-0.webp",
    UserId = SeedDataUser.GetIndex(8).UserId
},
new Product
{
    ProductId = new Guid("306410F8-A1D5-4432-8DB3-A1E47C637DF4"), //22
    ProductName = "RUNNER SNEAKER",
    Description = "A cool, classic sneaker style for on-the-run days, this elevated running shoe is crafted in a mix of suede, nylon and leather detailed with our puffy Signature. It’s finished with a comfortable EVA sole for all-day comfort and ease.",
    ProductTypeName = "Shoes",
    ProductVendorId = SeedDataProductVendor.GetIndex(1).ProductVendorId,
    ProductUrl = "product-link",
    IsVisible = true,
    CreateDate = DateTime.Now,
    SalePricePercent = 10,
    UrlImage = "https://i.ibb.co/35n5GNkb/cu362-xc3-a0-fmt-jpg-wid-711-hei-888-qlt-80-1-op-sharpen-0-res-Mode-bicub-op-usm-5-0.webp",
    UserId = SeedDataUser.GetIndex(8).UserId
},
new Product
{
    ProductId = new Guid("719beb80-79a4-431e-91a1-14b93c3e1b51"), //23
    ProductName = "BUCKLE STRAP SANDAL IN SIGNATURE JACQUARD",
    Description = "Easy to dress up or down, the Margot sandal is crafted of our Signature jacquard with smooth leather details. This slip-on design is finished with a polished buckle and a sculpted kitten heel.",
    ProductTypeName = "Shoes",
    ProductVendorId = SeedDataProductVendor.GetIndex(0).ProductVendorId,
    ProductUrl = "product-link",
    IsVisible = true,
    CreateDate = DateTime.Now,
    SalePricePercent = 20,
    UrlImage = "https://i.ibb.co/4RXrPmfK/ct281-blk-a0-fmt-jpg-wid-711-hei-888-qlt-80-1-op-sharpen-0-res-Mode-bicub-op-usm-5-0.webp",
    UserId = SeedDataUser.GetIndex(7).UserId
},
new Product
{
    ProductId = new Guid("BB64E3A4-B8CB-4630-AF6F-08A6831BDF8D"), //24
    ProductName = "LUCA DRIVER",
    Description = "Elevate your casual wardrobe with the Luca Driver, a classic loafer design crafted from supple leather with a durable rubber sole.",
    ProductTypeName = "Shoes",
    ProductVendorId = SeedDataProductVendor.GetIndex(0).ProductVendorId,
    ProductUrl = "product-link",
    IsVisible = true,
    CreateDate = DateTime.Now,
    SalePricePercent = 10,
    UrlImage = "https://i.ibb.co/YBqfbH6B/cs004-ary-a0-fmt-jpg-wid-711-hei-888-qlt-80-1-op-sharpen-0-res-Mode-bicub-op-usm-5-0.webp",
    UserId = SeedDataUser.GetIndex(8).UserId
},
new Product
{
    ProductId = new Guid("591406F3-F813-46E5-B8DA-C1F4AF263A7F"), //25
    ProductName = "REILLY ESPADRILLE",
    Description = "A versatile warm-weather staple, the Reilly Espadrille is crafted with lightweight canvas and features a braided jute sole for a natural look.",
    ProductTypeName = "Shoes",
    ProductVendorId = SeedDataProductVendor.GetIndex(1).ProductVendorId,
    ProductUrl = "product-link",
    IsVisible = true,
    CreateDate = DateTime.Now,
    SalePricePercent = 15,
    UrlImage = "https://i.ibb.co/Pz48Tkhs/cs029-rm3-a0-fmt-jpg-wid-711-hei-888-qlt-80-1-op-sharpen-0-res-Mode-bicub-op-usm-5-0.webp",
    UserId = SeedDataUser.GetIndex(8).UserId
},
new Product
{
    ProductId = new Guid("49cd6329-4105-4b25-a75d-643f6dcec795"), //26
    ProductName = "RUNNER SNEAKER",
    Description = "A comfortable and durable sneaker perfect for active lifestyles, featuring a breathable upper and a lightweight, cushioned sole.",
    ProductTypeName = "Shoes",
    ProductVendorId = SeedDataProductVendor.GetIndex(1).ProductVendorId,
    ProductUrl = "product-link",
    IsVisible = true,
    CreateDate = DateTime.Now,
    SalePricePercent = 10,
    UrlImage = "https://i.ibb.co/ynYgyppW/cr998-w35-a0-fmt-jpg-wid-711-hei-888-qlt-80-1-op-sharpen-0-res-Mode-bicub-op-usm-5-0.webp",
    UserId = SeedDataUser.GetIndex(8).UserId
},
new Product
{
    ProductId = new Guid("B3783337-E962-4531-AC60-FC8DD1592B5B"), //27
    ProductName = "C203 SNEAKER IN SIGNATURE CANVAS",
    Description = "This updated take on the classic C203 sneaker features our signature canvas and a streamlined, modern silhouette.",
    ProductTypeName = "Shoes",
    ProductVendorId = SeedDataProductVendor.GetIndex(1).ProductVendorId,
    ProductUrl = "product-link",
    IsVisible = true,
    CreateDate = DateTime.Now,
    SalePricePercent = 10,
    UrlImage = "https://i.ibb.co/My5m9pmp/cr991-chk-a0-fmt-jpg-wid-711-hei-888-qlt-80-1-op-sharpen-0-res-Mode-bicub-op-usm-5-0.webp",
    UserId = SeedDataUser.GetIndex(8).UserId
},
new Product
{
    ProductId = new Guid("0D9DBE13-446B-41F4-9CDB-188265CE870D"), //28
    ProductName = "EMILIA MARY JANE",
    Description = "A modern twist on the classic Mary Jane style, the Emilia features elegant straps and a polished finish, perfect for any occasion.",
    ProductTypeName = "Shoes",
    ProductVendorId = SeedDataProductVendor.GetIndex(0).ProductVendorId,
    ProductUrl = "product-link",
    IsVisible = true,
    CreateDate = DateTime.Now,
    SalePricePercent = 15,
    UrlImage = "https://i.ibb.co/CpWxxn9m/cn116-blh-a0-fmt-jpg-wid-711-hei-888-qlt-80-1-op-sharpen-0-res-Mode-bicub-op-usm-5-0.webp",
    UserId = SeedDataUser.GetIndex(7).UserId
},
new Product
{
    ProductId = new Guid("5b7acda4-8b50-4c4e-a01f-cbc4c363d6df"), //29
    ProductName = "MARGOT SANDAL IN SIGNATURE TEXTILE JACQUARD",
    Description = "The Margot Sandal is designed with signature textile jacquard and features a comfortable footbed and an adjustable strap for a perfect fit.",
    ProductTypeName = "Shoes",
    ProductVendorId = SeedDataProductVendor.GetIndex(1).ProductVendorId,
    ProductUrl = "product-link",
    IsVisible = true,
    CreateDate = DateTime.Now,
    SalePricePercent = 20,
    UrlImage = "https://i.ibb.co/gbP3c3Zk/cz373-rby-a0-fmt-jpg-wid-711-hei-888-qlt-80-1-op-sharpen-0-res-Mode-bicub-op-usm-5-0.webp",
    UserId = SeedDataUser.GetIndex(8).UserId
},
new Product
{
    ProductId = new Guid("6EDA30B6-2536-4C59-880D-29C9747D86FA"), //30
    ProductName = "Men's Colorful Mesh Baseball Cap",
    Description = "A lightweight and breathable baseball cap with a colorful mesh design, perfect for outdoor activities.",
    ProductTypeName = "Hat",
    ProductVendorId = SeedDataProductVendor.GetIndex(2).ProductVendorId,
    ProductUrl = "product-link",
    IsVisible = true,
    CreateDate = DateTime.Now,
    SalePricePercent = 10,
    UrlImage = "https://i.ibb.co/Kmj5z60/288436-xydcs1.jpg",
    UserId = SeedDataUser.GetIndex(7).UserId
},
new Product
{
    ProductId = new Guid("EFCCA3BA-5B9C-4AF9-9057-2F497E0D033C"), //31
    ProductName = "Men's Camouflage Fishing Cap",
    Description = "A stylish and practical camouflage cap designed for fishing enthusiasts. Features a comfortable fit and sun protection.",
    ProductTypeName = "Hat",
    ProductVendorId = SeedDataProductVendor.GetIndex(2).ProductVendorId,
    ProductUrl = "product-link",
    IsVisible = true,
    CreateDate = DateTime.Now,
    SalePricePercent = 15,
    UrlImage = "https://i.ibb.co/GtSmn4J/1150338-rdngd8.jpg",
    UserId = SeedDataUser.GetIndex(8).UserId
},
new Product
{
    ProductId = new Guid("6938AEA0-5775-42DD-8C94-D64D603A498B"), //32
    ProductName = "Waterproof Breathing Fishing Cap",
    Description = "This cap combines waterproof functionality with breathable material, making it ideal for fishing in various conditions.",
    ProductTypeName = "Hat",
    ProductVendorId = SeedDataProductVendor.GetIndex(2).ProductVendorId,
    ProductUrl = "product-link",
    IsVisible = true,
    CreateDate = DateTime.Now,
    SalePricePercent = 20,
    UrlImage = "https://i.ibb.co/VJLBrb9/1144694-pkzrtj.jpg",
    UserId = SeedDataUser.GetIndex(7).UserId
},
// lỗi
new Product
{
    ProductId = new Guid("fce3f1a4-fdfc-4b93-8552-4ed748bb6a8b"), //33
    ProductName = "Fishing Adjustable Camouflage Cap",
    Description = "An adjustable camouflage cap tailored for fishing trips, providing comfort and a secure fit throughout the day.",
    ProductTypeName = "Shirt",
    ProductVendorId = SeedDataProductVendor.GetIndex(2).ProductVendorId,
    ProductUrl = "product-link",
    IsVisible = true,
    CreateDate = DateTime.Now,
    SalePricePercent = 10,
    UrlImage = "https://i.ibb.co/Pn8p37k/vn-11134207-7ras8-m0iodayfxlgt1c.webp",
    UserId = SeedDataUser.GetIndex(8).UserId
},
new Product
{
    ProductId = new Guid("92448B12-C6CF-4D65-B820-B3E29FD258A1"), //34
    ProductName = "Fashion Trend Baseball Cap/Net",
    Description = "A trendy baseball cap with a netted back, combining fashion and functionality for a casual look.",
    ProductTypeName = "Hat",
    ProductVendorId = SeedDataProductVendor.GetIndex(2).ProductVendorId,
    ProductUrl = "product-link",
    IsVisible = true,
    CreateDate = DateTime.Now,
    SalePricePercent = 15,
    UrlImage = "https://i.ibb.co/98DDFDw/image.png",
    UserId = SeedDataUser.GetIndex(7).UserId
},
new Product
{
    ProductId = new Guid("db852178-b895-48ab-9bff-7d0211c02a40"), //35
    ProductName = "Double-Knit Jacquard Ball Cap",
    Description = "The classic ball cap is updated in smooth double-knit jacquard and a five-panel design for a sleek, modern look. Our signature Pony accents the front.",
    ProductTypeName = "Hat",
    ProductVendorId = SeedDataProductVendor.GetIndex(3).ProductVendorId,
    ProductUrl = "product-link",
    IsVisible = true,
    CreateDate = DateTime.Now.AddDays(-15),
    SalePricePercent = 20,
    UrlImage = "https://i.ibb.co/51HqJkg/s7-1404068-lifestyle-rl-1x1-pdp.webp",
    UserId = SeedDataUser.GetIndex(8).UserId
},
new Product
{
    ProductId = new Guid("CC80D1DD-6574-4F45-B756-4C3E8713F8A5"), //36
    ProductName = "Cotton Chino Bucket Hat",
    Description = "A classic bucket hat made from durable cotton chino, offering sun protection and a stylish look.",
    ProductTypeName = "Hat",
    ProductVendorId = SeedDataProductVendor.GetIndex(3).ProductVendorId,
    ProductUrl = "product-link",
    IsVisible = true,
    CreateDate = DateTime.Now.AddDays(-10),
    SalePricePercent = 10,
    UrlImage = "https://i.ibb.co/r7xcYsj/s7-1443323-lifestyle-rl-1x1-pdp.webp",
    UserId = SeedDataUser.GetIndex(7).UserId
},
new Product
{
    ProductId = new Guid("260FE078-EC31-4817-BC56-790828894060"), //37
    ProductName = "Cotton Chino Ball Cap",
    Description = "A pre-curved bill gives this baseball cap a broken-in look from day one, while our cotton chino fabric only gets better with wear. Add a special touch by selecting from a range of new personalized details.",
    ProductTypeName = "Hat",
    ProductVendorId = SeedDataProductVendor.GetIndex(3).ProductVendorId,
    ProductUrl = "product-link",
    IsVisible = true,
    CreateDate = DateTime.Now,
    SalePricePercent = 10,
    UrlImage = "https://i.ibb.co/JcFWLvs/s7-1478247-lifestyle-rl-1x1-pdp.webp",
    UserId = SeedDataUser.GetIndex(8).UserId
},
new Product
{
    ProductId = new Guid("371E0531-3325-4BA4-B2E9-67F71E16BCED"), //38
    ProductName = "CASQUETTE BMW M MOTORSPORT STATEMENT",
    Description = "BMW M Motorsport has never been afraid of making a statement – it has always had bold cars and even bolder liveries. This cap follows.",
    ProductTypeName = "Hat",
    ProductVendorId = SeedDataProductVendor.GetIndex(4).ProductVendorId,
    ProductUrl = "product-link",
    IsVisible = true,
    CreateDate = DateTime.Now,
    SalePricePercent = 15,
    UrlImage = "https://i.ibb.co/DCgBvJT/casquette-bmw-m-motorsport-statement.jpg",
    UserId = SeedDataUser.GetIndex(8).UserId
},
new Product
{
    ProductId = new Guid("4E5A135B-8F21-4E5D-BBE6-4B2E45EFF455"), //39
    ProductName = "Black Thick Slouchy Knit Oversized Beanie Cap Hat",
    Description = "Stay cozy and stylish with this thick, oversized beanie cap, crafted from soft knit material for added warmth.",
    ProductTypeName = "Hat",
    ProductVendorId = SeedDataProductVendor.GetIndex(4).ProductVendorId,
    ProductUrl = "product-link",
    IsVisible = true,
    CreateDate = DateTime.Now,
    SalePricePercent = 10,
    UrlImage = "https://i.ibb.co/VShCrTP/612-N3-Wb-CD2-L-AC-SX569.jpg",
    UserId = SeedDataUser.GetIndex(7).UserId
}



        };
     
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(Products);
        }
        public static Product GetIndex(int index)
        {
            if (index < 0 || index >= Products.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Index must be within the range of products.");
            }

            return Products[index];
        }
    }
}
