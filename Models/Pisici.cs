using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heaven.Models
{
    public class Pisici
    {
        public int PisiciId { get; set; }
        public string Nume_pisica { get; set; }
        public int Varsta { get; set; }
       

        public string Culoare { get; set; }

        public ICollection<Poze> Poze { get; set; }
    }
}
