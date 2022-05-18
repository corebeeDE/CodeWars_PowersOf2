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

            List<BigInteger> output = PowersOfTwo(0);
            output.ForEach(x => Console.WriteLine(x));
            Console.WriteLine("--------------------");

            output = PowersOfTwo(4);
            output.ForEach(x => Console.WriteLine(x));
            Console.WriteLine("--------------------");

            output = PowersOfTwo(100);
            output.ForEach(x => Console.WriteLine(x));
            Console.WriteLine("--------------------");
        }

        // ----- CAVE: Solutions differ from the actual Kata since Lists are easier to handle here! ----- //

        // First solution
        public static List<BigInteger> PowersOfTwo(int n)
        {
            List<BigInteger> output = new List<BigInteger>();
            for (int ctr = 0; ctr <= n; ctr++)
            {
                BigInteger buffer = 1;

                for(int loopbuff = 0; loopbuff < ctr; loopbuff++)
                {
                    buffer *= 2;
                }

                output.Add(ctr == 0 ? 1 : buffer);
            }
            return output;
        }

        // Refactored solution
        public static List<BigInteger> PowersOfTwoRefactored(int n) => Enumerable.Range(0, n+1).Select(x => BigInteger.Pow(2, x)).ToList();
    }
}