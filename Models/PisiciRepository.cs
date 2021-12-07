using Heaven;
using Heaven.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

internal class PisiciRepository : PisiciServices
{
    public PisiciRepository(AdapostContext repositoryContext) : base(repositoryContext)
    {
    }
}
