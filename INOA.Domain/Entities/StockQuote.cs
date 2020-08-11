namespace INOA.Domain.Entities
{
    public class StockQuote
    {
        public decimal PurchaseReferencePrice { get; private set; }
        public decimal ActualPrice { get; private set; }
        public decimal SaleReferencePrice { get; private set; }
        public bool Active { get; private set; }
    }
}