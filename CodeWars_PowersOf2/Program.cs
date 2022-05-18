using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars_PowersOf2
{
    class Program
    {
        static void Main()
        {
            // https://www.codewars.com/kata/57a083a57cb1f31db7000028/

            BigInteger[] output = PowersOfTwo(0);

            foreach (var item in output)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("--------------------");

            output = PowersOfTwo(1);

            foreach (var item in output)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("--------------------");

            output = PowersOfTwo(4);

            foreach (var item in output)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("--------------------");

            // Hier fliegt er - Overflow vom Double. Auslagern in ne andere Methode zur Rückgabe des Werts?
            output = PowersOfTwo(100);

            foreach (var item in output)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("--------------------");
        }

        // First solution
        public static BigInteger[] PowersOfTwo(int n)
        {
            BigInteger[] output = new BigInteger[n + 1];
            for (int ctr = 0; ctr <= n; ctr++)
            {
                BigInteger buffer = 1;

                for(int loopbuff = 0; loopbuff < ctr; loopbuff++)
                {
                    buffer *= 2;
                }

                output[ctr] = ctr == 0 ? 1 : buffer;
            }
            return output;
        }

        // Refactored solution
        public static BigInteger[] PowersOfTwoRefactored(int n) => Enumerable.Range(0, n+1).Select(x => BigInteger.Pow(2, x)).ToArray();
    }
}