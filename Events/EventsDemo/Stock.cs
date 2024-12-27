using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDemo
{
    public  class Stock
    {

        public delegate void StockPriceChangeHandler(Object sender, StockPriceChangedEventArgs e);
        public event StockPriceChangeHandler StockPriceChanged;

        private decimal price;
        public string Symbol { get; }

        public Stock(decimal price, string symbol)
        {
            this.price = price;
            this.Symbol = symbol;
        }


        public decimal Price
        {
            get { return price; }
            set
            {
                if (price != value)
                {
                    price = value;
                    OnStockPriceChanged(new StockPriceChangedEventArgs(Symbol ,price));
                }
            }

            
        }

        protected virtual void OnStockPriceChanged(StockPriceChangedEventArgs e)
        {
            StockPriceChanged?.Invoke(this, e);
        }

    }
}
