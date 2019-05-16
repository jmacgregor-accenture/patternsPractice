using FactoryImplemented.Library.Pizzas;

namespace FactoryImplemented.Library
{
    public class PizzaStore
    {
        public IPizza OrderPizza()
        {
            return new CheesePizza();
        }
    }
}