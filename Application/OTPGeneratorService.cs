using System;
using System.Runtime.Caching;
using System.Security.Cryptography;

namespace MCISBCWebApp.Application
{

    public class OTPGeneratorService
    {
        private static readonly MemoryCache _cache = MemoryCache.Default;

        public static string GenerateAndStoreOtp(string phoneNumber, int otpLength = 5)
        {
            string otp = GenerateOtp(otpLength);
            CacheItemPolicy policy = new CacheItemPolicy
            {
                AbsoluteExpiration = DateTimeOffset.Now.AddMinutes(5) // OTP valid for 5 minutes
            };
            _cache.Set(phoneNumber, otp, policy);
            return otp;
        }

        public static bool ValidateOtp(string phoneNumber, string otp)
        {
            if (_cache.Contains(phoneNumber))
            {
                string cachedOtp = _cache.Get(phoneNumber) as string;
                if (cachedOtp == otp)
                {
                    _cache.Remove(phoneNumber); // OTP is valid, remove it from cache
                    return true;
                }
            }
            return false;
        }

        public static string GenerateOtp(int length = 5)
        {
            using (var rng = new RNGCryptoServiceProvider())
            {
                var otp = new byte[length];
                rng.GetBytes(otp);
                var otpChars = new char[length];
                for (int i = 0; i < length; i++)
                {
                    otpChars[i] = (char)('0' + (otp[i] % 10));
                }
                return new string(otpChars);
            }
        }
    }

}
