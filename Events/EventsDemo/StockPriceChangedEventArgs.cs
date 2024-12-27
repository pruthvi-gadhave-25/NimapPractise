namespace EventsDemo
{

    //custom event args for  passing  stock price change information
    public class StockPriceChangedEventArgs : EventArgs
    {
        
      
        public string Symbol { get; set; }
        public decimal NewPrice { get; set; }  


        public StockPriceChangedEventArgs(string symbol , decimal newPrice)
        {
            Symbol = symbol;
            NewPrice = newPrice;
        }
    }
}
