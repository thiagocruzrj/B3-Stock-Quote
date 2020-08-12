using AutoFixture;
using INOA.Domain.Entities;
using Xunit;

namespace INOA.Domain.Tests.Domain
{
    public class StockQuoteTest
    {
        private readonly Fixture _fixture;
        private readonly StockQuote _stockQuote;

        public StockQuoteTest()
        {
            _fixture = new Fixture();
            _stockQuote = _fixture.Create<StockQuote>();
        }
    }
}