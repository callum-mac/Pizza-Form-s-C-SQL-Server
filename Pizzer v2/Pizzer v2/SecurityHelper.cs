using System;
using System.Security.Cryptography;

namespace Pizzer_v2
{
    class SecurityHelper
    {        public static string GenerateSalt(int nSalt)
        {
            var saltBytes = new byte[nSalt];
            using (var provider = new RNGCryptoServiceProvider())
            {
                provider.GetNonZeroBytes(saltBytes);
            }
            return Convert.ToBase64String(saltBytes);
        }
        public static string HashPassword(string password, string salt, int nIterations, int nHash)
        {
            var saltBytes = Convert.FromBase64String(salt);
            using (var rfc2898DeriveBytes = new Rfc2898DeriveBytes(password, saltBytes, nIterations))
            {
                return Convert.ToBase64String(rfc2898DeriveBytes.GetBytes(nHash));
            }
        }
        public static bool CheckPassword(string current, string checking, string salt, int iterations, int hash)
        {
            string hashedCheckingPassword = SecurityHelper.HashPassword(checking, salt, iterations, hash);
            return hashedCheckingPassword == current;
        }
    }
}
