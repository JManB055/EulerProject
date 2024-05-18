using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler1
{
    internal class Program
    {
        //Project Euler Problem 1
        static void Main(string[] args)
        {
            //Initialize the variables for the upper limit and the total sum.
            int upperNum = 1000;
            int sum = 0;

            //Itterates through every multiple of three less than the upper limit and adds it to the sum
            for (int i = 0; i < upperNum; i += 3)
            {
                sum += i;
            }

            //Itterates through every multiple of 5 less than the upper limit and adds it to the sum.
            for (int i = 0; i < upperNum; i += 5)
            {
                //If statement to catch duplicate numbers.
                if (i % 3 == 0) continue;

                sum += i;
            }

            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
