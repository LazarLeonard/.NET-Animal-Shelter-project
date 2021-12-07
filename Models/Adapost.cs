using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heaven.Models
{
    public class Adapost
    {
        public int AdapostId { get; set; }
        public string denumire { get; set; }
        public string adresa { get; set; }
        public string oras { get; set; }


        public Contact Contact { get; set; }
        public Doneaza Doneaza { get; set; }
        public ICollection<Poze> Poze { get; set; }
        
    }
}
