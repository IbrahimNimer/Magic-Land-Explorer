using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicLandExplorer
{
    public class Destination
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Location { get; set; }
        public string Duration { get; set; }
        public string Description { get; set; }

        public int GetDurationMinutes()
        {
            if (string.IsNullOrWhiteSpace(Duration))
            {
                return -1;
            }
            int duration;
            if (int.TryParse(Duration.Split(' ')[0], out duration))
            {
                return duration;
            }
            return 0;
        }
    }
}
