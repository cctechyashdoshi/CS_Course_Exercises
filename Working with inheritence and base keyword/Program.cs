namespace Working_with_inheritence_and_base_keyword
{
    internal class Program
    {
        public class Animal
        {
            // TODO: Declare a virtual method MakeSound
            public virtual void MakeSound()
            {
                Console.Write("Animal sound");
            }
        }

        public class Dog : Animal
        {
            // TODO: Override the MakeSound method
            public override void MakeSound()
            {
                base.MakeSound();
                Console.Write("Dog barks");
            }
        }

        public class Exercise
        {
            public void PrintSounds()
            {
                // TODO: Create an instance of Dog and call the MakeSound method
                Dog dog = new Dog();
                dog.MakeSound();
            }
        }
        static void Main(string[] args)
        {
            Exercise exercise = new Exercise();
            exercise.PrintSounds();
        }
    }
}
