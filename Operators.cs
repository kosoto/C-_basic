using System;
namespace Operators
{
    class Atrithmetic
    {
        void exam()
        {
            int a = 21;
            int b = 10;
            int c;

            c = a + b;
            Console.WriteLine("Line 1 - Value of c is {0}", c);

            c = a - b;
            Console.WriteLine("Line 2 - Value of c is {0}", c);

            c = a * b;
            Console.WriteLine("Line 3 - Value of c is {0}", c);

            c = a / b;
            Console.WriteLine("Line 4 - Value of c is {0}", c);

            c = a % b;
            Console.WriteLine("Line 5 - Value of c is {0}", c);

            c = a++;
            Console.WriteLine("Line 6 - Value of c is {0}", c);

            c = a--;
            Console.WriteLine("Line 7 - Value of c is {0}", c);
        }
    }
    class Relational
    {
        void exam()
        {
            int a = 21;
            int b = 10;

            if (a == b)
            {
                Console.WriteLine("Line 1 - a is equal to b");
            }
            else
            {
                Console.WriteLine("Line 1 - a is not equal to b");
            }

            if (a < b)
            {
                Console.WriteLine("Line 2 - a is less than b");
            }
            else
            {
                Console.WriteLine("Line 2 - a is not less than b");
            }

            if (a > b)
            {
                Console.WriteLine("Line 3 - a is greater than b");
            }
            else
            {
                Console.WriteLine("Line 3 - a is not greater than b");
            }

            /* Lets change value of a and b */
            a = 5;
            b = 20;

            if (a <= b)
            {
                Console.WriteLine("Line 4 - a is either less than or equal to  b");
            }

            if (b >= a)
            {
                Console.WriteLine("Line 5-b is either greater than or equal to b");
            }
        }
    }
    class Logical
    {
        void exam()
        {
            bool a = true;
            bool b = true;

            if (a && b)
            {
                Console.WriteLine("Line 1 - Condition is true");
            }

            if (a || b)
            {
                Console.WriteLine("Line 2 - Condition is true");
            }

            /* lets change the value of  a and b */
            a = false;
            b = true;

            if (a && b)
            {
                Console.WriteLine("Line 3 - Condition is true");
            }
            else
            {
                Console.WriteLine("Line 3 - Condition is not true");
            }

            if (!(a && b))
            {
                Console.WriteLine("Line 4 - Condition is true");
            }
        }
    }
    class Miscellaneous
    {
        void exam()
        {
            /* example of sizeof operator */
            Console.WriteLine("The size of int is {0}", sizeof(int));
            Console.WriteLine("The size of short is {0}", sizeof(short));
            Console.WriteLine("The size of double is {0}", sizeof(double));

            /* example of ternary operator */
            int a, b;
            a = 10;
            b = (a == 1) ? 20 : 30;
            Console.WriteLine("Value of b is {0}", b);

            b = (a == 10) ? 20 : 30;
            Console.WriteLine("Value of b is {0}", b);
        }
    }
}