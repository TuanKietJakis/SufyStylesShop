using BussinessObject.DTO.Product;
using BussinessObject.Model;
using Repositories.IRepository;

namespace APIService.Service
{
    public class ProductFeedbackService
    {
        private readonly IProductFeedbackRepository _repository;

        public ProductFeedbackService(IProductFeedbackRepository repository)
        {
            _repository = repository;
        }

        public async Task<bool> CreateFeedback(Guid productId, Guid userId, string content, int rating)
        {
       
            bool hasPurchased = await _repository.HasPurchasedSuccess(userId, productId);
            if (!hasPurchased)
            {
                throw new ArgumentException("User has not purchased this product or order is not completed.");
            }

            var feedback = new ProductFeedback
            {
                ProductFeedbackId = Guid.NewGuid(),
                ProductId = productId,
                UserId = userId,
                Content = content,
                Rating = rating,
                CreatedDate = DateTime.UtcNow,
                IsDeleted = false,
                IsReported = false
            };

            await _repository.AddFeedback(feedback);
            return true;
        }


        public async Task<bool> UpdateFeedbackUser(Guid feedbackId, string content, int rating,Guid userId)
        {
            var feedback = await _repository.GetFeedbackById(feedbackId);

            if (feedback == null || userId != feedback.UserId)
            {
                throw new ArgumentException("Feedback not found.");
            }   
        
            feedback.Content = content;
            feedback.Rating = rating;

            await _repository.UpdateFeedback(feedback);

            return true;
        }
        public async Task<bool> UpdateFeedbackAdmin(Guid feedbackId, string content, int rating, bool isFinished)
        {
            var feedback = await _repository.GetFeedbackById(feedbackId);

            if (feedback == null)
            {
                throw new ArgumentException("Feedback not found.");
            }   

            feedback.Content = content;
            feedback.Rating = rating;
            feedback.IsFinished = isFinished;

            await _repository.UpdateFeedback(feedback);

            return true;
        }
       

        public async Task<List<FeedbackDto>> GetAllFeedbacks()
        {
            var feedbackList = await _repository.GetAllFeedbacks();

            return feedbackList.Select(f => new FeedbackDto
            {
                ProductFeedbackId = f.ProductFeedbackId,
                ProductName = f.Product?.ProductName ?? "Unknown",
                ProfileName = f.User?.ProfileName ?? "Anonymous",
                Content = f.Content,
                Rating = f.Rating,
                CreatedDate = f.CreatedDate,
                IsReported = f.IsReported
            }).ToList();
        }

        public async Task<FeedbackDto?> GetFeedbackByProductAndUser(Guid productId, Guid userId)
        {
            var feedback = await _repository.GetFeedbackByProductAndUser(productId, userId);

            if (feedback == null)
            {
                return null;
            }

            return new FeedbackDto
            {
                ProductFeedbackId = feedback.ProductFeedbackId,
                ProductId = feedback.ProductId,
                UserId = feedback.UserId,
                ProductName = feedback.Product?.ProductName ?? "Unknown",
                ProfileName = feedback.User?.ProfileName ?? "Anonymous",
                Content = feedback.Content,
                Rating = feedback.Rating,
                CreatedDate = feedback.CreatedDate,
                IsReported = feedback.IsReported
            };
        } 
        public async Task<FeedbackDto?> GetFeedbackByUser(Guid userId)
        {
            var feedback = await _repository.GetFeedbackByUser(userId);

            if (feedback == null)
            {
                return null;
            }

            return new FeedbackDto
            {
                ProductFeedbackId = feedback.ProductFeedbackId,
                ProductId = feedback.ProductId,
                UserId = feedback.UserId,
                ProductName = feedback.Product?.ProductName ?? "Unknown",
                ProfileName = feedback.User?.ProfileName ?? "Anonymous",
                Content = feedback.Content,
                Rating = feedback.Rating,
                CreatedDate = feedback.CreatedDate,
                IsReported = feedback.IsReported
            };
        }


    }
}
