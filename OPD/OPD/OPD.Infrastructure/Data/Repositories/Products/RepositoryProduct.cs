using OPD.Domain.Core.Interfaces.Repositories.Products;
using OPD.Domain.Entities.Products;

namespace OPD.Infrastructure.Data.Repositories.Products
{
    public class RepositoryProduct : RepositoryBase<Product>, IRepositoryProduct
    {
        private readonly Context _context;

        public RepositoryProduct(Context context)
            : base(context)
        {
            _context = context;
        }
    }
}
