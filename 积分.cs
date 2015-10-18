using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20151017
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y = 0;
            double lb = 0.1, ub = 0;
            bool flag = true;
            while (lb > ub)
            {
                while (flag)
                {
                    try
                    {
                        lb = Convert.ToDouble(Console.ReadLine());
                        flag = !flag;
                    }
                    catch
                    {
                        Console.WriteLine();
                    }
                }
                flag = !flag;
                while (flag)
                {
                    try
                    {
                        ub = Convert.ToDouble(Console.ReadLine());
                        flag = !flag;
                    }
                    catch
                    {
                        Console.WriteLine();
                    }
                }
                flag = !flag;
            }
            x = lb;
            while(x<ub)
            {
                y = 0.000001 * x * x + y;//y=x*x
                x = x + 0.000001;
            }
            Console.WriteLine(y);
            Console.ReadKey();
        }
    }
}
