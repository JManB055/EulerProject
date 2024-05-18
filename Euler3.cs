using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Euler3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Initializes the variables for the largest factor and the number.
            int largestFactor = 1;
            long num = 600851475143;

            //Checks to see if 2 is a factor. If it is, it sets 2 to the largest factor and splits off from the number tree.
            if (num % 2 == 0)
            {
                largestFactor = 2;
                num /= 2;
            }

            //Loops through odd numbers (2 is the only even prime) to check if i divides the number. If it does, then i splits off of the number tree.
            //Should naturally sort prime numbers as they will be reached before any non-prime number
            for (int i = 3; i <= num; i+=2)
            {
                //Console.WriteLine(i + " " + num);
                if (num % i == 0)
                {
                    largestFactor = i;
                    num = num / i;

                    //Sets i so that the factor is checked to see if it is a duplicate, otherwise a non-prime number could be a result.
                    //Not needed for 2 as no multiples of 2 are being checked.
                    i = i - 2;
                }
            }

            Console.WriteLine(largestFactor);
            Console.ReadKey();
        }
    }
}
