using Heaven.Models;
using Heaven.Repository;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Heaven.Services
{ 

    public class CainiServices : Services<Caini>, ICainiRepository
    { 

    public CainiServices(AdapostContext repositoryContext) : base(repositoryContext)
    {
    }

    public bool ExistaCaini(Caini caini)
    {

        return FFindByCondition(c => c.CainiId == caini.CainiId).Any();
    }
}
}