using Heaven.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heaven.Models
{
    public class Contact
    {
        public int ContactId { get; set; }
        public string Nume{ get; set; }
        public string Prenume { get; set; }
        public string Email { get; set; }

        public ICollection<Utilizator> Utilizator { get; set; }




    }
}
