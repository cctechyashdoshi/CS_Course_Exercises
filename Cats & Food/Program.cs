namespace Cats___Food
{
    internal class Program
    {
        public static int NotHungryCats(string kitchen)
        {
            int index1 = kitchen.IndexOf('F');



            return index1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(NotHungryCats("~O~O~O~O F"));
            Console.ReadKey();
        }
    }
}
