using OPD.Application.Dtos.Products;
using System.Collections;

namespace OPD.Application.Interfaces.Products
{
    public interface IApplicationServiceProduct
    {
        void Create(ProductDto productDto);

        void Update(ProductDto productDto);

        void Delete(ProductDto productDto);

        IEnumerable GetAll();

        ProductDto GetById(int id);
    }
}
