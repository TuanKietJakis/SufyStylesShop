using Microsoft.Extensions.DependencyInjection;
using Repositories.IRepository;
using Repositories.Repository;
using Repository.IRepository;
using Repository.Repository;


namespace DataAccess.Core
{
    public static class DependencyInjection
    {
        public static void ConfigureDependencyInjection(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IPostRepository, PostRepository>();
            services.AddScoped<IPostCommentRepository, PostCommentRepository>();
            services.AddScoped<IPostLikeRepository, PostLikeRepository>();
            services.AddScoped<IPostBookmarkRepository, PostBookmarkRepository>();
            services.AddScoped<IUserCommentLikeRepository, UserCommentLikeRepository>();
      
            services.AddScoped<IProductRepository, ProductRepository>();
        
            services.AddScoped<IAuthenticationRepository, AuthenticationRepository>();
            services.AddScoped<ICartRepository, CartRepository>();
            services.AddScoped<IUserVoucherRepository, UserVoucherRepository>();
            services.AddScoped<IAccountManageRepository, AccountManageRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();  
            
            services.AddScoped<IProductFeedbackRepository, ProductFeedbackRepository>();
            
            services.AddScoped<IInfoPageRepository, InfoPageRepository>();
        }
    }
}
