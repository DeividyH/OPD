using OPD.Domain.Core.Interfaces.Repositories.Custumers;
using OPD.Domain.Entities.Custumers;

namespace OPD.Infrastructure.Data.Repositories.Custumers
{
    public class RepositoryCustumer : RepositoryBase<Custumer>, IRepositoryCustumer
    {
        private readonly Context _context;

        public RepositoryCustumer(Context context)
            : base(context)
        {
            _context = context;
        }
    }
}
