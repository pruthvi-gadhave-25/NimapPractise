namespace EventsDemo
{

    public class Program
    {

        public static void Main()
        {

            Stock applStock = new Stock( 150.00m, "Aapl");
            applStock.StockPriceChanged += Investor1_StockPriceChanged;
            applStock.StockPriceChanged += Investor2_StockPriceChanged;


            applStock.Price = 155.50m;
            applStock.Price = 185.50m;

        }

        // Event handler method for Investor 1
        private static void Investor1_StockPriceChanged(object sender, StockPriceChangedEventArgs e)
        {
            Console.WriteLine("tyu");
            Console.WriteLine($"Investor 1: The price of {e.Symbol} changed to {e.NewPrice:C}");
        }
        private static void Investor2_StockPriceChanged(object sender, StockPriceChangedEventArgs e)
        {
            Console.WriteLine($"Investor 1: The price of {e.Symbol} changed to {e.NewPrice:C}");
        }

    }
}

//ref -- https://medium.com/@ravipatel.it/understanding-events-in-c-with-practical-examples-8cb5ad547a35