using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBank
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 30; i++)
            {
                Console.WriteLine("Hey. little pig, enter a number here:");
                Random rnd = new Random();
                double n1 = rnd.Next(1000, 1000000);
                double number2 = Math.Sqrt(n1);
                if (number2 > 1 && number2 < 300)
                {
                    double increasednum1 = number2 * 5.1;
                    Console.WriteLine("The money from today is: {0:f4}", increasednum1);
                }

                if (number2 > 301 && number2 < 600)
                {
                    double increasednum2 = number2 * 10.098;
                    Console.WriteLine("The money from today is: {0:f4}", increasednum2);
                }

                if (number2 > 601 && number2 < 999)
                {
                    double increasednum3 = number2 * 100.00001;
                    Console.WriteLine("The money from today is: {0:f4}", increasednum3);
                }
            }
        }
    }
}
