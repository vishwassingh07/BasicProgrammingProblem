using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgrammingProb
{
    public class SwapingTwoNumbers
    {
        public void Swap()
        {
            Console.WriteLine("Enter first number : ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number : ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            num1 = num1 + num2;
            num2 = num1 - num2;
            num1 = num1 - num2;

            Console.WriteLine("After Swap num1 = " + num1);

            Console.WriteLine("After Swap num2 = " + num2);
        }
    }
}
