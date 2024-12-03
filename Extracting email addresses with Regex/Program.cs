using System;
using System.Text.RegularExpressions;

namespace Extracting_email_addresses_with_Regex
{
    internal class Program
    {
        public void ExtractPatterns(string input)
        {
            string pattern = @"[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-_]+\.[a-zA-Z]{2,}";

            MatchCollection matches = Regex.Matches(input, pattern);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            program.ExtractPatterns("Contact us at support@example.com or sales@example.org.");
        }
    }
}
