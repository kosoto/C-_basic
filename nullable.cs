using System;

namespace CalculatorApplication
{
    class NullablesAtShow
    {
        void exam1()
        {
            //null을 할당가능
            int? num1 = null;
            int? num2 = 45;
            //default로 0이 아니라 null
            double? num3 = new double?();
            double? num4 = 3.14157;

            bool? boolval = new bool?();

            // display the values
            Console.WriteLine("Nullables at Show: {0}, {1}, {2}, {3}", num1, num2, num3, num4);
            Console.WriteLine("A Nullable boolean value: {0}", boolval);
            Console.ReadLine();
        }
        //The Null Coalescing Operator (??)
        void exam2()
        {
            double? num1 = null;
            double? num2 = 3.14157;
            double num3;
            //num1이 null이면 오른쪽값을 할당
            //null이 아니면 num1을 할당
            num3 = num1 ?? 5.34;
            Console.WriteLine(" Value of num3: {0}", num3);

            num3 = num2 ?? 5.34;
            Console.WriteLine(" Value of num3: {0}", num3);
            Console.ReadLine();
        }
    }
}