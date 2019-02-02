using System;

namespace Ex0107
{
    class Program
    {
        static void Main(string[] args)
        {
            string n1,n2;
            Console.WriteLine("Please input the first number=");
            n1=Console.ReadLine();
            Console.WriteLine("Please input the second number=");
            n2=Console.ReadLine();
            int number1,number2;
            number1=Convert.ToInt32(n1);
            number2=Convert.ToInt32(n2);
            if(number1>number2)
            {
                Console.WriteLine("The greatest number of the 2 is="+number1);
            }
              
            if(number2>number1)
            {
                Console.WriteLine("The greatest number of the 2 is="+number2);
            }
            }
        
        }
    }

