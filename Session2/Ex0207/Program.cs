using System;
using System.Collections.Generic;

namespace Ex0207
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,Person> dictionar=new Dictionary<string, Person>();
            Person Ionut=new Person("Ionut",19,200);
            Person Angel=new Person("Angel",20,50);
            dictionar.Add("1",Ionut);
            dictionar.Add("2",Angel);
            Console.WriteLine(dictionar["1"]);
            Console.WriteLine(dictionar["2"]);
            
           

        }
    }
}
