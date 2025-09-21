using APIService.Extension;
using BussinessObject.DTO.Authentication;
using BussinessObject.Models;
using Microsoft.IdentityModel.Tokens;
using Repositories.IRepository;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace APIService.Service
{
    public class AuthenService
    {
        private readonly IAuthenticationRepository _authRepo;
        private readonly IConfiguration _configuration;

        public AuthenService(IAuthenticationRepository authRepo, IConfiguration configuration)
        {
            _authRepo = authRepo;
            _configuration = configuration;
        }

        public async Task<LoginResult?> Login(string email, string password)
        {
            string hashedPassword = PasswordHasher.HashPassword(password);
            Console.WriteLine("PassLogin " + hashedPassword);

            var user = await _authRepo.LoginUser(email, hashedPassword);
            if (user != null)
            {
                if (user.IsBanned)
                {
                    throw new Exception($"The account is banned by reason is {user.ReasonBan}");
                }

                return new LoginResult
                {
                    Token = GenerateJwtToken(user.UserId.ToString(), user.Role.RoleName),
                    Role = user.Role.RoleName,
                    Id = user.UserId.ToString()
                };
            }


            return null;
        }

        public async Task<LoginResult> GoogleLogin(string email, string image)
        {
            if (!email.Contains('@'))
            {
                throw new Exception("Invalid email format.");
            }

            var user = await _authRepo.FindUserByEmail(email);
         
            if (user == null)
            {
                string username;
                do
                {
                    username = email.Split('@')[0] + Guid.NewGuid().ToString("N").Substring(0, 8);
                }
                while (await _authRepo.IsUsernameExist(username));
                user = new User
                {
                    UserId = Guid.NewGuid(),
                    Email = email,
                    UrlImage = image,
                    Username = username, 
                    RoleId = await _authRepo.GetDefaultUserRoleId(), 
                    CreatedDate = DateTime.UtcNow,
                    IsDeleted = false,
                    IsBanned = false,
                 
                };

                await _authRepo.CreateUser(user);
            }
            else if (user.IsBanned)
            {
                throw new Exception($"The account is banned by reason: {user.ReasonBan}");
            }

            var token = GenerateJwtToken(user.UserId.ToString(), user.Role.RoleName);

            return new LoginResult
            {
                Token = token,
                Id = user.UserId.ToString(),
                Role = user.Role.RoleName
            };
        }

       
        private string GenerateJwtToken(string userId, string role)
        {
            var claims = new[]
            {
            new Claim("userId", userId), 
            new Claim(ClaimTypes.Role, role),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
    };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: _configuration["Jwt:Issuer"],
                audience: _configuration["Jwt:Audience"],
                claims: claims,
                expires: DateTime.UtcNow.AddHours(int.Parse(_configuration["Jwt:ExpireHours"])),
                signingCredentials: creds
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
