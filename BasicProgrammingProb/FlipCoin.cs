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
            while (num > 0)
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
                num--;
            }
            double headPercentage = (headCount % 100);
            double tailPercentage = (tailCount % 100);
            Console.WriteLine("Percentage of Head :" + headPercentage);
            Console.WriteLine("Percentage of Tail : " + tailPercentage);
        }
    }
}
