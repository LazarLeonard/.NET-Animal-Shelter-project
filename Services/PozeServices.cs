using Heaven.Models;
using Heaven.Repository;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Heaven.Services
{
    public class PozeServices : Services<Poze>, IPozeRepository
    {
        public PozeServices(AdapostContext repositoryContext) : base(repositoryContext)
        {
        }

        public bool ExistaPoze(Poze poze)
        {

            return FFindByCondition(c => c.PozeId == poze.PozeId).Any();
        }
    }
}