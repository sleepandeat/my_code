using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20150303
{
    enum Gender
    {
        male,female
    }
    class Program
    {
        static void Main(string[] args)
        {
            const double Pi = 3.14;
            Gender sex = Gender.male;
            switch(sex)
            {
                case Gender.male:
                    Console.WriteLine("你是男的");
                    break;
                case Gender.female:
                    Console.WriteLine("你是女的");
                    break;
            }
            Console.ReadKey();

        }
    }
}
