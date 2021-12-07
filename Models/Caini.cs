using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heaven.Models
{
    public class Caini
    {
        public int CainiId { get; set; }
        public string Nume_caine { get; set; }
        public int Varsta { get; set; }
        public string Culoare { get; set; }
        public string Marime { get; set; }

        public ICollection<Poze> Poze { get; set; }
    }
}
