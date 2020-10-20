using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTB1
{
    class Program
    {
        static void Main(string[] args)
        {
            {
    class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("PTB1");
                Console.WriteLine("Nhap so a");
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine("Nhap so b");
                double b = double.Parse(Console.ReadLine());
                // voi a = 0
                if (a == 0)
                {
                    //kiem tra b == 0?
                    if (b == 0)
                    {
                        //b==0
                        Console.WriteLine("Vo so nghiem");
                    }
                    else
                    {

                        Console.WriteLine("Vo nghiem");
                    }

                }



                else
                {
                    //void a != 0
                    Console.WriteLine("X = {0}", -b / a);

                }

            }
        }

    }

}

