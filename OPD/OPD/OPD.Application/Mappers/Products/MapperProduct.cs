using OPD.Application.Dtos.Products;
using OPD.Application.Interfaces.Mappers.Products;
using OPD.Domain.Entities.Products;
using System.Collections.Generic;
using System.Linq;

namespace OPD.Application.Mappers.Products
{
    public class MapperProduct : IMapperProduct
    {
        public Product MapperDtoToEntity(ProductDto productDto)
        {
            return new Product()
            {
                Id = productDto.Id,
                Name = productDto.Name,
                Description = productDto.Description,
                Value = productDto.Value,
                Isavaliable = productDto.Isavaliable
            };
        }

        public ProductDto MapperEntityToDto(Product product)
        {
            return new ProductDto()
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Value = product.Value,
                Isavaliable = product.Isavaliable
            };
        }

        public IEnumerable<ProductDto> MapperListCustumerDto(IEnumerable<Product> products)
        {
            var dto = products.Select(x => new ProductDto
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
                Value = x.Value,
                Isavaliable = x.Isavaliable
            });

            return dto;
        }
    }
}
