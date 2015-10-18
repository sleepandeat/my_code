using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _
{
    class Program
    {
        static void Main(string[] args)
        {
            for (float y = 1.5f; y > -1.5f; y -= 0.1f)
            {
                for (float x = -1.5f; x < 1.5f; x += 0.05f)
                {
                    float a = x * x + y * y - 1;
                    Console.Write(a * a * a - x * x * y * y * y <= 0.0f ? '*' : ' ');
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
