using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    class Program
    {
        //the "Strategy" abstract Class
        abstract class SortStrategy
        {
            public abstract void Sort(List<string> list);
        }

        // A "ConcreteStrategy" class
        class QuickSort : SortStrategy
        {
            public override void Sort(List<string> list)
            {
                list.Sort(); //Default is QuickSort
                Console.WriteLine("QuickSorted List ");
            }
        }

        // A "ConcreteStrategy" class
        class ShellSort : SortStrategy
        {
            public override void Sort(List<string> list)
            {
                //list.Sort(); not-implemented
                Console.WriteLine("Shellsorted list ");
            }
        }

        // A "ConcreteStrategy" class
        class MergeSort : SortStrategy
        {
            public override void Sort(List<string> list)
            {
                //list.MergeSort(); not-implemented
                Console.WriteLine("MergeSorted list ");
            }
        }

        // The "Context" Class
        class SortedList
        {
            private List<string> _list = new List<string>();
            private SortStrategy _sortStrategy;

            public void SetSortStrategy(SortStrategy sortStrategy)
            {
                _sortStrategy = sortStrategy;
            }

            public void Add(string name)
            {
                _list.Add(name);
            }

            public void Sort()
            {
                _sortStrategy.Sort(_list);

                //Iterate over list and display results
                foreach (string name in _list)
                {
                    Console.WriteLine(" " + name);
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            SortedList studentRecords = new SortedList();

            studentRecords.Add("Samuel");
            studentRecords.Add("Jimmy");
            studentRecords.Add("Sandra");
            studentRecords.Add("Vivek");
            studentRecords.Add("Anna");

            studentRecords.SetSortStrategy(new QuickSort());
            studentRecords.Sort();

            studentRecords.SetSortStrategy(new ShellSort());
            studentRecords.Sort();

            studentRecords.SetSortStrategy(new MergeSort());
            studentRecords.Sort();

            Console.ReadKey();
        }
    }
}
