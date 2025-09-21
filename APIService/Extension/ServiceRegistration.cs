using APIService.Service;
using Microsoft.Extensions.DependencyInjection;
using Repositories.Repository;
using Services.Service;
namespace APIService.Extension
{
    public static class ServiceRegistration
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<UserService>();     
            services.AddScoped<PostService>();
            services.AddScoped<EmailService>();
            services.AddScoped<PostCommentService>();
                 
            services.AddScoped<ProductService>();

            services.AddScoped<AuthenService>();
            services.AddScoped<CartService>();
            services.AddScoped<UserVoucherService>();
            services.AddScoped<AccountManageService>();
            services.AddScoped<OrderService>();
            
            services.AddScoped<ProductFeedbackService>();
        
            services.AddScoped<InfoPageService>();
        }
    }
}
