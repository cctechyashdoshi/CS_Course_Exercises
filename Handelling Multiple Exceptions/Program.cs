namespace Handelling_Multiple_Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exercise exercise = new Exercise();

            exercise.HandleMultipleExceptions("5", 1);

            exercise.HandleMultipleExceptions("invalid", 1);

            exercise.HandleMultipleExceptions("5", 5);
        }

        public class Exercise
        {
            public void HandleMultipleExceptions(string str, int num)
            {
                int[] numbers = { 1, 2, 3 };

                try
                {
                    int parsedNumber = int.Parse(str);

                    Console.WriteLine(numbers[num]);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid format.");
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Index out of range.");
                }
            }
        }
    }
}
