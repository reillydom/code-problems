using System;
using System.Linq;

namespace AlphanumericStringSort
{
    class Program
    {
        static void Main(string[] args)
        { 

            Console.WriteLine("Starting AlphanumericStringSort test");
            
            if(args?.Any() ?? false)
            {
                var valueToSort = args[0];

                var sorter = new Sorter();

                var sortedValuesByASCIIOrder = sorter.OrderByASCIIAndSort(valueToSort);

                Console.WriteLine($"SortByASCIIOrder value --> {sortedValuesByASCIIOrder}");

                var sortedValues = sorter.Sort(valueToSort);
                Console.WriteLine($"Sort value --> {sortedValues}");

            }
            else
            {
                Console.WriteLine("No arguments detected. Please ensure you have provided arguments");
            }



            Console.ReadLine();

        }
    }
}
