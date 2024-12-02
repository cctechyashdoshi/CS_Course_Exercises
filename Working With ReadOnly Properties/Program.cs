namespace Working_With_ReadOnly_Properties
{
    internal class Program
    {
        public class MyClass
        {
            public readonly string MyReadOnlyProperty;

            public MyClass(string value)
            {
                MyReadOnlyProperty = value;
            }
        }

        public class Exercise
        {
            public void PrintReadOnlyProperty()
            {
                var myObject = new MyClass("Read-Only Property Value");
                Console.WriteLine(myObject.MyReadOnlyProperty);
            }
        }

        static void Main(string[] args)
        {
            Exercise exercise = new Exercise();
            exercise.PrintReadOnlyProperty();
        }
    }
}
