using System;

namespace Interface
{
    public interface IAnimal
    {
        public void Sound();

        public void Behaviour();
    }

    public class Cat : IAnimal
    {
        public void Sound()
        {
            Console.WriteLine("MEOW");
        }

        public void Behaviour()
        {
            Console.WriteLine("CUTE");
        }
    }

    public class Dog : IAnimal
    {
        public void Sound()
        {
            Console.WriteLine("BOW");
        }

        public void Behaviour()
        {
            Console.WriteLine("FRIENDLY");
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Cat sound = new Cat();
            Console.WriteLine("Cat");
            sound.Sound();
            sound.Behaviour();


            Dog animal = new Dog();
            Console.WriteLine("\nDog");
            animal.Sound();
            animal.Behaviour();


        }
    }
}
