using Heaven;
using Heaven.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

internal class ContactRepository : ContactServices
{
    public ContactRepository(AdapostContext repositoryContext) : base(repositoryContext)
    {
    }
}

