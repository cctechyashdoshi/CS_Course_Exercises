using System;

namespace Coding.Exercise1
{
    public class Stock
    {
        private decimal _price;
        private decimal _threshold;

        public decimal Price
        {
            get { return _price; }
            set
            {
                _price = value;

                if (_price < _threshold)
                {
                    StockAlert stockAlert = new StockAlert();
                    stockAlert.OnStockPriceChanged("Stock Alert: Stock price is below threshold!");
                }
                else
                {
                    Console.WriteLine($"(No alert for {value})");
                }
            }
        }

        public decimal Threshold
        {
            get { return _threshold; }
            set { _threshold = value; }
        }
    }

    public class StockAlert
    {
        public void OnStockPriceChanged(string message)
        {
            Console.WriteLine($"Stock Alert: {message}");
        }
    }

    class Program1
    {
        static void Main(string[] args)
        {
            Stock stock = new Stock();
            StockAlert stockAlert = new StockAlert();

            stock.Threshold = 120;

            // Simulate stock price changes
            stock.Price = 150; // No alert
            stock.Price = 130; // No alert
            stock.Price = 110; // Stock Alert: Stock price is below threshold!

            Console.ReadLine();
        }
    }
}
