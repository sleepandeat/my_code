using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            for(i=1;i<10;i++)
            {
                for(j=1;j<10;j++)
                {
                    Console.Write("{0}*{1}={2}\t",i,j,i*j);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}