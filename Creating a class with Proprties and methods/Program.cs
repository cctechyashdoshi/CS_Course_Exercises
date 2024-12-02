using System;

namespace Creating_a_class_with_Properties_and_methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("John", 30);
            person.Greet();
        }
    }

    public class Person
    {
        private string _name;
        private int _age;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Age
        {
            get { return _age; }
            set
            {
                if (value > 0)
                {
                    _age = value;
                }
                else
                {
                    Console.WriteLine("Age must be greater than 0.");
                }
            }
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;  
        }

        public void Greet()
        {
            Console.WriteLine($"Hello, my name is {Name} and I am {Age} years old.");
        }
    }
}
