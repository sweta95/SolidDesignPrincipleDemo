using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartegyPattern
{
    public interface SortStrategy
    {
        void sort(List<int> nums);
    }
    public class InsertionSort : SortStrategy
    {
        public void sort(List<int> nums)
        {
            Console.WriteLine("Numbers sorted using insertion sort.");
        }
    }
    public class SelectionSort : SortStrategy
    {
        public void sort(List<int> nums)
        {
            Console.WriteLine("Numbers sorted using selection sort.");
        }
    }
    public class BubbleSort : SortStrategy
    {
        public void sort(List<int> nums)
        {
            Console.WriteLine("Numbers sorted using bubble sort.");
        }
    }
    public class SortContext
    {
        SortStrategy _sortStrategy;
        List<int> nums = new List<int>();
        public void SetSortStrategy(SortStrategy sortStrategy)
        {
            this._sortStrategy = sortStrategy;
        }
        public void Add(int num)
        {
            this.nums.Add(num);
        }
        public void sort()
        {
            _sortStrategy.sort(nums);
        }
    }
}
