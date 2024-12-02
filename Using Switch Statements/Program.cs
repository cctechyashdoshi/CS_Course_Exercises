namespace Using_Switch_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int day = 3;

            // Rewriting the if-else structure using a switch statement
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                default:
                    Console.WriteLine("Another day");
                    break;
            }
        }
    }
}
