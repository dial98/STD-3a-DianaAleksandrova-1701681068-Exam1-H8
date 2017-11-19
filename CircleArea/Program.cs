using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            double r = random.Next(33, 187);
            r = int.Parse(Console.ReadLine());
            Console.WriteLine("The circle radius is {0}", r);
            double pi = Math.PI;
            double area = pi * r *r;
            Console.WriteLine("The circle area is {0:f2} ",area);
        }
    }
}
