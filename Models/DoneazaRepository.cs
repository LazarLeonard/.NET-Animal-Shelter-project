using Heaven;
using Heaven.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

internal class DoneazaRepository : DoneazaServices
{
    public DoneazaRepository(AdapostContext repositoryContext) : base(repositoryContext)
    {
    }
}
