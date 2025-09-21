using System.Security.Claims;

namespace APIService.Extension
{
    public class JwtHelper
    {
        public static Guid GetUserIdFromClaims(ClaimsPrincipal user)
        {
            var userIdClaim = user.FindFirst("userId");
            if (userIdClaim == null || !Guid.TryParse(userIdClaim.Value, out var userId))
            {
                throw new UnauthorizedAccessException("Invalid or missing userId in token.");
            }

            return userId;
        }
    }
}
