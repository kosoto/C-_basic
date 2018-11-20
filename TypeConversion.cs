using System;

namespace TypeConversionApplication
{
    class ExplicitConversion
    {
        void exam()
        {
            double d = 5673.74;
            int i;
                        
            // cast double to int.
            i = (int)d;
            Console.WriteLine(i);
            Console.WriteLine(i.ToString());
            Console.ReadKey();

            bool b = Convert.ToBoolean("true");
            Console.WriteLine(b);
            int num;
            num = Convert.ToInt32(Console.ReadLine());
        }
    }
}