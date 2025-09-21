using System.Security.Cryptography;
using System.Text;

namespace APIService.Extension
{
    public static class PasswordHasher
    {
        public static string HashPassword(string password)
        {
            using (SHA512 sha512 = SHA512.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(password);
                byte[] hashBytes = sha512.ComputeHash(inputBytes);
                byte[] doubleHash = sha512.ComputeHash(hashBytes);

                StringBuilder sb = new StringBuilder();
                foreach (var b in doubleHash)
                {
                    sb.Append(b.ToString("x2"));
                }

                return sb.ToString(); 
            }
        }

    }
}
