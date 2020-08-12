using System;

namespace INOA.Domain.Entities
{
    public class StockQuote
    {
        public StockQuote(decimal purchaseReferencePrice, decimal actualPrice, decimal saleReferencePrice)
        {
            PurchaseReferencePrice = purchaseReferencePrice;
            ActualPrice = actualPrice;
            SaleReferencePrice = saleReferencePrice;
            Active = false;

            if(ActualPrice < 1)
                throw new ArgumentException("Actual price should be greater than 1");

            if(PurchaseReferencePrice < 1)
                throw new ArgumentException("Purchase Reference Price should be greater than 1");

            if(SaleReferencePrice < 1)
                throw new ArgumentException("Sales Reference Price should be greater than 1");
        }

        public decimal PurchaseReferencePrice { get; private set; }
        public decimal ActualPrice { get; private set; }
        public decimal SaleReferencePrice { get; private set; }
        public bool Active { get; private set; }

        public void Actived()
        {
            Active = true;
        }

        public void Deactivated()
        {
            Active = false;
        }
    }
}