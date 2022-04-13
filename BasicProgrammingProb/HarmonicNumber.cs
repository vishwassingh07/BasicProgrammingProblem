using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgrammingProb
{
    public class HarmonicNumber
    {
        public void HarmonicSeries()
         {
            int i;
            double num;
            double result = 0.0;

            Console.WriteLine("Enter any number: ");
            num = Convert.ToInt32(Console.ReadLine());

            for ( i = 1; i <= num; i++)
            {
                Console.Write("1/{0} +",  i);
                result += 1/ (double) i;
            }
            Console.WriteLine(result);
        }

    }
}
