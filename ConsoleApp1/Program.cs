using System;
using System.Collections;

namespace Loop
{
    class Program
    {

        static void Main(string[] args)
        {
           // char[] Hello = { 'S', 'H', 'R', 'E', 'E' };

            ArrayList arrayList = new ArrayList();
            arrayList.Add("q");
            arrayList.Add(2);
            arrayList.Add(2.1);
            arrayList.Add("q");
            arrayList.Add("Shree");
            arrayList.Add("q");
            arrayList.Add("q");
           





            Console.WriteLine("size:"+arrayList.Capacity);
            foreach (var h in arrayList)
            {
                Console.WriteLine(h);
            }
        }
    }
}
