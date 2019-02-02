using System;
namespace Ex0207
{
    public class Person
    {
        string name;
        int age;
        int power;
        public Person(string name, int age, int power)
        {
            this.name=name;
            this.age=age;
            this.power=power;
        }
        public int getAge()
        {
            return age;
        }
        public string getName()
        {
            return name;
        }
    }
}