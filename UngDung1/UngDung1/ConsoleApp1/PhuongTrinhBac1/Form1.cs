using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace PhuongTrinhBac1
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
            Console.WriteLine("X = {0}", -b / a);

        }
    }
}
