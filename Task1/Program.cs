using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static double GetArea(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p*(p-a)*(p-b)*(p-c));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стороны первого треугольника");
            double a1 = Convert.ToDouble(Console.ReadLine());
            double b1 = Convert.ToDouble(Console.ReadLine());
            double c1 = Convert.ToDouble(Console.ReadLine());
            double z1 = GetArea(a1, b1,c1);
            Console.WriteLine("Введите стороны второго треугольника");
            double a2 = Convert.ToDouble(Console.ReadLine());
            double b2 = Convert.ToDouble(Console.ReadLine());
            double c2 = Convert.ToDouble(Console.ReadLine());
            double z2 = GetArea(a2, b2, c2);
            if(z1 > z2) {
                Console.WriteLine("Площадь первого больше");
            }
            else if(z2 > z1) {
                Console.WriteLine("Площадь второго больше");
            }
            else {
                Console.WriteLine("Площади равны");
            }
            //Console.WriteLine("{0:f2} {1:f2}",z1,z2);
            Console.ReadKey();
        }
    }
}
