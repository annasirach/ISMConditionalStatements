using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinConsoleTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть x = ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введіть y = ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введіть z = ");
            double z = Convert.ToDouble(Console.ReadLine());
            double a = 2 * Math.Cos(x * x) - 0.5;
            double b = 0.5 + Math.Sin(Math.Pow(y, (2 - z)));
            double c = (z * z) / (7 - z / 3);
            double r = a / b + c;
            Console.WriteLine("Результат = {0:F2}", r);
        }
    }
}
