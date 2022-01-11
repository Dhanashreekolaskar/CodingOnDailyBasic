using System;

namespace Delegate
{

    public delegate void Shree(string msg);

    class A
    {
        public static void Amazon(string message)
        {
            Console.WriteLine("Class A MethodA called:" + message);
        }

    }

    class B
    {
        public static void Flipkart(string message)
        {
            Console.WriteLine("Class B Method B:" + message);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Shree del = A.Amazon;
            //del("Hiiiiiiii");

            //del = B.Flipkart;
            //del("Hello");

            //del = (string msg) => Console.WriteLine("Lambda EXP:" + msg);
            //del("Lambda da da da");

            //......delegate as a parameter 

            static void InvokeDelegate(Shree del)
            {
                del("Hello Shree");
            }
            Shree del = A.Amazon;
            InvokeDelegate(del);

            del = B.Flipkart;
            InvokeDelegate(del);

            del = (string msg) => Console.WriteLine("Lambda is cool:" +msg);
            InvokeDelegate(del);

            
        }
    }
}
