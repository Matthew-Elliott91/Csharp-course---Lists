using System.Collections.Generic;

namespace Lists___Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            // Declaring and initializing a list
            List<string> colors =
        [
            "Red",
            "Blue",
            "Green",
            "Red",
            "Red"
        ];

            // Print all items in the list
            foreach (string color in colors)
            {
                Console.WriteLine(color);
            }

            // Remove "Red" from the list, check if it was removed
            bool isDeletingSuccessful = colors.Remove("Red");

            // While "Red" exists, keep removing it
            while (isDeletingSuccessful)
            {
                // Attempt to remove "Red" again, check if it was removed
                isDeletingSuccessful = colors.Remove("Red");
            }

            // Print the list after removing all "Red" items
            Console.WriteLine("\nAfter removing all Reds:");
            foreach (string color in colors)
            {
                Console.WriteLine(color);
            }
            */

            List<int> numbers = 
                [ 
                10,
                5,
                15,
                3,
                9,
                25,
                18
                ];

            // If any number in Numbers > 20 return true
            bool hasLargeNumber = numbers.Any(x => x > 20);
            if (hasLargeNumber)
            {
                Console.WriteLine("There are large numbers in the numbers list");
            }
            else
            {
                Console.WriteLine("There are no large numbers in the numbers list");
            }

            // Define the predicate to check if a number is greater than 10
            Predicate<int> isGreaterThanTen = x => x > 10;

            

            // THis will return a list of numbers that are 10 and higher
            

            List<int> higherTen = numbers.FindAll(isGreaterThanTen);
            Console.WriteLine("All of the numbers higher than 10 in our list:");

            foreach (int number in higherTen)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("Unsorted List");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            numbers.Sort();


            Console.WriteLine("Sorted List");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }


        }
    }
}
