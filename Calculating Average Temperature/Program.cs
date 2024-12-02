namespace Calculating_Average_Temperature
{
    internal class Program
    {
        public void PrintAverage(double[] temperatures)
        {
            double average = CalculateAverage(temperatures);
            Console.WriteLine($"The average temperature is: {average}°C");
        }
        public double CalculateAverage(double[] temperatures)
        {
            double avgTemp = 0;
            foreach (double temp in temperatures)
            {
                avgTemp += temp;
            }
            return avgTemp / temperatures.Length;
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            double[] temperatures = { 20.5, 22.3, 19.8, 23.4, 21.2 };
            program.PrintAverage(temperatures);
        }
    }
}
