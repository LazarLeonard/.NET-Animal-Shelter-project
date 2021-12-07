using Heaven.Models;
using Heaven.Repository;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Heaven.Services
{
    public class DoneazaServices : Services<Doneaza>, IDoneazaRepository
    {
        public DoneazaServices(AdapostContext repositoryContext) : base(repositoryContext)
        {
        }

        public bool ExistaDonatie(Doneaza doneaza)
        {

            return FFindByCondition(c => c.DoneazaId == doneaza.DoneazaId).Any();
        }

        
    }
}