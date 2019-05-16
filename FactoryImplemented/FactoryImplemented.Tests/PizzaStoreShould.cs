using FactoryImplemented.Library;
using FactoryImplemented.Library.Pizzas;
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

            result.ShouldBeAssignableTo<IPizza>();
        }

        [Fact]
        public void ReturnCheesePizzaWhenNotSpecified()
        {
            var store = new PizzaStore();

            var result = store.OrderPizza();
            
            result.ShouldBeOfType<CheesePizza>();
        }
    }
}