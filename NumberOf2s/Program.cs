using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a method to count the number of 2s that appear in all numbers between 0 and n (inclusive)

// Example: 25
// 2, 12,20,21,22,23,24,25

namespace NumberOf2s
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 25;

            Console.WriteLine("Number of 2s is {0}", CountNumberOf2s(n));
        }

        // Brute force approach
        static int CountNumberOf2s(int n)
        {
            int count = 0;

            for (int i = 2; i <= n; i++)
            {
                count += numberOf2s(i);
            }

            return count;
        }

        static int numberOf2s(int n)
        {
            int result = 0;

            while (n > 0)
            {
                if (n % 10 == 2)
                {
                    result++;
                }

                n = n / 10;
            }

            return result;
        }
    }
}
