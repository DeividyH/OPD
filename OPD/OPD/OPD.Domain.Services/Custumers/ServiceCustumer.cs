using OPD.Domain.Core.Interfaces.Repositories.Custumers;
using OPD.Domain.Core.Interfaces.Services.Custumers;
using OPD.Domain.Entities.Custumers;

namespace OPD.Domain.Services.Custumers
{
    public class ServiceCustumer : ServiceBase<Custumer>, IServiceCustumer
    {
        private readonly IRepositoryCustumer _repositoryCustumer;

        public ServiceCustumer(IRepositoryCustumer repositoryCustumer)
            : base(repositoryCustumer)
        {
            _repositoryCustumer = repositoryCustumer;
        }
    }
}
