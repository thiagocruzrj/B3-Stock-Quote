namespace INOA.Domain.Entities
{
    public class StockQuote
    {
        public string AssetName { get; private set; }
        public decimal SaleReferencePrice { get; private set; }
        public decimal PurchaseReferencePrice { get; private set; }
    }
}