namespace Building_Conditional_Based_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the First Number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Second Number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Choose a operation (+, -, *, /, %)");
            char op = Console.ReadLine()[0];

            switch (op)
            {
                case '-':
                    Console.WriteLine(num1 - num2);
                    break;
                case '+':
                    Console.Write(num1 + num2);
                    break;
                case '/':
                    Console.Write(num1 / num2);
                    break;
                case '*':
                    Console.Write(num1 * num2);
                    break;
                case '%':
                    Console.Write(num1 % num2);
                    break;
            }
        }
    }
}