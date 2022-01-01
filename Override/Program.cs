using System;

namespace Override
{

    //baseclass
    public class Dog
    {
        //method name same wit virtual and override key
        //class should be inherit
        //in diff class overriding possible
        public virtual void  Food()
        {
            Console.WriteLine("PEDIGREE");
        }
    }


    //derived class
    public class Cat : Dog
    {
        public override void  Food()
        {
            Console.WriteLine("WISKAS");

        }
    }
    class Program
    {
        static void Main(string[] args)
        {



            //using same object
            //by using override and virtual key it will override and give you diff output
            //but without key it will give same output (base class output will be print twice)
            Dog obj = new Dog();
            obj.Food();

            obj = new Cat();
            obj.Food();
        }
    }
}
