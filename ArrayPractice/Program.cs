using System;

namespace ArrayPractice
{
    class Program
    {
        public static void Main()
        {
            //Array initialize and allocated its memory is 5

            int[] Num = new int[5];

            Num[0] = 12;
            Num[1] = 24;
            Num[2] = 36;
            Num[3] = 48;
            Num[4] = 60;

            //'Index was outside the bounds of the array.'

            //Num[5] = 70;
            //Num[6] = 790;

            //For Loop

            Console.WriteLine("For Loop:");
            for (int i = 0; i <Num.Length; i++)
            {
                Console.Write(Num[i]+"\n");
            }

            //ForEachLoop

            Console.WriteLine("Foreach Loop:");
            foreach (var j in Num)
            {
                Console.Write(j+ "\n");
            
            }

            //While Loop
            Console.WriteLine("While Loop:");

            int k = 0;

            while(k<Num.Length)
            {
                Console.Write(Num[k]+"\n");
                k++;
            }


            //Do while Loop

            Console.WriteLine("Do While  Loop:");
            int m = 0;
            do
            {
                Console.Write(Num[m] + "\n");
                m++;
            } while (m < Num.Length);
           




        }
    }
}
