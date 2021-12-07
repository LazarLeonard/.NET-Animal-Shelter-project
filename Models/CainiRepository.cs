using Heaven.Services;

namespace Heaven.Models
{
    internal class CainiRepository : CainiServices
    {
        public CainiRepository(AdapostContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}