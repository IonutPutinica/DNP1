namespace Ex0103
{
    public class Person
    {
         public string name;
     public Person(string name)
     {
         this.name=name;
     }
     public void Introduce()
     {

         System.Console.WriteLine("Hi, I am " + name);
    }
}
}