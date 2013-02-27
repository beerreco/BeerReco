using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerReco
{
    class Review
    {
        public int id { get; set; }
        public string username { get; set; }
        public DateTime date { get; set; }
        public Drink relativeDrink { get; set; }
        public string review { get; set; }
    }
}
