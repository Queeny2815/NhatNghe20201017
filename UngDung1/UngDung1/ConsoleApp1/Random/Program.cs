using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuDungRandom
{
    class Program
    {
        static void Main(string[] args)
        {

            Random a = new Random();
            //lay so ngau nhien 0-9
            //Console.WriteLine(a.Next(0, 9));
            Console.WriteLine("Nhap mot so bat ky");
            int duDoan = int.Parse(Console.ReadLine());
            int kq = a.Next(0, 9);
            //Console.WriteLine(kq);
            if (duDoan == kq)
            {
                Console.WriteLine("Ban da doan dung");


            }
            else
            {
                Console.WriteLine("Chuc ban may man lan sau ^^");

            }
        }
    }
}
