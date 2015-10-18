using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20150207
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1
            int a;
            Console.WriteLine("请输入你的年龄：");
            while(true)
            {
                try
                {
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("你出生于{0}年",2015-a);
                    break;
                }
                catch
                {
                    Console.WriteLine("你的输入是错误的，请重新输入你的年龄：");
                }
            }
            Console.WriteLine("按任意键继续");
            Console.ReadKey();
            #endregion
        }
    }
}