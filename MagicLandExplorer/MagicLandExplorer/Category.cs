using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicLandExplorer
{
    public class Category
    {

        [JsonProperty("category")]
        public string CategoryName { get; set; }

        [JsonProperty("destinations")]
        public List<Destination> DestinationList { get; set; }
    }
}
