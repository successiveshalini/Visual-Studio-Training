using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInterestcalculater
{
    public class Program
    {
        static void Main(string[] args)
        {
            double si, p, t, r;
            Console.WriteLine("Enter the principle");
            p = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the time");
            t = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the rate");
            r = double.Parse(Console.ReadLine());

            si = (p * t * r) / 100;
            Console.WriteLine(si);
            Console.ReadKey();  
            //hhhhhhhhhhhhhhhhhhhhhhhhhhh
        }
    }
}
