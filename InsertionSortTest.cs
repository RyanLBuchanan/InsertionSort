using System.Runtime.Serialization.Formatters;

namespace InsertionSort
{
    internal class InsertionSortTest
    {
        static void Main(string[] args)
        {
            var generator = new Random();
            var data = new int[10];

            for (var i = 0; i < data.Length; ++i)
            {
                data[i] = generator.Next(10, 100);
            }

            Console.WriteLine("Unsorted array");
            Console.WriteLine(string.Join(" ", data) + "\n");

            InsertionSort(data);

            Console.WriteLine("Sorted array");
            Console.WriteLine(string.Join(" ", data) + "\n");
        }

        // Sort array
        public static void InsertionSort(int[] values)
        {
            // Loop over the data
            for (var next = 1; next < values.Length; ++next)
            {
                // Store value in current element
                var insert = values[next];

                // Initialize location to place element
                var moveItem = next;

                // Search for place to put current element
                while (moveItem > 0 && values[moveItem - 1] > insert)
                {
                    // Shift element right one slot
                    values[moveItem] = values[moveItem - 1];
                    moveItem--;
                }

                values[moveItem] = insert;
                PrintPass(values, next, moveItem);
            }
        }

        // Display a pass of the algorithm
        public static void PrintPass(int[] values, int pass, int index)
        {
            Console.WriteLine($"after pass {pass}: ");

            // Output elements until swapped item
            for (var i = 0; i < index; ++i)
            {
                Console.Write($"{values[i]}  ");
            }

            Console.WriteLine($"{values[index]}* ");  // Indicate swap

            // Finish outputting array
            for (var i = index + 1; i < values.Length; ++i)
            {
                Console.Write($"{values[i]}  ");
            }

            Console.Write("\n                 ");

            // Indicate amount of array that is sorted
            for (var i = 0; i <= pass; ++i)
            {
                Console.WriteLine("--  ");
            }

            Console.WriteLine("\n");
        }
    }
}