using BussinessObject.Services.Mail;

namespace APIService.Extension
{
    public static class OtpStorage
    {
        private static readonly Dictionary<string, OtpInfo> OtpDictionary = new();

        public static bool StoreOtp(string email, string otp)
        {
            OtpDictionary[email] = new OtpInfo
            {
                Otp = otp,
                Expiration = DateTime.UtcNow.AddMinutes(1)
            };
            return true; 
        }

        public static OtpInfo GetOtp(string email)
        {
            OtpDictionary.TryGetValue(email, out var otpInfo);
            return otpInfo;
        }

        public static bool ClearOtp(string email)
        {
            return OtpDictionary.Remove(email); 
        }
    }
}
