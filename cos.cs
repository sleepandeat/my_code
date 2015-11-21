using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20151118
{
    class Program
    {
        static void Main(string[] args)
        {
            double y;
            double x, m;
            for (y = 1; y >= -1; y -= 0.1) 
            {
                m = Math.Acos(y) * 10;
                for (x = 1; x < m; x++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                for (; x < 62 - m; x++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("*");
            }
            Console.ReadKey();
        }
    }
}
