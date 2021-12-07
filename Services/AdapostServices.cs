using Heaven.Models;
using Heaven.Repository;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Heaven.Services
{
    public class AdapostServices : Services<Adapost>, IAdapostRepository
    {
        public AdapostServices(AdapostContext repositoryContext) : base(repositoryContext)
        {
        }

        public bool ExistaAdapost(Adapost adapost)
        {

            return FFindByCondition(c => c.AdapostId == adapost.AdapostId).Any();
        }
    }
}