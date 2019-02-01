using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ICar bmwCar = new BMWCar();
            bmwCar.ManufactureCar();
            PatrolEngineDecorator decorateEngine = new PatrolEngineDecorator(bmwCar);
            decorateEngine.ManufactureCar();
            Console.ReadKey();
        }
    }
}
