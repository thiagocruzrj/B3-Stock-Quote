using System;

namespace INOA.Domain.Entities
{
    public class StockQuote
    {
        public StockQuote(string assetName, decimal saleReferencePrice, decimal purchaseReferencePrice)
        {
            AssetName = assetName;
            SaleReferencePrice = saleReferencePrice;
            PurchaseReferencePrice = purchaseReferencePrice;
        }

        public string AssetName { get; set; }
        public decimal SaleReferencePrice { get; set; }
        public decimal PurchaseReferencePrice { get; set; }
    }
}