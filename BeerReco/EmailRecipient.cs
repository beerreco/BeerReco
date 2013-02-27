using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerReco
{
    class EmailRecipient
    {
        public int id { get; set; }
        public string email { get; set; }
        public Dictionary<Drink, string> interestedDrinks { get; set; }
    }
}
