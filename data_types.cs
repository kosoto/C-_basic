using System;
namespace DataTypeApp {
    class ValueType {
        static void exam() {
            bool b = true;
            char c = 'a';
            float f = 0.0f;
            double d = 0.0;
            int n = 0;
            // 해당 type의 byte 리턴
            Console.WriteLine("Size of int: {0}", sizeof(int));
            Console.ReadLine();
        }
       
    }
    class ReferenceType {
        void exam() {
            //Object Type
            Object obj = new Object();
            Object o = 100; //boxing
            int n = (int) o; //unboxing
            Console.WriteLine(obj);
            Console.WriteLine(o);
            Console.WriteLine(n);

            //Dynamic Type
            //변수에 대한 타입 검사는 런타임에 수행됨
            dynamic d = 20;

            //String Type
            String str = "Tutorials Point";           
        }
    }
    class PointerType{
        
        void exam() {
            //타입안전성과 보안을 위해 C#에서는 기본적으로
            //포인터 산술 연산을 지원하지 않는다
            //굳이 하려면 다음과 같이 해야한다.
            unsafe {
                char* cptr;
                int* iptr;
            }
        }
    }
    
}
