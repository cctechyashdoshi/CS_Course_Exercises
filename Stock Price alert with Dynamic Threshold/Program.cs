using System; // Importing the System namespace

namespace Coding.Exercise // Defining the Coding.Exercise namespace
{
    // Define the delegate that will be used for the event
    public delegate void StockPriceChangedHandler(string message);

    // Define the Stock class which includes the event system
    public class Stock
    {
        // Declare the event using the delegate
        public event StockPriceChangedHandler? OnStockPriceChanged;

        // Private field to store the stock price
        private decimal _price;

        // Private field to store the threshold
        private decimal _threshold;

        // Property to get and set the stock price
        public decimal Price
        {
            get { return _price; }
            set
            {
                // Set the new price
                _price = value;

                // Raise the event if the price drops below the threshold
                if (_price < _threshold)
                {
                    RaiseStockPriceChangedEvent("Stock Alert: Stock price is below threshold!");
                }
                else
                {
                    Console.WriteLine($"(No alert for {value})");
                }
            }
        }

        // Property to get and set the alert threshold
        public decimal Threshold
        {
            get { return _threshold; }
            set { _threshold = value; }
        }

        // Method to raise the stock price changed event
        public void RaiseStockPriceChangedEvent(string message)
        {
            // Check if there are any subscribers to the event
            if (OnStockPriceChanged != null)
            {
                // Invoke the event with the message
                OnStockPriceChanged(message);
            }
        }
    }

    // Define the subscriber class which reacts to the event
    public class StockAlert
    {
        // Method that handles the event and prints a message to the console
        public void OnStockPriceChanged(string message)
        {
            Console.WriteLine($"Stock Alert: {message}");
        }
    }

    // Program class to simulate the stock price changes and test the event system
    class Program
    {
        static void Main(string[] args)
        {
            // Create instances of Stock and StockAlert
            Stock stock = new Stock();
            StockAlert stockAlert = new StockAlert();

            // Subscribe to the stock price changed event
            stock.OnStockPriceChanged += stockAlert.OnStockPriceChanged;

            // Set the alert threshold
            stock.Threshold = 120;

            // Simulate stock price changes
            stock.Price = 150; // No alert
            stock.Price = 130; // No alert
            stock.Price = 110; // Stock Alert: Stock price is below threshold!

            // Wait for user input to close the console
            Console.ReadLine();
        }
    }
}
