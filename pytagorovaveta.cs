using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;

            Console.WriteLine("Napiš délku strany A");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Napiš délku strany B");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Napiš délku strany C");
            c = double.Parse(Console.ReadLine());

            if (a > c)
            {
                double tmp = c;
                c = a;
                a = tmp;
            }
            if (b > c)
            {
                double tmp = c;
                c = b;
                b = tmp;
            }


            if (c*c == (a * a + b * b))
            {
                Console.WriteLine("Trojúhelník je pravoúhlý");
            }

            else if (c*c != (a * a + b * b))

            {
                Console.WriteLine("Trojúhelník není pravoúhlý");
            }


            Console.ReadKey();




        }
    }
}
