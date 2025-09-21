using BussinessObject.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.IRepository
{
    public interface IProductFeedbackRepository
    {
        Task AddFeedback(ProductFeedback feedback);
        Task<bool> ProductExist(Guid productId);
        Task<bool> UserExist(Guid userId);
        Task<ProductFeedback> GetFeedbackById(Guid feedbackId);
        Task UpdateFeedback(ProductFeedback feedback);

        Task<List<ProductFeedback>> GetAllFeedbacks();
        Task<bool> HasPurchasedSuccess(Guid userId, Guid productId);
        Task<ProductFeedback?> GetFeedbackByProductAndUser(Guid productId, Guid userId); 
        Task<ProductFeedback?> GetFeedbackByUser(Guid userId);
    }
}
