using System;

namespace Ex0108
{
    class Program
    {
        static void Main(string[] args)
        {
            string name,reversedName;
            Console.WriteLine("Please write your name=");
            name=Console.ReadLine();

            char[] array=name.ToCharArray();

            Array.Reverse(array);
            reversedName=new string(array);


            Console.WriteLine("The name, but reversed, is= "+reversedName);

        }
    }
}
