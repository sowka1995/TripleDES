using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DES
{
    public static class TripleDES
    {
        private static Random random = new Random();

        public static string Encrypt(string keyHex, string strHexToEncrypt)
        {
            var subKeys = SplitKey(keyHex);

            string cipher1 = DES.Encrypt(subKeys.Item1, strHexToEncrypt);
            string cipher2 = DES.Decrypt(subKeys.Item2, cipher1);
            string cipher3 = DES.Encrypt(subKeys.Item3, cipher2);

            return cipher3;
        }

        public static string Decrypt(string keyHex, string cipher)
        {
            var subKeys = SplitKey(keyHex);

            string decrypted3 = DES.Decrypt(subKeys.Item3, cipher);
            string decrypted2 = DES.Encrypt(subKeys.Item2, decrypted3);
            string decrypted1 = DES.Decrypt(subKeys.Item1, decrypted2);

            return decrypted1;
        }

        private static Tuple<string, string, string> SplitKey(string keyHex)
        {
            string key1 = keyHex.Substring(0, 16);
            string key2 = keyHex.Substring(16, 16);
            string key3 = keyHex.Substring(32, 16);

            return new Tuple<string, string, string>(key1, key2, key3);
        }
        
        public static string GetRandomKeyHex()
        {
            string keyHex = "";
            for (int i = 0; i < 48; i++)
            {
                keyHex += random.Next(16).ToString("X");
            }
            return keyHex;
        }
    }
}
