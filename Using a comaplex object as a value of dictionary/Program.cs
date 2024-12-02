namespace Using_a_comaplex_object_as_a_value_of_dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "1 2 3 ");

            Console.Write(dict[1]);
        }
    }
}
