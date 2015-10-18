using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 天数计算器
{
    class Program
    {
        static void Main(string[] args)
        {
            int startYear = 0, startMonth = 0, startDay = 0;
            int finalYear = 0, finalMonth = 0, finalDay = 0;
            int days = 0;
            int i = 0;
            int result = 0;
            bool flag;
            #region 输入数据
        input:
            Console.WriteLine("输入起始的年份");
            flag = true;
            while (flag)
            {
                try
                {
                    startYear = Convert.ToInt32(Console.ReadLine());
                    flag = false;
                }
                catch
                {
                    Console.WriteLine("输入错误，请重新输入年份");
                }
            }
            Console.WriteLine("输入起始的月份");
            flag = true;
            while (flag)
            {
                try
                {
                    startMonth = Convert.ToInt32(Console.ReadLine());
                    flag = false;
                }
                catch
                {
                    Console.WriteLine("输入错误，请重新输入月份");
                }
                if(startMonth<0||startMonth>12)
                {
                    flag = true;
                    Console.WriteLine("输入错误，请重新输入月份");
                }
            }
            Console.WriteLine("输入起始的日期");
            flag = true;
            while (flag)
            {
                try
                {
                    startDay = Convert.ToInt32(Console.ReadLine());
                    flag = false;
                }
                catch
                {
                    Console.WriteLine("输入错误，请重新输入日期");
                }
                if((startMonth%2!=0&&startMonth<8)||(startMonth%2==0&&startMonth>7))
                {
                    days = 31;
                    if(startDay<0||startDay>days)
                    {
                        flag = true;
                        Console.WriteLine("输入错误，请重新输入日期");
                    }
                }
                else if(startMonth==2)
                {
                    if(startYear%4==0)
                    {
                        if(startYear%100==0)
                        {
                            if(startYear%400==0)
                            {
                                days = 29;
                            }
                            else
                            {
                                days = 28;
                            }
                        }
                        else
                        {
                            days = 29;
                        }
                    }
                    else
                    {
                        days = 28;
                    }
                    if(startDay<0||startDay>days)
                    {
                        flag = true;
                        Console.WriteLine("输入错误，请重新输入日期");
                    }
                }
                else
                {
                    days = 30;
                    if(startDay<0||startDay>days)
                    {
                        flag = true;
                        Console.WriteLine("输入错误，请重新输入日期");
                    }
                }
            }
            Console.WriteLine("输入终止的年份");
            flag = true;
            while (flag)
            {
                try
                {
                    finalYear = Convert.ToInt32(Console.ReadLine());
                    flag = false;
                }
                catch
                {
                    Console.WriteLine("输入错误，请重新输入年份");
                }
            }
            Console.WriteLine("输入终止的月份");
            flag = true;
            while (flag)
            {
                try
                {
                    finalMonth = Convert.ToInt32(Console.ReadLine());
                    flag = false;
                }
                catch
                {
                    Console.WriteLine("输入错误，请重新输入月份");
                }
                if(finalMonth<0||finalMonth>12)
                {
                    flag = true;
                    Console.WriteLine("输入错误，请重新输入月份");
                }
            }
            Console.WriteLine("输入终止的日期");
            flag = true;
            while (flag)
            {
                try
                {
                    finalDay = Convert.ToInt32(Console.ReadLine());
                    flag = false;
                }
                catch
                {
                    Console.WriteLine("输入错误，请重新输入日期");
                }
                if((finalMonth%2!=0&&finalMonth<8)||(finalMonth%2==0&&finalMonth>7))
                {
                    days = 31;
                    if(finalDay<0||finalDay>days)
                    {
                        flag = true;
                        Console.WriteLine("输入错误，请重新输入日期");
                    }
                }
                else if(finalMonth==2)
                {
                    if (finalYear % 4 == 0)
                    {
                        if (finalYear % 100 == 0)
                        {
                            if (finalYear % 400 == 0)
                            {
                                days = 29;
                            }
                            else
                            {
                                days = 28;
                            }
                        }
                        else
                        {
                            days = 29;
                        }
                    }
                    else
                    {
                        days = 28;
                    }
                    if(finalDay<0||finalDay>days)
                    {
                        flag = true;
                        Console.WriteLine("输入错误，请重新输入日期");
                    }
                }
                else
                {
                    days = 30;
                    if(finalDay<0||finalDay>days)
                    {
                        flag = true;
                        Console.WriteLine("输入错误，请重新输入日期");
                    }
                }
            }
            #endregion
            #region 检验输入的日期
            if ((finalYear-startYear)<0)
            {
                Console.WriteLine("倒着数可不行，请重新输入");
                goto input;
            }
            else if(finalYear-startYear==0)
            {
                if(finalMonth-startMonth<0)
                {
                    Console.WriteLine("倒着数可不行，请重新输入");
                    goto input;
                }
                else if(finalMonth-startMonth==0)
                {
                    if(finalDay-startDay<0)
                    {
                        Console.WriteLine("倒着数可不行，请重新输入");
                        goto input;
                    }
                }
            }
            #endregion
            #region 计算
            //计算每个年份是否是闰年，flag=true为闰年，false不是闰年
            for (i = startYear+1; i <= finalYear; i++)
            {
                if (i % 4 == 0)
                {
                    if (i % 100 == 0)
                    {
                        if (i % 400 == 0)
                        {
                            flag = true;
                        }
                        else
                        {
                            flag = false;
                        }
                    }
                    else
                    {
                        flag = true;
                    }
                }
                else
                {
                    flag = false;
                }
                if (flag)
                {
                    result += 366;
                }
                else
                {
                    result += 365;
                }
            }
            for(i = startMonth; i > 0; i--)
            {
                if((i%2!=0&&i<8)||(i%2==0&&i>7))//大小月的判断
                {
                    result -= 31;
                }
                else if(i==2)
                {
                    if(flag)
                    {
                        result -= 29;
                    }
                    else
                    {
                        result -= 28;
                    }
                }
                else
                {
                    result -= 30;
                }
            }
            for (i = finalMonth; i > 0; i--)
            {
                if ((i % 2 != 0 && i < 8) || (i % 2 == 0 && i > 7))
                {
                    result += 31;
                }
                else if (i == 2)
                {
                    if (flag)
                    {
                        result += 29;
                    }
                    else
                    {
                        result += 28;
                    }
                }
                else
                {
                    result += 30;
                }
            }
            result += finalDay;
            result -= startDay;
            #endregion
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
