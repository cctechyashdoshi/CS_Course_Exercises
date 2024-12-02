namespace The_Finally_Keyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] myNumbers = { 1, 2, 3 };
                Console.Write("Trying...");
            }
            catch (Exception e)
            {
                Console.Write("Something went wrong.");
            }
            finally
            {
                Console.Write("Finally Executed");
            }
        }
    }
}
