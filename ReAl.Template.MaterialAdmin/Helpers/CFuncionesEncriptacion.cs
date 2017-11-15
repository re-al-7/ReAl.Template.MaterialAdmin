using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Test.CoreMvc.Helpers
{
    public class CFuncionesEncriptacion
    {
        public static string generarMD5(string cadena)
        {
            Byte[] originalBytes;
            Byte[] encodedBytes;
            MD5CryptoServiceProvider md5;

            md5 = new MD5CryptoServiceProvider();
            originalBytes = ASCIIEncoding.Default.GetBytes(cadena);
            encodedBytes = md5.ComputeHash(originalBytes);

            return BitConverter.ToString(encodedBytes).Replace("-", "");
        }
    }
}
