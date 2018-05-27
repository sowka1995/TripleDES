using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DES
{
    class Program
    {
        public static void Main(string[] args)
        {
            string inputHex = "123456ABCD132536"; 
            string keyHex = "A2BB09182736CCDDAABE09182736CA992AABB09182936CCDA";

            string cipher = TripleDES.Encrypt(keyHex, inputHex);
            Console.WriteLine(cipher);

            string decrypted = TripleDES.Decrypt(keyHex, cipher);
            Console.WriteLine(decrypted);

            Console.ReadKey();
        }
    }
}
