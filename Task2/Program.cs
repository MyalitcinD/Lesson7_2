using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void GetCubeParams(double a, out double p, out double v)
        {
            p = a * a * 6;
            v = a * a * a;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину ребра куба");
            double a = Convert.ToDouble(Console.ReadLine());
            double v, p;
            GetCubeParams(a, out p, out v);
            Console.WriteLine("Объем куба = {0:f3}, площадь поверхности куба = {1:f3}", v, p);
            Console.ReadKey();

        }
    }
}
