using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetweenSearchMethodCSharp
{
    class Program
    {
        static double Fun(double x)
        {
            return Math.Pow((2 * Math.Pow((x + 2), 2) * (1 - x)), (1.0/3) );
        }
        static void Main(string[] args)
        {
            double a = -3;
            double b = -1;
            double x, y, step, x0, x1, f0, f1, eps;
            eps = 0.001;
            step = (b - a) / 4;
            x0 = a;
            f0 = Fun(x0);

        next1:
            x1 = x0 + step;
            f1 = Fun(x1);

            if (f0 >= f1)
            {
                x0 = x1;
                f0 = f1;
                if (a <= x0 && x0 <= b)
                    goto next1;
            }

            if (Math.Abs(step) <= eps)
            {
                x = x0;
                y = Fun(x0);
            }
            else
            {
                x0 = x1;
                f0 = f1;
                step = -step / 4;
                goto next1;
            }

            Console.WriteLine("Точка минимума: " + x);
            Console.WriteLine("Минимальное значение функции: " + y);
            Console.ReadKey();
        }
    }
}
