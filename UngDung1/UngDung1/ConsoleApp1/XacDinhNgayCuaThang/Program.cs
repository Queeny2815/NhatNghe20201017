using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XacDinhNgayCuaThang
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap Thang");
            int thang = int.Parse(Console.ReadLine());
            if (thang == 2)
            {
                // thang 2
                Console.WriteLine("Nhap Nam");



                int nam = int.Parse(Console.ReadLine());
                if (nam % 4 == 0 && nam % 100 > 0)
                {
                    Console.WriteLine("29");
                }
                else
                {
                    Console.WriteLine("28");
                }
            }
            else
            {
                // cac thang con lai
                switch (thang)
                {
                    case 1:
                        Console.WriteLine(31);
                        break;
                    case 3:
                        Console.WriteLine(31);
                        break;
                    case 4:
                        Console.WriteLine(30);
                        break;
                    case 5:
                        Console.WriteLine(31);
                        break;
                    case 6:
                        Console.WriteLine(30);
                        break;
                    case 7:
                        Console.WriteLine(31);
                        break;
                    case 8:
                        Console.WriteLine(30);
                        break;
                    case 9:
                        Console.WriteLine(30);
                        break;
                    case 10:
                        Console.WriteLine(31);
                        break;
                    case 11:
                        Console.WriteLine(30);
                        break;
                    case 12:
                        Console.WriteLine(31);
                        break;
                    default:
                        Console.WriteLine("khong Phai Thang");
                        break;

                }

            }
            Console.ReadKey();
        }
    }

}

