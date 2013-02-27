using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerReco
{
    class Place
    {
        public int id { get; set; }
        public PlaceType type { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public double price { get; set; }
    }
}
