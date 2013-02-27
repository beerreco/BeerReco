using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerReco
{
    class Beer : Drink
    {
        public string brewery { get; set; }
        public BeerType type { get; set; }
        public string madeOf { get; set; }
        public double alcoholPercent { get; set; }
        public Dictionary<string, string> tags { get; set; }
    }
}
