using System;

namespace Overloading
{
    public class Book
    {
        //method name same wit diff param/diff type
        //no same name as a class name
        //in same class overloading possible
        public void Get()
        {
            Console.WriteLine("5AM");
        }

        public void Get(int a)
        {
            Console.WriteLine("Param"+a);

        }

        //order of param same
        //diff type
        public void Get(string a)
        {

        }


        }

    public class Novel : Book
    {
       
        public void Get()
        {
            Console.WriteLine("abc");

        }

        public void Put()
        {
            Console.WriteLine("Put");

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            book.Get();

            Novel novel = new Novel();
            novel.Get(10);


          
        }
    }
}
