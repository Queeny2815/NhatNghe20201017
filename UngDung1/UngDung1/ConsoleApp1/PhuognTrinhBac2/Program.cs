using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhuognTrinhBac2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PTB2");
            Console.WriteLine("Nhap a");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap b");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap c");
            double c = double.Parse(Console.ReadLine());
            double d = b * b - 4 * a * c;
           if (d < 0)
                Console.WriteLine("PT vo nghiem");
            else
            {
                double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                double x2 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("Nghiem La : x1={0} x2 ={1} ", x1,x2);
            }

        }
    }
}
