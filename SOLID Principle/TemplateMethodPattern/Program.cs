using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            House woodenHouse = new WoodenHouse();
            woodenHouse.buildHouse();
            House glassHouse = new GlassHouse();
            glassHouse.buildHouse();
            Console.ReadKey();

        }
    }
}
