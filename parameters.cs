//참고 사이트
//http://jeong-pro.tistory.com/53
using System;

namespace CalculatorApplication
{
    class NumberManipulator
    {
        public void swap(ref int x, ref int y)
        {
            int temp;

            temp = x; /* save the value of x */
            x = y;    /* put y into x */
            y = temp; /* put temp into y */
        }
        static void _ref(string[] args)
        {
            NumberManipulator n = new NumberManipulator();

            /* local variable definition */
            int a = 100;
            int b = 200;

            Console.WriteLine("Before swap, value of a : {0}", a);
            Console.WriteLine("Before swap, value of b : {0}", b);

            /* calling a function to swap the values */
            n.swap(ref a, ref b);

            Console.WriteLine("After swap, value of a : {0}", a);
            Console.WriteLine("After swap, value of b : {0}", b);

            Console.ReadLine();
        }
        public void getValue(out int x)
        {
            int temp = 5;
            x = temp;
        }
        static void _out(string[] args)
        {
            NumberManipulator n = new NumberManipulator();

            /* local variable definition */
            int a = 100;

            Console.WriteLine("Before method call, value of a : {0}", a);

            /* calling a function to get the value */
            n.getValue(out a);

            Console.WriteLine("After method call, value of a : {0}", a);
            Console.ReadLine();
        }
        void _tryparse()
        {   //캐스팅을 시도하고 성공하면 n에 값을 리턴
            //실패하면 false 리턴
            int n;
            if (int.TryParse("123456", out n)==true)
            {
                Console.WriteLine(n); // 123456
            }

            double d;
            if (double.TryParse("12e3", out d) == true)
            {
                Console.WriteLine(d); //12000
            }

            bool b;
            if (bool.TryParse("true", out b) == true)
            {
                Console.WriteLine(b);
            }
        }
    }
   
}