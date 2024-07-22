using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicLandExplorer.Tasks
{
    public class FantasyLand
    {
        public static void SharedLocation(List<Category> categories)
        {
            var filteredDestinations = from category in categories
                                       from destination in category.DestinationList
                                       where destination.Location == "Fantasyland"
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
