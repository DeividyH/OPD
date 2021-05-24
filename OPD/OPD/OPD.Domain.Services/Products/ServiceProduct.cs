using OPD.Domain.Core.Interfaces.Repositories.Products;
using OPD.Domain.Core.Interfaces.Services.Products;
using OPD.Domain.Entities.Products;

namespace OPD.Domain.Services.Products
{
    public class ServiceProduct : ServiceBase<Product>, IServiceProduct
    {
        private readonly IRepositoryProduct _repositoryProduct;

        public ServiceProduct(IRepositoryProduct repositoryProduct)
            : base(repositoryProduct)
        {
            _repositoryProduct = repositoryProduct;
        }
    }
}
