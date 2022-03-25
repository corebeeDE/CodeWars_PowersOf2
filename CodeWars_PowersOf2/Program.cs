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

        public static BigInteger[] PowersOfTwo(int n)
        {
            BigInteger[] output = new BigInteger[n+1];
            for (int ctr = 0; ctr <= n; ctr++)
            {
                output[ctr] = Convert.ToInt64(Math.Pow(2, ctr));
            }
            return output;
        }
    }
}
