namespace TsManagement.Models
{
    class Stock
    {
        public string StockId { get;}
        public int StockQuantity { get; }
        public decimal StockValue { get;}
        public decimal StockPriceEach { get; }
        public Stock(string StockId ,int StockQuantity , decimal StockPriceEach, decimal StockValue )
        {
            this.StockId = StockId;
            this.StockQuantity = StockQuantity;
            this.StockPriceEach = StockPriceEach;
            this.StockValue = StockValue;
        }

    }
}
