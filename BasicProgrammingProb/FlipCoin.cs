using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgrammingProb
{
    public class FlipCoin
    {
        const double IS_HEAD = 0.5;
        int headCount = 0, tailCount = 0;
        public void Flip()
        {
            Console.WriteLine("How many flips do you want ?");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i =1; i<=num; i++)
            {
                Random random = new Random();
                double option = random.NextDouble();
                if (option > IS_HEAD)
                {
                    headCount++;
                }
                else
                {
                    tailCount++;
                }
            }
            double headPercentage = (double)(headCount*100) / num;
            double tailPercentage = (double)(tailCount*100) / num;
            Console.WriteLine("number of heads :" + headCount);
            Console.WriteLine("number of tails :" + tailCount);
            Console.WriteLine("Percentage of Head :" + headPercentage);
            Console.WriteLine("Percentage of Tail : " + tailPercentage);
        }
    }
}
