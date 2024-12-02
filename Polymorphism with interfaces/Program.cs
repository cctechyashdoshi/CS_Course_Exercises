namespace Polymorphism_with_interfaces
{
    internal class Program
    {
        public interface IPayment
        {
            // TODO: Declare a method ProcessPayment
            public void ProcessPayment();
        }

        public class CreditCardPayment : IPayment
        {
            // TODO: Implement the ProcessPayment method
            public void ProcessPayment() 
            {
                Console.Write("Processing credit card payment");
            }
        }

        public class PayPalPayment : IPayment
        {
            // TODO: Implement the ProcessPayment method
            public void ProcessPayment()
            {
                Console.Write("Processing PayPal payment");
            }
        }

        public class Exercise
        {
            public void ProcessPayments()
            {
                // TODO: Create instances of CreditCardPayment and PayPalPayment, and call the ProcessPayment method on each
                CreditCardPayment payments = new CreditCardPayment();
                payments.ProcessPayment();
                PayPalPayment payPalPayment = new PayPalPayment();
                payPalPayment.ProcessPayment();
            }
        }
        static void Main(string[] args)
        {
            Exercise exercise = new Exercise(); 
            exercise.ProcessPayments();
        }
    }
}
