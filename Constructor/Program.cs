using System;

namespace ConstructorCode
{
    public class Book
    {
        public string name; //create a variable
        public Book() //Create class Constructor
        {
            name = "Harry Potter"; //initialize value for name
        }

        //parameterize constructor
       public Book(string author, int year)
        {

            //string author1 = author;
            //int year1 = year;
            Console.WriteLine("author" + author, " year" + year);
        }


        public static void Main(string[] args)
        {
            Book book = new Book();
            Book book1 = new Book("J.K. rowling", 2);

            Console.WriteLine(book.name);
        }
    }
}