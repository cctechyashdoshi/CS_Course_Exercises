namespace Constructer_Inheritence
{
    internal class Program
    {

        public class Person
        {
            // TODO: Declare a constructor that takes a name and prints a message
            public Person(string name) 
            {
                Console.Write($"Person constructor: {name}");
            }
        }

        public class Employee : Person
        {
            // TODO: Declare a constructor that takes a name and an ID, and calls the base class constructor
            public Employee(string name, int id) : base(name)
            {
                Console.WriteLine($"Employee constructor: {name}, ID: {id}");
            }
        }

        public class Exercise
        {
            public void PrintMessages()
            {
                // TODO: Create an instance of Employee and print the messages
                Employee employee = new Employee("Yash", 1);
            }
        }

        static void Main(string[] args)
        {
            Exercise exercise = new Exercise();
            exercise.PrintMessages();
        }
    }
}
