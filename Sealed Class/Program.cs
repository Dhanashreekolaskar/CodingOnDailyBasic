using System;

namespace Sealed_Class
{
    //Sealed class Eg
    public sealed class Printer
    {
        public void ink ()
        {
            Console.WriteLine("INK Method");
        }

        public void Cartage()
        {
            Console.WriteLine("Cartage support black ink");
        }


    }

    //Sealed method eg
    public class LaserJet
    {
         public virtual void Jet()
        {
            Console.WriteLine("Jet");

        }

        public virtual void Active()
        {
            Console.WriteLine("Active");

        }

        public void Weight()
        {
            Console.WriteLine("200000");
        }
    }

    public class Panasonic : LaserJet
    {
        public sealed override void Jet()
        {
            Console.WriteLine("Sealed Jet");

        }
        public override void Active()
        {
            Console.WriteLine("No");

        }

        public void color()
        {
            Console.WriteLine("Blue");

        }
    }

    public class Microsoft : Panasonic
    {
        //public override void Jet()
        //{
        //    //cannot inheritate method beacause it is in sealed method

        //}
    
    public override void Active()
        {
            Console.WriteLine("Yes");

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //can create object of sealed class
            Printer printer = new Printer();
            printer.ink();
            printer.Cartage();


            Panasonic panasonic = new Panasonic();
            panasonic.color();
            panasonic.Weight();

            LaserJet laser = new LaserJet();
            laser.Weight();



        }
    }
}
