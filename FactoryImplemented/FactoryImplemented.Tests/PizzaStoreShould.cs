using FactoryImplemented.Library;
using Shouldly;
using Xunit;

namespace FactoryImplemented.Tests
{
    public class PizzaStoreShould
    {
        [Fact]
        public void ReturnPizzaWhenOrdered()
        {
            var store = new PizzaStore();

            var result = store.OrderPizza();

            result.ShouldBeOfType<Pizza>();
        }
    }
}