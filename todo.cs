using System;
using System.Collections.Generic;

namespace SimpleToDoList
{
    class Program
    {
        // List to store to-do items
        static List<string> todoList = new List<string>();

        static void Main(string[] args)
        {
            bool running = true;

            // Main loop for the application
            while (running)
            {
                Console.Clear();
                Console.WriteLine("Simple To-Do List");
                Console.WriteLine("=================");
                Console.WriteLine("1. View To-Do List");
                Console.WriteLine("2. Add To-Do Item");
                Console.WriteLine("3. Remove To-Do Item");
                Console.WriteLine("4. Exit");
                Console.Write("Select an option: ");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        ViewToDoList();
                        break;
                    case "2":
                        AddToDoItem();
                        break;
                    case "3":
                        RemoveToDoItem();
                        break;
                    case "4":
                        running = false;
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Press any key to try again.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        // Method to view the to-do list
        static void ViewToDoList()
        {
            Console.Clear();
            Console.WriteLine("Your To-Do List:");
            if (todoList.Count == 0)
            {
                Console.WriteLine("No items in the list.");
            }
            else
            {
                for (int i = 0; i < todoList.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {todoList[i]}");
                }
            }
            Console.WriteLine("\nPress any key to return to the menu.");
            Console.ReadKey();
        }

        // Method to add a new item to the list
        static void AddToDoItem()
        {
            Console.Clear();
            Console.Write("Enter a new to-do item: ");
            string newItem = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(newItem))
            {
                todoList.Add(newItem);
                Console.WriteLine("Item added successfully!");
            }
            else
            {
                Console.WriteLine("Cannot add an empty item.");
            }
            Console.WriteLine("Press any key to return to the menu.");
            Console.ReadKey();
        }

        // Method to remove an item from the list
        static void RemoveToDoItem()
        {
            Console.Clear();
            ViewToDoList();

            Console.Write("Enter the number of the item to remove: ");
            if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= todoList.Count)
            {
                todoList.RemoveAt(index - 1);
                Console.WriteLine("Item removed successfully!");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
            Console.WriteLine("Press any key to return to the menu.");
            Console.ReadKey();
        }
    }
}
