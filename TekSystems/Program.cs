using System;
using System.Text;

namespace TekSystems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("8: " + Is2Power(8));
            Console.WriteLine("9: " + Is2Power(9));
            Console.WriteLine("64: " + Is2Power(64));
            Console.WriteLine("128: " + Is2Power(128));
            Console.WriteLine("Hej på dej!!!" + Reverse("Hej på dej!!!"));
            Console.WriteLine("Hej på dej!!!" + Replicate("Hej på dej!!!", 7));
            PrintOddNumbers(100);
            Console.ReadKey();
        }
        static bool Is2Power(ulong number)
        {
            return (number & (number - 1)) == 0;
        }

        static string Reverse(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        static string Replicate(string input, int cnt)
        {
            return new StringBuilder().Insert(0, input, cnt).ToString();
        }

        static void PrintOddNumbers(int limit)
        {
            Console.Write("Odd values upp to {0} are: ", limit);
            int i = 0;
            do
            {
                if (i % 2 != 0)
                {
                    Console.Write(" {0}, ", i);
                }

                i++;
            } while (i <100);
        }
    }
}
