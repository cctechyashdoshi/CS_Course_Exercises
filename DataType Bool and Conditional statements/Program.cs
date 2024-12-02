namespace DataType_Bool_and_Conditional_statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isLoggedIn;

            // Assign a value to isLoggedIn based on user input or condition

            isLoggedIn = true;

            if (isLoggedIn)
            {
                Console.WriteLine("Welcome back!");
            }
            else
            {
                Console.WriteLine("Please log in.");
            }
        }
    }
}
