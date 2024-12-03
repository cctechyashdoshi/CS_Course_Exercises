using System;

namespace Cats___Food
{
    internal class Program
    {
        public static int NotHungryCats(string kitchen)
        {
            int indexOfF = kitchen.IndexOf('F');
            int notHungryCats = 0;

            for (int i = 0; i < indexOfF; i += 2)
            {
                if (i + 1 < kitchen.Length && kitchen.Substring(i, 2) == "O~")
                {
                    notHungryCats++;
                }
            }

            for (int j = indexOfF + 2; j < kitchen.Length - 1; j += 2)
            {
                if (kitchen.Substring(j, 2) == "~O")
                {
                    notHungryCats++;
                }
            }

            return notHungryCats;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(NotHungryCats("~O~O F ~O~O"));
            Console.ReadKey();
        }
    }
}
