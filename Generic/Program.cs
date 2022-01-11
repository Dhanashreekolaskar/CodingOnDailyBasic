using System;

namespace Generic
{
    //Generic class use <T> IN ANGLE param
    //it is used after classname
    public class Store <T>
    {
        public T DataStore { get; set; }
    }

    //multiple Type Param

    class Value <Value1 , Value2>
    {
        public Value1 IceCream { get; set; }

        public Value2 Ice { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Store<string> store = new Store<string>();
            store.DataStore ="IceCream";
            //store.DataStore = 123; cant conv to int to string<string>

            Value<string, string> value = new Value<string, string>();
            value.IceCream = "Amazing!!!";
            value.Ice = "Cold";
        }
    }
}
