using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    /// <summary>
    /// The 'AbstractClass' abstract class
    /// </summary>
    public abstract class House
    {
        // The 'Template Method' 
        public void buildHouse()
        {
            buildFoundation();
            buildPillars();
            buildWalls();
            buildWindows();
        }
        public abstract void buildFoundation();
        public abstract void buildPillars();
        public abstract void buildWalls();
        public abstract void buildWindows();
    }
    /// <summary>
    /// A 'ConcreteClass' class
    /// </summary>
    public class WoodenHouse : House
    {
        public override void buildFoundation()
        {
            Console.WriteLine("Building wooden house foundation.");
        }

        public override void buildPillars()
        {
            Console.WriteLine("Building wooden house pillars.");
        }

        public override void buildWalls()
        {
            Console.WriteLine("Building wooden house walls.");
        }

        public override void buildWindows()
        {
            Console.WriteLine("Building wooden house windows.");
        }
    }
    /// <summary>
    /// A 'ConcreteClass' class
    /// </summary>
    public class GlassHouse : House
    {
        public override void buildFoundation()
        {
            Console.WriteLine("Building glass house foundation.");
        }

        public override void buildPillars()
        {
            Console.WriteLine("Building glass house pillars.");
        }

        public override void buildWalls()
        {
            Console.WriteLine("Building glass house walls.");
        }

        public override void buildWindows()
        {
            Console.WriteLine("Building glass house windows.");
        }
    }

}
