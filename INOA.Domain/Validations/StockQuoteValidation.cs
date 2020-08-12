using FluentValidation;
using INOA.Domain.Entities;

namespace INOA.Domain.Validations
{
    public class StockQuoteValidation : AbstractValidator<StockQuote> 
    {
        public StockQuoteValidation()
        {
            RuleFor(x => x.AssetName).NotEmpty().NotNull().WithMessage("Invalid Asset Name");
            RuleFor(x => x.PurchaseReferencePrice).NotEmpty().NotNull().GreaterThan(0).WithMessage("Invalid Purchase Reference Price");
            RuleFor(x => x.SaleReferencePrice).NotEmpty().NotNull().GreaterThan(0).WithMessage("Invalid Sale Reference Price");
        }
    }
}