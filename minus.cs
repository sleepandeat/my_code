using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20150213
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            while (true)
            {
                a = 0;
                b = 0;
                while (a < 1 || a > 9 || b < 1 || b > 9)
                {
                    bool flag = true;
                    while (flag)
                    {
                        try
                        {
                            a = Convert.ToInt32(Console.ReadLine());
                            b = Convert.ToInt32(Console.ReadLine());
                            flag = false;
                        }
                        catch
                        {
                            Console.WriteLine("输入错误，请重新输入");
                        }
                    }
                }
                if (a >= b)
                {
                    Console.WriteLine(a - b);
                }
                else
                {
                    Console.WriteLine("No");
                }
            }
        }
    }
}
