using System;

namespace Abstract
{
    public abstract class aAnimal
    {

        //can give signature only cannot implemet it

        public abstract void Cat();

        public abstract void Dog();

        public abstract int Add(int a ,int b);
       
    }

    //mention override keyword
    //implemet can happen inheritence 
    public class Sound : aAnimal
    {
        public override int Add(int a, int b)
        {
            int Sum;

            Sum = a + b;
            return Sum;
        }

        public override void Cat()
        {
            
            Console.WriteLine("Sound : Meow");
        }

        public override void Dog()
        {
            Console.WriteLine("Sound : Bark");

        }

        
    }


    class Program
    {
        //abstract class cannot create object
        //eg aAnimal is a abstract class so we can not take aAnimal animal = new aAnimal();
        static void Main(string[] args)
        {

            Sound sound = new Sound();
             sound.Cat();

            sound.Dog();

            Console.WriteLine("Sum is :" + sound.Add(10, 20));
        }
    }
}
