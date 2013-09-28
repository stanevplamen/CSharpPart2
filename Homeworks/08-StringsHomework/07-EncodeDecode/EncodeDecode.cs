using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EncodingDecodingOfString
{
    class EncodeDecode
    {
        private static string password = "aabbbcccc21324";

        private static string KeyGenerate()
        {
            int keyLength = 8;
            Random rnd = new Random();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < keyLength; i++)
            {
                //Thread.Sleep(3);
                int random = rnd.Next(48, 122);
                char keyChar = (char)random;
                sb.Append(keyChar);
            }
            string keyStr = Convert.ToString(sb);
            return keyStr;
        }
        private static string Encode(string key)
        {
            short[] charNumber = new short[password.Length];
            short[] keyNumber = new short[password.Length];
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < password.Length; i++)
            {
                int j = i;
                if (j >= key.Length)
                {
                    j = j % key.Length;
                }
                charNumber[i] = (short)password[i];
                keyNumber[i] = (short)key[j];

                int result = charNumber[i] ^ keyNumber[i];
                char resultChar = (char)result;
                sb.Append(resultChar);
            }
            string resultStr = Convert.ToString(sb);
            return resultStr;
        }

        private static string Decode(string key, string encode)
        {
            short[] charNumber = new short[encode.Length];
            short[] keyNumber = new short[encode.Length];
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < encode.Length; i++)
            {
                int j = i;
                if (j >= key.Length)
                {
                    j = j % key.Length;
                }
                charNumber[i] = (short)encode[i];
                keyNumber[i] = (short)key[j];

                int result = charNumber[i] ^ keyNumber[i];
                char resultChar = (char)result;
                sb.Append(resultChar);
            }
            string resultStr = Convert.ToString(sb);
            return resultStr;
        }

        static void Main(string[] args)
        {
            string key = KeyGenerate();
            string encode = Encode(key);
            string decode = Decode(key, encode);
            Console.WriteLine("The pass is: {0}", password);
            Console.WriteLine("The encoded pass is: {0}", encode);
            Console.WriteLine("The decoded pass is: {0}", decode);
            Console.WriteLine("The key is {0}", key);
        }
    }
}
