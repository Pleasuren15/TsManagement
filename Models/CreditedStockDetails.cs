using System;

namespace TsManagement.Models
{
    public class CreditedStockDetails
    {
        public string CellphoneNumber { get; }
        public string Name { get; }
        public decimal Amount { get; }
        public DateTime Date { get; }
        public string StockId { get; }

        public CreditedStockDetails(string CellphoneNumber, string StockId ,string Name, decimal Amount, DateTime Date)
        {
            this.CellphoneNumber = CellphoneNumber;
            this.StockId = StockId;
            this.Name = Name;
            this.Amount = Amount;
            this.Date = Date;
        }
    }
}
