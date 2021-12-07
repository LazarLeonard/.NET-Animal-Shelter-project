using Heaven.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heaven.Models
{
    public class Doneaza
    {
        public int DoneazaId { get; set; }
        public int Numele_detinatorului { get; set; }
        public int Numarul_cardului { get; set; }
        public int Data_de_expirare { get; set; }
        public int CVC { get; set; }

        public Utilizator utilizator { get; set; }

    }
}
