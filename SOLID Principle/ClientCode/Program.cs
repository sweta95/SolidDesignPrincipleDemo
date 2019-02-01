using System.Collections.Generic;
using LISCOV.Refactored;
using System;
using Factory;

namespace ClientCode
{
    class Program
    {
        static void Main(string[] args)
        {
            IInvoice objInvoice = null;
            Console.WriteLine("Enter invoice type");
            int invoiceType = Convert.ToInt32(Console.ReadLine());
            objInvoice = clsFactoryInvoice.getInvoice(invoiceType);
            objInvoice.print();
            Console.ReadLine();
        }

        private static void CalculateArea()
        {
            List<int> areas = new List<int>();
            List<Shape> shapes = new List<Shape>(){
                new Rectangle(10,5),
                new Square(2)
            };
            foreach (var shape in shapes)
            {
                areas.Add(shape.TotalArea());
            }
            foreach (var area in areas)
            {
                Console.WriteLine(area);
            }
            Console.ReadLine();
        }
    }
}
