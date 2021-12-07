using Heaven.Repository;
using Heaven.Services;

namespace Heaven.Models
{
    internal class AdapostRepository : AdapostServices
    {
        public AdapostRepository(AdapostContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}