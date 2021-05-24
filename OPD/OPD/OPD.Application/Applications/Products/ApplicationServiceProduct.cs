using OPD.Application.Dtos.Products;
using OPD.Application.Interfaces.Mappers.Products;
using OPD.Application.Interfaces.Products;
using OPD.Domain.Core.Interfaces.Services.Products;
using System.Collections;

namespace OPD.Application.Applications.Products
{
    public class ApplicationServiceProduct : IApplicationServiceProduct
    {
        private readonly IServiceProduct _serviceProduct;
        private readonly IMapperProduct _mapperProduct;

        public ApplicationServiceProduct(IServiceProduct serviceProduct,
                                          IMapperProduct mapperProduct)
        {
            _serviceProduct = serviceProduct;
            _mapperProduct = mapperProduct;
        }

        public void Create(ProductDto productDto)
        {
            var product = _mapperProduct.MapperDtoToEntity(productDto);
            _serviceProduct.Create(product);
        }

        public void Update(ProductDto productDto)
        {
            var product = _mapperProduct.MapperDtoToEntity(productDto);
            _serviceProduct.Update(product);
        }

        public void Delete(ProductDto productDto)
        {
            var product = _mapperProduct.MapperDtoToEntity(productDto);
            _serviceProduct.Delete(product);
        }

        public IEnumerable GetAll()
        {
            var products = _serviceProduct.GetAll();

            return _mapperProduct.MapperListCustumerDto(products);
        }

        public ProductDto GetById(int id)
        {
            var product = _serviceProduct.GetById(id);

            return _mapperProduct.MapperEntityToDto(product);
        }

    }
}
