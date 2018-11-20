/*
 이름 붙혀진 정수형 상수들의 집합
 */
using System;

namespace EnumApplication
{
    class EnumProgram
    {
        enum Days { Sun, Mon, tue, Wed, thu, Fri, Sat };

        static void Main(string[] args)
        {
            int WeekdayStart = (int)Days.Mon;
            int WeekdayEnd = (int)Days.Fri;

            Console.WriteLine("Monday: {0}", WeekdayStart);//Monday: 1
            Console.WriteLine("Friday: {0}", WeekdayEnd);//Friday: 5
            Console.ReadKey();
        }
    }
}