using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 枚举
{
    enum gender {男,女 }//简单的说就是定义一个gender的数据类型，在此命名域作用范围内，gender和bool类似
    class Program
    {
        static void Main(string[] args)
        {
            gender sex;
            sex = gender.男;
            switch(sex)
            {
                case gender.男:
                Console.WriteLine("男性");
                break;
                case gender.女:
                Console.WriteLine("女性");
                break;
            }
            Console.ReadKey();
        }
    }
}
