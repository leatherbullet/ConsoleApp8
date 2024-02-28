using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int minValue = 50;
            int maxValue = 150;
            int randomNumber = random.Next(10, 25);
            int multepleRandomNumber = 0;
            Console.WriteLine("случайное число " + randomNumber);

            for (int i = minValue; i <= maxValue ; i += randomNumber)
            {
                i += multepleRandomNumber;
                Console.WriteLine(i);
            }
        }
    }
}
