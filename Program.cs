using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //initialize the variables for the first three numbers of the sequence and the sum.
            //Sum starts at 2 since 2 is skipped by the loop
            int i = 1, j = 2, k = i+j;
            int sum = 2;

            //Loops through all variables of the sequence; uses i and j to keep track of previous terms and k as the current term.
            for (;k < 4000000; k = i+j)
            {
                if (k % 2 == 0) sum += k;
                i = j; j=k;
            }

            //Prints result
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
