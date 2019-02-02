using System;

namespace Ex0201
{
    class Program
    {
        static void Main(string[] args)
        {
            Student normalStudent= new Student();
            DNPStudent dNPStudent= new DNPStudent();
            normalStudent.sayHi();
            dNPStudent.sayHi();
        }
    }
}
