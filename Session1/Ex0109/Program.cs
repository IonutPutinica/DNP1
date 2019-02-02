using System;

namespace Ex0109
{
    class Program
    {
        static void Main(string[] args)
        {
            StringUtility theString=new StringUtility("Hey, my name is Ionut and I study ICT");
            if(theString.getStringLenght()>=20)
            {
                theString.SummarizeText();
            }
            else
             Console.WriteLine(theString);
        }
    }
}
