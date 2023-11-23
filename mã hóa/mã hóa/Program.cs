using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace mã_hóa
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "duykhanh141196";
            string encode = Base64Encode(MD5Hash(password));
            string encode1 = MD5Hash(Base64Encode(password)); //ưu tiên
            
            Console.WriteLine();
            Console.WriteLine(encode);
            Console.WriteLine(encode1);
            Console.ReadKey();
        }
        public static string Base64Encode(string plainText)
        { var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }
        public static string MD5Hash(string input)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }

      

    }
}
