using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 优化方案
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("输入你检验的数（大于1的正整数）");
            int n=0,i,j;
            bool flag = true;
            while (flag)
            {
                try
                {
                    n = Convert.ToInt32(Console.ReadLine());
                    flag = false;
                }
                catch
                {
                    Console.WriteLine("让你输入正整数，你输的啥玩意，重来！");
                }
            }
            for (i = 2, j = 2; i < n - 1;i++ )
            {
                if (n % i == 0)
                {
                    Console.Write(i + "\t");
                }
                else
                {
                    j++;
                }
            }
            if(n==j+1)
            {
                Console.WriteLine("{0}是素数",n);
            }
            else
            {
                Console.WriteLine("是{0}的全部因数，{0}不是素数",n);
            }
            Console.ReadKey();
        }
    }
}
