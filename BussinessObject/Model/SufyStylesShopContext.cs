using System;
using System.Collections.Generic;
using BussinessObject.Model;
using BussinessObject.SeedData;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BussinessObject.Models;

public  class SufyStylesShopContext : DbContext
{
    public SufyStylesShopContext()
    {
    }
    public SufyStylesShopContext(DbContextOptions<SufyStylesShopContext> options) : base(options) { }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
        IConfigurationRoot configuration = builder.Build();
        optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));

    }
    public virtual DbSet<UserAddress> UserAddresses { get; set; }
    public virtual DbSet<CartItem> CartItems { get; set; }
  
    public virtual DbSet<PaymentMethod> PaymentMethods { get; set; }
    public virtual DbSet<Order> Orders { get; set; }
    public virtual DbSet<Role> Roles { get; set; }
    public virtual DbSet<User> Users { get; set; }  
  
    public virtual DbSet<OrderedDetail> OrderedDetails { get; set; }
    public virtual DbSet<Product> Products { get; set; }
   
    public virtual DbSet<ProductVariant> ProductVariants { get; set; }
    public virtual DbSet<ProductVendor> ProductVendors { get; set; }
    public virtual DbSet<PostBookmark> PostBookmarks { get; set; }
    public virtual DbSet<UserWishList> UserWishLists { get; set; }
    public virtual DbSet<UserFollow> UserFollows { get; set; }

    public virtual DbSet<ProductFeedback> ProductFeedbacks { get; set; } 
    public virtual DbSet<UserVoucher> UserVouchers { get; set; } 
    public virtual DbSet<VoucherCheck> VoucherChecks { get; set; }  

    //
    public virtual DbSet<Banner> Banners { get; set; }
    public virtual DbSet<StaticPage> StaticPages { get; set; }
    public virtual DbSet<FAQ> FAQs { get; set; } 
  
    public virtual DbSet<ContactForm> ContactForms { get; set; }

    // POST
    public virtual DbSet<Post> Posts { get; set; }
    public virtual DbSet<PostLike> PostLikes { get; set; }
    public virtual DbSet<PostImage> PostImages { get; set; }
    public virtual DbSet<PostComment> PostComments { get; set; }
    public virtual DbSet<PostCommentLike> PostCommentLikes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Post 

        modelBuilder.Entity<Post>()
            .HasOne(p => p.Author)
            .WithMany(a => a.Posts)
            .HasForeignKey(p => p.AuthorId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Post>()
            .HasMany(p => p.PostLikes)
            .WithOne(pl => pl.Post)
            .HasForeignKey(l => l.PostId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Post>()
            .HasMany(p => p.PostComments)
            .WithOne(pc => pc.Post)
            .HasForeignKey(c => c.PostId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Post>()
            .HasMany(p => p.PostImages)
            .WithOne(pi => pi.Post)
            .HasForeignKey(i => i.PostId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Post>()
            .HasMany(p => p.PostProductTags)
            .WithOne(ppt => ppt.Post)
            .HasForeignKey(p => p.PostId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<PostCommentLike>(entity =>
        {
            entity.HasKey(pcl => new { pcl.UserId, pcl.CommentId });

            entity.HasOne(pcl => pcl.User)
                .WithMany(u => u.PostCommentLikes)  // Một User có thể thích nhiều PostComment
                .HasForeignKey(pcl => pcl.UserId)
                .OnDelete(DeleteBehavior.Restrict);  // Không xóa User khi xóa PostCommentLike

            // Cấu hình mối quan hệ giữa PostCommentLike và PostComment
            entity.HasOne(pcl => pcl.PostComment)
                .WithMany(pc => pc.PostCommentLikes)
                .HasForeignKey(pcl => pcl.CommentId)
                .OnDelete(DeleteBehavior.Restrict);  // Không xóa PostComment khi xóa PostCommentLike
        });
        modelBuilder.Entity<PostComment>(entity =>
        {
           
            entity.HasOne(c => c.Post)
                .WithMany(p => p.PostComments) // Một Post có thể có nhiều PostComment
                .HasForeignKey(c => c.PostId)
                .OnDelete(DeleteBehavior.Restrict); // Không xóa PostComment khi Post bị xóa

            entity.HasOne(c => c.User)
                .WithMany(u => u.PostComments)
                .HasForeignKey(c => c.UserId)
                .OnDelete(DeleteBehavior.Restrict); // Không xóa PostComment khi User bị xóa

            entity.HasMany(c => c.PostCommentLikes)
                .WithOne(pcl => pcl.PostComment) // Nếu PostCommentLike không có quan hệ ngược lại
                .HasForeignKey(clp => clp.CommentId) // Cấu hình CommentId trong PostCommentLike trỏ về PostComment
                .OnDelete(DeleteBehavior.Restrict); // Không xóa PostComment khi PostCommentLike bị xóa
        });

        modelBuilder.Entity<PostImage>(builder =>
        {
            builder.HasOne(pi => pi.Post)
                   .WithMany(p => p.PostImages)
                   .HasForeignKey(pi => pi.PostId)
                   .OnDelete(DeleteBehavior.SetNull);  // Cấu hình hành vi xóa null
        });

        modelBuilder.Entity<PostLike>(builder =>
        {
            builder.HasKey(pl => new { pl.UserId, pl.PostId });

            builder.HasOne(pl => pl.Post)
                .WithMany(p => p.PostLikes)
                .HasForeignKey(pl => pl.PostId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(pl => pl.User)
                .WithMany(u => u.PostLikes)
                .HasForeignKey(pl => pl.UserId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        // Cấu hình PostBookmark
        modelBuilder.Entity<PostBookmark>(builder =>
        {
            builder.HasKey(pus => new { pus.UserId, pus.PostId });

            builder.HasOne(pus => pus.Post)
                .WithMany(p => p.PostBookmarks)
                .HasForeignKey(pus => pus.PostId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(pus => pus.User)
                .WithMany(u => u.PostUserSaves)
                .HasForeignKey(pus => pus.UserId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        // Cấu hình UserVoucher
        modelBuilder.Entity<UserVoucher>(builder =>
        {
           
            builder.HasOne(uv => uv.User)
                .WithMany(a => a.UserVouchers)
                .HasForeignKey(uv => uv.UserCreateId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(uv => uv.VoucherChecks)
                .WithOne(vc => vc.UserVoucher)
                .HasForeignKey(vc => vc.VoucherId)
                .OnDelete(DeleteBehavior.Cascade);
        });


        //Product
        modelBuilder.Entity<Product>()
             .HasOne(p => p.User)
             .WithMany(a => a.Products)
             .HasForeignKey(p => p.UserId)
             .OnDelete(DeleteBehavior.Restrict);

    
        modelBuilder.Entity<ProductVariant>()
            .HasOne(pv => pv.Product)
            .WithMany(p => p.ProductVariants)
            .HasForeignKey(pv => pv.ProductId);

        modelBuilder.Entity<ProductFeedback>()
          .HasOne(pc => pc.Product)
          .WithMany(p => p.ProductFeedbacks)
          .HasForeignKey(pc => pc.ProductId);

        // Follow table
        modelBuilder.Entity<UserFollow>()
          .HasKey(f => new { f.FollowingId, f.FollowerId }); 

        modelBuilder.Entity<UserFollow>()
            .HasOne(f => f.FollowingUser)
            .WithMany(u => u.Followers)
            .HasForeignKey(f => f.FollowingId) 
            .OnDelete(DeleteBehavior.Restrict); 

        modelBuilder.Entity<UserFollow>()
            .HasOne(f => f.FollowerUser)
            .WithMany(u => u.Following)
            .HasForeignKey(f => f.FollowerId) 
            .OnDelete(DeleteBehavior.Restrict);

        //Order table
        // Cấu hình quan hệ giữa Order và User
        modelBuilder.Entity<Order>()
            .HasOne(o => o.User)
            .WithMany(u => u.Orders)
            .HasForeignKey(o => o.UserId)
            .OnDelete(DeleteBehavior.NoAction);

        // Cấu hình quan hệ giữa Order và Admin (ComfirmAdminId có thể là NULL)
        modelBuilder.Entity<Order>()
            .HasOne(o => o.Staff)
            .WithMany(a => a.ConfirmOrders)
            .HasForeignKey(o => o.ComfirmUserId)
            .OnDelete(DeleteBehavior.NoAction);

        // Cấu hình quan hệ giữa Order và PaymentMethod
        modelBuilder.Entity<Order>()
            .HasOne(o => o.PaymentMethod)
            .WithMany()
            .HasForeignKey(o => o.PaymentMethodId)
            .OnDelete(DeleteBehavior.NoAction);

        // Cấu hình quan hệ giữa Order và OrderedDetail
        modelBuilder.Entity<Order>()
            .HasMany(o => o.OrderDetails)
            .WithOne(od => od.Order)
            .HasForeignKey(od => od.OrderId);
        // Cấu hình quan hệ giữa Order và OrderedDetail (1 Order có nhiều OrderedDetails)
        modelBuilder.Entity<OrderedDetail>()
            .HasOne(od => od.Order)
            .WithMany(o => o.OrderDetails)
            .HasForeignKey(od => od.OrderId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<OrderedDetail>()
           .HasOne(od => od.ProductVariant)
           .WithMany()
           .HasForeignKey(od => od.VariantId);
        // Cấu hình quan hệ giữa OrderedDetail và Product
        modelBuilder.Entity<OrderedDetail>()
            .HasOne(od => od.Product)
            .WithMany()
            .HasForeignKey(od => od.ProductId)
            .OnDelete(DeleteBehavior.NoAction);
        //CartItem table
        modelBuilder.Entity<CartItem>()
        .HasOne(ci => ci.Product)
        .WithMany(p => p.CartItems)
        .HasForeignKey(ci => ci.ProductId);

        modelBuilder.Entity<CartItem>()
            .HasOne(ci => ci.User)
            .WithMany(u => u.CartItems)
            .HasForeignKey(ci => ci.UserId);

      
        //WishList table
        modelBuilder.Entity<UserWishList>()
              .HasKey(sl => new { sl.UserId, sl.ProductId });

        modelBuilder.Entity<UserWishList>()
            .HasOne(sl => sl.Product)
            .WithMany(p => p.WishLists)
            .HasForeignKey(sl => sl.ProductId)
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<UserWishList>()
            .HasOne(sl => sl.User)
            .WithMany(u => u.WishLists)
            .HasForeignKey(sl => sl.UserId)
             .OnDelete(DeleteBehavior.NoAction);

      

        modelBuilder.Entity<VoucherCheck>()
            .HasOne(vc => vc.UserVoucher)
            .WithMany(uv => uv.VoucherChecks)
            .HasForeignKey(vc => vc.VoucherId)
            .OnDelete(DeleteBehavior.Restrict); 

        modelBuilder.Entity<VoucherCheck>()
            .HasOne(vc => vc.User)
            .WithMany()
            .HasForeignKey(vc => vc.UserId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(SufyStylesShopContext).Assembly);
        SeedDataUser.Seed(modelBuilder);
        SeedDataProductVendor.Seed(modelBuilder);
        SeedDataPost.Seed(modelBuilder);      
        SeedDataProduct.Seed(modelBuilder);
        SeedDataRole.Seed(modelBuilder);     
        SeedDataAddress.Seed(modelBuilder);
        SeedDataCartItem.Seed(modelBuilder);
        SeedDataCommentList.Seed(modelBuilder);
        SeedDataFollow.Seed(modelBuilder);
        SeedDataLikeList.Seed(modelBuilder);
        SeedDataPaymentMethod.Seed(modelBuilder);
        SeedDataProductVariant.Seed(modelBuilder);
        SeedDataSaveList.Seed(modelBuilder);
        SeedDataWishList.Seed(modelBuilder);
        SeedDataProductComment.Seed(modelBuilder);
        SeedDataOrder.Seed(modelBuilder);
        SeedDataOrderedDetail.Seed(modelBuilder);
        SeedDataStaticPage.Seed(modelBuilder);
        SeedDataPostImage.Seed(modelBuilder);
        SeedDataPostProductTag.Seed(modelBuilder);
        SeedDataFAQ.Seed(modelBuilder);
        SeedDataContactForm.Seed(modelBuilder);
        SeedDataBanner.Seed(modelBuilder);   
        SeedDataUserVoucher.Seed(modelBuilder);
        base.OnModelCreating(modelBuilder);
    }

  
}
