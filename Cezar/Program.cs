using System;
using System.Collections;

namespace Cezar
{
    class Program
    {
        static void Main(string[] args)
        {

            string alph = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ-.?!0123456789";

            int n = 4;

            Console.WriteLine("Enter text for encryption:");
            string inputText = Console.ReadLine();

            Console.WriteLine("Result of encryption:");
            Console.WriteLine(TextEncryption(inputText, alph, n));

            Console.WriteLine("Result of decryption:");
            Console.WriteLine(TextDecryption(TextEncryption(inputText, alph, n), alph, n));

            Console.ReadKey();
        }

        static string TextEncryption(string inputText, string alph, int n)
        {
            int a = 2, m = alph.Length;

            string result = "";

            for (int i = 0; i < inputText.Length; i++)
                for (int j = 0; j < alph.Length; j++)
                    if (inputText[i].Equals(alph[j]))
                    {
                        result += alph[(a * j + n) % m];
                        break;
                    }

            return result;
        }

        static string TextDecryption(string inputText, string alph, int n)
        {
            int a = 41, m = alph.Length;

            string result = "";

            for (int i = 0; i < inputText.Length; i++)
                for (int j = 0; j < alph.Length; j++)
                    if (inputText[i] == alph[j])
                    {
                        result += alph[((j + m - n) * a) % m];
                            break;
                    }

                    return result;
        }
    }
}
