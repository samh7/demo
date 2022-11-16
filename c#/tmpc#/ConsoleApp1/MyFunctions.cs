using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class MyFunctions
    {
        public static int Factorial1(int n)
        {
            int num = 1;
            for (int i = n; i > 0; i--)
            {
                num *= i;
            }
            return num;
        }

        public static int SureAddition(in int a, in int b)
        {
            return a + b;
        }
        public static void SwapNums(ref int num1, ref int num2)
        {
            int tmpNum = num1;
            num1 = num2;
            num2 = tmpNum;
        }
        public static string PrimeOrNot(int n)
        {
            int numDivisible = 0;

            for (int i = 1; i <= n; i++)
            {
                if ((n % i) == 0)
                {
                    numDivisible++;
                }
            }

            if (numDivisible == 2)
            {
                return "A Prime Number";
            }
            else
            {
                return "Not a Prime Number";
            }
        }

        public static void Fibonacci(int n)
        {
            int present = 1;
            int previous = 0;
            int tmp = 0;
            Console.Write("0, 1");
            for (int i = 0; i < n; i++)
            {
                tmp = present;
                present++;
                previous = tmp;
                Console.Write(", " + present);
            }
        }

        public static int Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            return n * Factorial(n - 1);
        }

        public static dynamic GetVwlsCntsSpcsSpcc(string words, string character)
        {
            int vwlsCount = 0;
            int cntsCount = 0;
            int spcsCount = 0;
            int spccCount = 0;
            words = words.ToLower();
            character = character.ToLower();
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] > 95 && words[i] < 123)
                {
                    if (words[i].Equals('a') || words[i].Equals('e') || words[i].Equals('i') || words[i].Equals('o') || words[i].Equals('u'))
                    {
                        vwlsCount++;
                        continue;
                    }
                    if (words[i].Equals('w') || words[i].Equals('y'))
                    {
                        continue;
                    }
                    cntsCount++;
                    continue;
                }
                if (words[i].Equals(' '))
                {
                    spcsCount++;
                    continue;
                }
                spccCount++;
            }
            if (character == "v" || character == "vowels" || character == "vowel")
            {
                return vwlsCount;
            }
            else if (character == "c" || character == "consonants" || character == "consonant")
            {
                return cntsCount;
            }
            else if (character == "s" || character == "space")
            {
                return spcsCount;
            }
            else if (character == "sc" || character == "*")
            {
                return spccCount;
            }
            else if (character == "all" || character == "a")
            {
                return $"Consonants: {cntsCount}\nVowels: {vwlsCount}\nSpaces: {spcsCount}\nSpecial Characters: {spccCount}\n";
            }
            else
            {
                return -1;
            }
        }
        public static int wordCount(string words)
        {
            string[] sentence = words.Split(' ');
            int count = 0;
            foreach (var word in sentence)
            {
                count++;
            }
            return count;
        }
    }
}
