using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heaven.Models
{
    public class Poze
    {
        public int PozeId { get; set; }

        public int id_pisica { get; set; }
        public int id_caine { get; set; }

        public Caini caini { get; set; }
        public Pisici pisici { get; set; }



    }
}
