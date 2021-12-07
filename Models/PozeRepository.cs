using Heaven;
using Heaven.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

internal class PozeRepository : PozeServices
{
    public PozeRepository(AdapostContext repositoryContext) : base(repositoryContext)
    {
    }
}


