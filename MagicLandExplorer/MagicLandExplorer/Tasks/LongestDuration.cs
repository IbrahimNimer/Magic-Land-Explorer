using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MagicLandExplorer.Tasks
{
    public class LongestDuration
    {
        public static void LongestDestination(List<Category> categories)
        {
            var longestDestination = (from category in categories
                                     from destination in category.DestinationList
                                     orderby destination.GetDurationMinutes() descending
                                     select destination).FirstOrDefault();


            Console.WriteLine($"Name: {longestDestination.Name}\nLocation: {longestDestination.Location}\nDuration: {longestDestination.GetDurationMinutes()}");





        }
    }
}
