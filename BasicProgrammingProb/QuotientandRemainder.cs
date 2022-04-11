using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgrammingProb
{
    public class QuotientandRemainder
    {
        int Quotient = 0, Remainder = 0;
        public void ComputeQuotientandRemainder()
        {
            Console.WriteLine("Enter any number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            Quotient = num / 10;
            Remainder = num % 10;

            Console.WriteLine("Quotient of given number : " + Quotient);
            Console.WriteLine("Remainder of given number : " + Remainder);
        }
    }
}
