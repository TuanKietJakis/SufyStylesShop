


using Swashbuckle.AspNetCore.Annotations;
using System.Text.Json.Serialization;

namespace BussinessObject.DTO
{
    public class UserVoucherPaginationParams : PaginationParams
    {
        // Lớp Filter cho User
        public class UserFilter : UserVoucherPaginationParams
        {
            [SwaggerIgnore] // Không hiển thị trong Swagger
            public Guid? UserId { get; set; } // UserId sẽ được lấy từ token, không cần từ query string
            public bool? IsUsed { get; set; } = false;
            public bool? IsActive { get; set; } = true;
            public bool? IsAvailable { get; set; } = true;
        }

        // Lớp Filter cho Admin
        public class AdminFilter: UserVoucherPaginationParams
        {
    
        }

    }
}
