using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicLandExplorer.Tasks
{
    public class Top3Duration
    {
        public static void Top(List<Category> categories)
        {
            var name = (from category in categories
                        from destination in category.DestinationList
                        orderby destination.GetDurationMinutes() descending
                        select destination).Take(3);
            int count = 1;
            foreach (var top in name)
            {
                Console.WriteLine($"{count}-{top.Name} - {top.Duration}");
                count++;
            }


        }
    }
}
