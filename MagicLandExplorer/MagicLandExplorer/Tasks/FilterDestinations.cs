using System;
using System.Collections.Generic;
using System.Linq;

namespace MagicLandExplorer.Tasks
{
    public class FilterDestinations
    {
        public static void DurationFilter(List<Category> categories)
        {
            // Check if categories is null
            if (categories == null)
            {
                Console.WriteLine("Categories list is null.");
                return;
            }

            var filteredDestinations = from category in categories
                                       from destination in category.DestinationList
                                       where destination.GetDurationMinutes() < 100 && destination.GetDurationMinutes() > 0
                                       select destination;
            int count = 1;
            foreach (var destination in filteredDestinations)
            {
                
                Console.WriteLine($"{count}-{destination.Name}");
                count++;
            }
        }
    }
}
