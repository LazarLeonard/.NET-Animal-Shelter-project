using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Heaven.Repository;

namespace Heaven.Models
{
    public interface IRepositoryWrapper
    {
        IAdapostRepository AdapostServices { get; }
        ICainiRepository CainiServices { get; }
        IContactRepository ContactServices { get; }
        IDoneazaRepository DoneazaServices { get; }
        IPisiciRepository PisiciServices { get; }
        IPozeRepository PozeServices { get; } 
        IUtilizatorRepository UtilizatorServices { get; }
        
    }
}