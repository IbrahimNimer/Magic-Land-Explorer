using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using MagicLandExplorer.Tasks;

namespace MagicLandExplorer
{
    internal class Program
    {
        private static List<Category> categories;

        static void Main(string[] args)
        {
            // Get the directory of the executing assembly
            string assemblyDirectory = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

            // Construct the file path relative to the assembly directory
            string filePath = Path.Combine(assemblyDirectory, "data", "MagicLandData.json");

            // Check if the file exists
            if (!File.Exists(filePath))
            {
                Console.WriteLine($"File not found: {filePath}");
                return;
            }

            // Read the JSON file content
            string json = File.ReadAllText(filePath);

            // Deserialize JSON to List<Category>
            categories = JsonConvert.DeserializeObject<List<Category>>(json);

            // Check if categories list is null or empty
            if (categories == null || categories.Count == 0)
            {
                Console.WriteLine("No categories found or categories list is empty.");
                return;
            }

            Console.WriteLine("Categories loaded successfully.");
            Console.WriteLine($"Loaded {categories.Count} categories.");

            List<MenuItem> menuItems = new List<MenuItem>
            {
                new MenuItem("Filter Destinations by Duration", FilterDestinations),
                new MenuItem("Find Longest Duration Destination", LongestDestination),
                new MenuItem("Sort Destinations Alphabetically", SortAlphabetically),
                new MenuItem("Show Top 3 Destinations by Duration", Top3Destinations),
                new MenuItem("Find Shared Locations in Fantasy Land", SharedLocations),
                new MenuItem("Exit", Exit)
            };

            Menu menu = new Menu(menuItems);
            menu.Display();
        }

        static void FilterDestinations()
        {
            Console.Clear();
            MagicLandExplorer.Tasks.FilterDestinations.DurationFilter(categories);
            Pause();
        }

        static void LongestDestination()
        {
            Console.Clear();
            MagicLandExplorer.Tasks.LongestDuration.LongestDestination(categories);
            Pause();
        }

        static void SortAlphabetically()
        {
            Console.Clear();
            MagicLandExplorer.Tasks.SortByName.AlphabeticalSorting(categories);
            Pause();
        }

        static void Top3Destinations()
        {
            Console.Clear();
            MagicLandExplorer.Tasks.Top3Duration.Top(categories);
            Pause();
        }

        static void SharedLocations()
        {
            Console.Clear();
            MagicLandExplorer.Tasks.FantasyLand.SharedLocation(categories);
            Pause();
        }

        static void Exit()
        {
            Console.Clear();
            Console.WriteLine("Exiting the application. Goodbye!");
        }

        static void Pause()
        {
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}
