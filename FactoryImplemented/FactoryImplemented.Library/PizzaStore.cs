using FactoryImplemented.Library.Pizzas;

namespace FactoryImplemented.Library
{
    public class PizzaStore
    {
        public IPizza OrderPizza(string type = "cheese")
        {
            if (type == "pepperoni")
            {
                return new PepperoniPizza();
            }
            
            return new CheesePizza();
        }
    }
}