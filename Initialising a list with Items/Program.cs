namespace Initialising_a_list_with_Items
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3 };

            foreach (int i in numbers)
            {
                Console.Write(i + " ");
            }
        }
    }
}
