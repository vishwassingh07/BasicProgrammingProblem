using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgrammingProb
{
    public class TableOfTwo
    {
        public void Table()
        {
            Console.WriteLine("Enter any number:");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                int num = (int)Math.Pow(2, i);
                Console.WriteLine("2" + " " + "^" + " " + i + "=" + num);
            }
        }
    }
}
