using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld
{
    internal class FlipCoin
    {
        public static void CalculatePercentage()
        {
            int headCount = 0;
            int tailCount = 0;
            double HeadPercentage;
            double TailPercentage;

            int flipcoin = Convert.ToInt32(Console.ReadLine());

            if (flipcoin > 0)
            {
                for (int i = 0; i < flipcoin; i++)
                {
                    Random random = new Random();
                    int number = random.Next(2);
                    Console.WriteLine("The random number generated is " + number);

                    //if (number == 0)
                    //{
                    //    tailCount++;
                    //}
                    //else
                    //{
                    //    headCount++;
                    //}
                    switch (number) 
                    {
                        case 0:
                            tailCount++;
                            break;
                        case 1:
                            headCount++;
                            break;
                    }
                }

                Console.WriteLine("The head count is " + headCount);
                Console.WriteLine("The tail count is " + tailCount);

                HeadPercentage = headCount * 100 / flipcoin;
                TailPercentage = tailCount * 100 / flipcoin;

                Console.WriteLine("The head % is: " + HeadPercentage + "%");
                Console.WriteLine("The tail % is: " + TailPercentage + "%");
            }
            else
            {
                Console.WriteLine("enter  a valid number");
            }
        }
    }
}
