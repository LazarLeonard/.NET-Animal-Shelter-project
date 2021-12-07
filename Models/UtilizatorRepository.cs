namespace Heaven.Models
{
    internal class UtilizatorRepository : UtilizatorServices
    {
        private AdapostContext _repoContext;

        public UtilizatorRepository(AdapostContext repoContext)
        {
            _repoContext = repoContext;
        }
    }
}