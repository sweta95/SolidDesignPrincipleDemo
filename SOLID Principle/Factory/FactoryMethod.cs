using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public interface IPizza
    {
    }
    public class NewworkPizza : IPizza
    {
        public NewworkPizza(IList<string> ingredients)
        {
        }
    }
    public abstract class PizaaStore
    {        
        public IPizza OrderPizza(IList<string> ingredients)
        {
            IPizza pizza = CreatePizza(ingredients);
            return pizza;
        }
        public abstract IPizza CreatePizza(IList<string> ingredients);
    }
    public class NewworkPizzaStore : PizaaStore
    {
        public override IPizza CreatePizza(IList<string> ingredients)
        {
            return new NewworkPizza(ingredients);
        }
    }
   
}
