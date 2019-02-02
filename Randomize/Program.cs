using System;

namespace Randomize
{
    class Program
    {
        static void Main(string[] args)
        {
            int balls,balls1,balls2;
            Random r = new Random();
            balls=r.Next(1,4);
            balls1=r.Next(1,4);
            balls2=r.Next(1,4);
            Console.WriteLine(balls);
            Console.WriteLine(balls1);
            Console.WriteLine(balls2);
            Console.WriteLine("Balls");
            
        }
    }
}
