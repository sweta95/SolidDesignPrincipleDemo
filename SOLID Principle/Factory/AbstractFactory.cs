using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    internal class NewWorkPizza : IPizza
    {
        private IList<string> ingredients;

        public NewWorkPizza(IList<string> ingredients)
        {
            this.ingredients = ingredients;
        }
    }
    public interface IPizzaFactory
    {
        IPizza CreatePizza(IList<string> ingredients);
    }
    public abstract class PizzaFactory : IPizzaFactory
    {
        public abstract IPizza CreatePizza(IList<string> ingredients);       
    }
    public class NewWorkPizzaFactory : PizzaFactory
    {
        public override IPizza CreatePizza(IList<string> ingredients)
        {
            return new NewWorkPizza(ingredients);
        }
    }

    public abstract class PizzaStoreWithAbstractFactory
    {
        private readonly IPizzaFactory _factory;
        protected PizzaStoreWithAbstractFactory(IPizzaFactory factory)
        {
            _factory = factory;
        }
        public IPizza OrderPizza(IList<string> ingredients)
        {
            IPizza pizza = _factory.CreatePizza(ingredients);
            return pizza;
        }
    }
    public class NewYorkPizzaStoreWithAbstractFactory : PizzaStoreWithAbstractFactory
    {
        public NewYorkPizzaStoreWithAbstractFactory() : this(new NewWorkPizzaFactory()) { }
        public NewYorkPizzaStoreWithAbstractFactory(IPizzaFactory pizzaFactory):base(pizzaFactory) { }
    }

   
}
