using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace NesopsRTC2.Utils
{
    public class NesopsUtil
    {
        public static string GetRandomStringNumber(int lenght)
        {
            Random random = new Random();
            const string chars = "0123456789";
            return new string(Enumerable.Range(1, lenght).Select(s => chars[random.Next(chars.Length)]).ToArray());
        }
        public static string GetRandomString(int lenght)
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Range(1, lenght).Select(s => chars[random.Next(chars.Length)]).ToArray());
        }
        public static string GenerateMD5FromString(string str)
        {
            string result = "";
            using (MD5 hash = MD5.Create())
            {
                result = String.Join
                (
                    "",
                    from ba in hash.ComputeHash
                    (
                        Encoding.UTF8.GetBytes(str)
                    )
                    select ba.ToString("x2")
                );
            }
            return result;
        }
    }
}
