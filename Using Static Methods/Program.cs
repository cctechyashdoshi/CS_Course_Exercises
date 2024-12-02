namespace Using_Static_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 10;
            int doublednum = DoubleValue(number);
            Console.WriteLine(doublednum);
        }

        public static int DoubleValue(int number)
        {
            return number * number;
        }
    }
}
