using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter option here (addition,subtraction,multiplication or division:)");
            string option = Console.ReadLine();
            Console.WriteLine("Now enter here two numbers:");
            double num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            if (option == "addition")
            {
                double sum = (num1 + num2) * 0.1;
                Console.WriteLine("The answer is:{0}", sum);
            }
            if (option == "substraction")
            {
                double maxNum = Math.Max(num1, num2);
                double minNum = Math.Min(num1, num2);
                double substraction = Math.Pow(maxNum, 2) - minNum;
                Console.WriteLine("The answer is:{0}",substraction); 
            }
            if(option=="multiplication")
            {
                double multiplication = num1 * (Math.Sqrt(num2));
                Console.WriteLine("The answer is:{0}", multiplication);
            }
            if(option=="division")
            {
                double division;
                if (num2 != 0)
                { division = num1 / num2;
                    Console.WriteLine("The answer is:{0}",division);
                }
                else Console.WriteLine("You cannot divide with zero!");
            }
        

        }
    }
}
