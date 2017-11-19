using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int diapason = random.Next(0, 255);
            int sum = 0;
            int numbr = 0;

            do
            {
                Console.WriteLine("Enter number here:");
                int num = int.Parse(Console.ReadLine());

                if (num == 0) { Console.WriteLine("There are not even numbers in this diapason!"); }
                if (num > 0 && num < 256)
                {
                    if (num % 2 == 0) { sum += num; numbr++; }
                }
                else if (num<0 && num > 255)
                { Console.WriteLine("This numbers are not even in the diapason!"); }


            } while (true);


            
            if(sum==0)
            {
                Console.WriteLine("There are not even numbers in this diapason!");
            }

            else
            {
                int average = sum/numbr;
                Console.WriteLine("Finished!");
                Console.WriteLine("The average number is:{0}",average);
            }
            
        }

    }
}
    

