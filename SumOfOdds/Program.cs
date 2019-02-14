using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfOdds
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\n\tType a number to get sum of odd numbers: "); // User inputs number to get sum of the odd numbers less than input number
            Console.Write("\t");
            Console.WriteLine("\t" + SumOfOdds(Convert.ToInt32(Console.ReadLine())));
            Console.ReadKey();
        }

        public static int SumOfOdds(int n)
        {
            int sum = 0;
            {
                for (int i = 0; i <= n; i++)
                {
                    if (i % 2 == 1)
                    {
                        sum += i;
                    }
                }return sum;
            }
        }
    }
}
