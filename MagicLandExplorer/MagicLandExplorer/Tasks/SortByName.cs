using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicLandExplorer.Tasks
{
    public class SortByName
    {
        public static void AlphabeticalSorting(List<Category> categories)
        {
            var name = from category in categories
                       from destination in category.DestinationList
                       orderby destination.Name ascending
                       select destination;

            int count = 1;
            foreach (var category in name) {

                Console.WriteLine($"{count}-{category.Name} ");
                count++;
            }

        }
    }
}
