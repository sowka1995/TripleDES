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
            string keyHex = DES.GetRandomKeyHex();

            string cipher = TripleDES.Encrypt(keyHex, inputHex);
            Console.WriteLine(cipher);

            string decrypted = TripleDES.Decrypt(keyHex, cipher);
            Console.WriteLine(decrypted);

            Console.ReadKey();
        }
    }
}
