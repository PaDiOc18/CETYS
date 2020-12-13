using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

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

        public static void HORN(Window window)
        {
            window.Close();
            hotOrNot r = new hotOrNot();
            r.Owner = window.Owner;
            r.Show();
        }

        public static void Rankingwin(Window window)
        {
            window.Close();
            Ranking r = new Ranking();
            r.Owner = window.Owner;
            r.Show();
        }

        public static void Uploadwin(Window window)
        {
            window.Close();
            Upload r = new Upload();
            r.Owner = window.Owner;
            r.Show();
        }
    }
}
