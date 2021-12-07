using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Heaven.Repository;
using Heaven.Services;

namespace Heaven.Models
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        public IAdapostRepository AdapostServices => throw new NotImplementedException();

        IAdapostRepository _adapostServices;

        ICainiRepository IRepositoryWrapper.CainiServices => throw new NotImplementedException();

        ICainiRepository _cainiServices { get; }

        IContactRepository _contactServices { get; }

        IContactRepository IRepositoryWrapper.ContactServices => throw new NotImplementedException();

        IDoneazaRepository _doneazaServices { get; }

        IDoneazaRepository IRepositoryWrapper.DoneazaServices => throw new NotImplementedException();

        IPisiciRepository _pisiciServices { get; }

        IPisiciRepository IRepositoryWrapper.PisiciServices => throw new NotImplementedException();

        IPozeRepository _pozeServices { get; }

        IPozeRepository IRepositoryWrapper.PozeServices => throw new NotImplementedException();

        IUtilizatorRepository _utilizatorServices { get; }

        IUtilizatorRepository IRepositoryWrapper.UtilizatorServices => throw new NotImplementedException();

        private AdapostContext _repoContext;
        private AdapostServices aadapostServices;
        private CainiServices ccainiServices;
        private ContactServices ccontactServices;
        private DoneazaServices ddoneazaServices;
        private PisiciServices ppisiciServices;
        private PozeServices ppozeServices;
        private UtilizatorServices uutilizatorServices;

        public IAdapostRepository adapostServices
        {
            get
            {
                if (aadapostServices == null)
                {
                    aadapostServices = new AdapostRepository(_repoContext);
                }

                return aadapostServices;
            }
        }

        public ICainiRepository CainiServices
        {
            get
            {
                if (ccainiServices == null)
                {
                    ccainiServices = new CainiRepository(_repoContext);
                }

                return ccainiServices;
            }
        }
        public IContactRepository ContactServices
        {
            get
            {
                if (ccontactServices == null)
                {
                    ccontactServices = new ContactRepository(_repoContext);
                }

                return ccontactServices;
            }
        }

        public IDoneazaRepository DoneazaServices
        {
            get
            {
                if (ddoneazaServices == null)
                {
                    ddoneazaServices = new DoneazaRepository(_repoContext);
                }

                return ddoneazaServices;
            }
        }

        public IPisiciRepository PisiciServices
        {
            get
            {
                if (ppisiciServices == null)
                {
                    ppisiciServices = new PisiciRepository(_repoContext);
                }

                return ppisiciServices;
            }
        }

        public IPozeRepository PozeServices
        {
            get
            {
                if (ppozeServices == null)
                {
                    ppozeServices = new PozeRepository(_repoContext);
                }

                return ppozeServices;
            }
        }

        public IUtilizatorRepository UtilizatorServices
        {
            get
            {
                if (uutilizatorServices == null)
                    NewMethod();

                return (IUtilizatorRepository)uutilizatorServices;
            }
        }

        private void NewMethod()
        {
            uutilizatorServices = new UtilizatorRepository(_repoContext);
        }
    }
}


