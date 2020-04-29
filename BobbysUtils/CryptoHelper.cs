using System.Security.Cryptography;
using System.Text;

namespace BobbysUtils
{
    public static class CryptoHelper
    {
        public static string GetMd5Hash(string input)
        {
            MD5 md5Hasher = MD5.Create();

            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input));

            StringBuilder strBuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                strBuilder.Append(data[i].ToString("x2"));
            }

            return strBuilder.ToString();
        }
    }
}
