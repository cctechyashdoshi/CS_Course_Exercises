namespace twoDArrays_and_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] twoDArray = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            for (int i = 0; i < twoDArray.GetLength(0); i++)
            {
                int sum = 0;

                for (int j = 0; j < twoDArray.GetLength(1); j++)
                {
                    sum += twoDArray[i, j];
                }
                Console.WriteLine("Sum of row " + (i + 1) + ": " + sum);
            }
        }
    }
}
