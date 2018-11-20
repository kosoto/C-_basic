using System;

namespace StringApplication
{

    class Program
    {
         void exam()
        {
            //from string literal and string concatenation
            string fname, lname;
            fname = "Rowan";
            lname = "Atkinson";

            char[] letters = { 'H', 'e', 'l', 'l', 'o' };
            string[] sarray = { "Hello", "From", "Tutorials", "Point" };

            string fullname = fname + lname;
            Console.WriteLine("Full Name: {0}", fullname);//RowanAtkinson

            //by using string constructor { 'H', 'e', 'l', 'l','o' };
            string greetings = new string(letters);
            Console.WriteLine("Greetings: {0}", greetings);//Hello

            //methods returning string { "Hello", "From", "Tutorials", "Point" };
            string message = String.Join(" ", sarray);
            Console.WriteLine("Message: {0}", message);//Hello From Tutorials Point

            //formatting method to convert a value
            DateTime waiting = new DateTime(2012, 10, 10, 17, 58, 1);
            string chat = String.Format("Message sent at {0:t} on {0:D}", waiting);
            Console.WriteLine("Message: {0}", chat);//Message sent at 5:58 PM on Wednesday, October 10, 2012

            string str1 = "This is test";
            string str2 = "This is text";
            if (String.Compare(str1, str2) == 0)
            {
                Console.WriteLine(str1 + " and " + str2 + " are equal.");
            }
            else
            {
                Console.WriteLine(str1 + " and " + str2 + " are not equal.");//이것이 출력
            }
            if (str1.Contains("test"))
            {
                Console.WriteLine("The sequence 'test' was found.");
            }

            //substring
            string str = "Last night I dreamt of San Pedro";
            string substr = str.Substring(23);
            Console.WriteLine(substr); //San Pedro
        }
    }
}