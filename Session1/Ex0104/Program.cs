using System;

namespace Ex0104
{
    class Program
    {
        static void Main(string[] args)
        {
      Console.WriteLine("Here's the even numbers");
      int i;
      for(i=0;i<=100;i++)
      {
          if(i%2==0)
          Console.WriteLine(i);
          
          
      }
      Console.WriteLine("Here's the uneven numbers");
          int k=0;
          int j=0;
          while(k==0)
          {
              if(j%2==1)
              Console.WriteLine(j);
              j++;
              if(j==101)
              k=1;
          }
    }
}

}