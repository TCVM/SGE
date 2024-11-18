using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace sge.Repositorios
{
    public class Hasheador
    {
        public static string hashear(string contra)
        {
          using(SHA256 hash = SHA256.Create())
          {
            byte[] bytes = hash.ComputeHash(Encoding.UTF8.GetBytes(contra));

            StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
          }
        }
    }
}