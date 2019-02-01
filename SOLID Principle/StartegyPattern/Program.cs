using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartegyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            SortContext context = new SortContext();
            context.Add(1);
            context.Add(10);
            context.Add(11);
            context.Add(5);
            context.SetSortStrategy(new InsertionSort());
            context.sort();
            context.SetSortStrategy(new BubbleSort());
            context.sort();
            context.SetSortStrategy(new SelectionSort());
            context.sort();
            Console.ReadKey();
        }
    }
}
