using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using static Lists___Basics.Program;

namespace Lists___Basics
{
    internal class Program

    {
        //Hashtables 
        class Student
        {
            public int Id { get; set; }

            public string Name { get; set; }

            public float GPA { get; set; }

            public Student(int id, string name, float gpa)
            {
                this.Id = id;
                this.Name = name;
                this.GPA = gpa;
            }
            public class Product
            {
                public string Name { get; set; }
                public double Price { get; set; }
            }
            static void Main(string[] args)

            {
                int? age = null; // Adding ? after variable makes it nullable

                if( age.HasValue )
                {
                    Console.WriteLine($"Age is {age}");
                } else
                {
                    Console.WriteLine("Age is not specified");
                }
                // HashTable
                Hashtable studentTable = new Hashtable();
                Student stud1 = new Student(1, "Maria", 98);
                Student stud2 = new Student(2, "Jason", 76);
                Student stud3 = new Student(3, "Clara", 43);
                Student stud4 = new Student(4, "Steve", 55);

                studentTable.Add(stud1.Id, stud1);
                studentTable.Add(stud2.Id, stud2);
                studentTable.Add(stud3.Id, stud3);
                studentTable.Add(stud4.Id, stud4);

                Student storedStudent1 = (Student)studentTable[1];

                // Retreive all values from a Hashtable
                foreach (DictionaryEntry entry in studentTable)
                {
                   Student temp = (Student)entry.Value;
                    Console.WriteLine($"Student ID: {temp.Id}, Student Name: {temp.Name}");
                }
                    

                List<Product> products = new List<Product> {

                new Product {Name = "Apple", Price = 0.80},
                new Product { Name = "Bananas", Price = 0.30 },
                new Product { Name = "Cherry", Price = 3.80 },
            };

                products.Add(new Product { Name = "Berries", Price = 1.99 });


                // This says  create a list where  the price of product is less than 1
                List<Product> cheapProducts = products.Where(product => product.Price < 1.0).ToList();

                Console.WriteLine("A list of the products costing less then 1");

                foreach (Product product in cheapProducts)
                {
                    Console.WriteLine($"Product Name: {product.Name}, Price: {product.Price}");
                }

                Console.WriteLine("A list of all our products");

                foreach (Product product in products)
                {
                    Console.WriteLine($"Product Name: {product.Name}, Price: {product.Price}");
                }

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
                    // Console.WriteLine("There are large numbers in the numbers list");
                }
                else
                {
                    // Console.WriteLine("There are no large numbers in the numbers list");
                }

                // Define the predicate to check if a number is greater than 10
                Predicate<int> isGreaterThanTen = x => x > 10;



                // THis will return a list of numbers that are 10 and higher


                List<int> higherTen = numbers.FindAll(isGreaterThanTen);
                Console.WriteLine("All of the numbers higher than 10 in our list:");

                foreach (int number in higherTen)
                {
                    // Console.WriteLine(number);
                }

                Console.WriteLine("Unsorted List");
                foreach (int number in numbers)
                {
                    //Console.WriteLine(number);
                }

                numbers.Sort();


                Console.WriteLine("Sorted List");
                foreach (int number in numbers)
                {
                    // Console.WriteLine(number);
                }

                //Legacy ArrayList with undefined amount of objects
                ArrayList myArrayList = new ArrayList();
                // Legacy ArrayList with defined amount of objects
                ArrayList myArrayList2 = new ArrayList(100);

                myArrayList.Add(25);
                myArrayList.Add("Hello");
                myArrayList.Add(13.37);
                myArrayList.Add(13);
                myArrayList.Add(128);
                myArrayList.Add(25.3);

                // Deletes element with specific value from the arrayList
                myArrayList.Remove(13);

                // Delete element at specific Index

                myArrayList.RemoveAt(0);
                Console.WriteLine(myArrayList.Count);
                double sum = 0;

                foreach (object obj in myArrayList)
                {
                    if (obj is int)
                    {

                        sum += Convert.ToDouble(obj);
                    }
                    else if (obj is double)
                    {
                        sum += (double)obj;
                    }
                    else if (obj is string)
                    {
                        Console.WriteLine(obj);
                    }
                }
                Console.WriteLine(sum);



            }



        }
    }
}
       
       

       
        
