using System;

namespace StaticCode
{
    public static class Book
    {
        public static String Name = "Shree";
        public static void Get()
        {
            Console.WriteLine("hello");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Book.Get();

            Console.WriteLine("BOOK NAME IS:" + Book.Name);
        }
    }
}

