using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgrammingProb
{
    public class EvenOdd
    {
        public void Checking()
        {
            Console.WriteLine("Enter number to check for even or odd :");
            int num = Convert.ToInt32(Console.ReadLine());
            if ( num % 2 == 0)
            {
                Console.WriteLine("The given number is even");
            }
            else
            {
                Console.WriteLine("The given number is odd ");
            }
        }
    }
}
