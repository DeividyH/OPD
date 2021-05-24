using OPD.Application.Dtos.Products;
using OPD.Domain.Entities.Products;
using System.Collections.Generic;

namespace OPD.Application.Interfaces.Mappers.Products
{
    public interface IMapperProduct
    {
        Product MapperDtoToEntity(ProductDto productDto);

        IEnumerable<ProductDto> MapperListCustumerDto(IEnumerable<Product> products);

        ProductDto MapperEntityToDto(Product product);
    }
}
