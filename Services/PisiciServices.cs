using Heaven.Models;
using Heaven.Repository;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Heaven.Services
{
    public class PisiciServices : Services<Pisici>, IPisiciRepository
    {
        public PisiciServices(AdapostContext repositoryContext) : base(repositoryContext)
        {
        }

        public bool ExistaPisici(Pisici pisici)
        {

            return FFindByCondition(c => c.PisiciId == pisici.PisiciId).Any();
        }

       
    }
}