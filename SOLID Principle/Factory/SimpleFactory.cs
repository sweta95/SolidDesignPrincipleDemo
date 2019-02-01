using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class SimpleFactoryPattern
    {
        public enum PizzaType
        {
            NewWork,
            Chicago,
            California
        }
        public interface IPizza
        {
        }
        public class NewWorkPizza : IPizza
        {
            public NewWorkPizza(IList<string> ingredients)
            {
            }
        }
        public class CaliforniaPizza : IPizza
        {
            public CaliforniaPizza(IList<string> ingredients)
            {
            }
        }
        public class ChicagoPizza : IPizza
        {
            public ChicagoPizza(IList<string> ingredients)
            {
            }
        }
        public static IPizza CreatePizza(PizzaType type, IList<string> ingredients)
        {
            switch (type)
            {
                case PizzaType.NewWork:
                    return new NewWorkPizza(ingredients);                  
                case PizzaType.Chicago:
                    return new ChicagoPizza(ingredients);                   
                case PizzaType.California:
                    return new CaliforniaPizza(ingredients);
                default:
                    return null;
            }
        }
    }
}
