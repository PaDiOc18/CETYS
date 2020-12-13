using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace final
{
    static class Utils
    {
        public static string EncryptClave(string txt)
        {
            txt += "smallchungus";
            SHA512 sha = SHA512.Create();
            byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(txt));
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                sb.Append(bytes[i].ToString("x2"));
            }
            sha.Dispose();
            return sb.ToString();
        }
    }
}
