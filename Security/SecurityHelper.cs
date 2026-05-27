using System.Security.Cryptography;
using System.Text;

namespace DomestikAirline.Helpers
{
    public class SecurityHelper
    {
        public static string HashPassword(string password)
        {
            SHA256 sha = SHA256.Create();

            byte[] bytes = Encoding.UTF8.GetBytes(password);

            byte[] hash = sha.ComputeHash(bytes);

            StringBuilder sb = new StringBuilder();

            foreach (byte b in hash)
            {
                sb.Append(b.ToString("x2"));
            }

            return sb.ToString();
        }
    }
}