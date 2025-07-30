using GeekShooping.Product.API.Dtos;
using GeekShooping.Product.API.Model;

namespace GeekShooping.Product.API.Repository
{
    public interface IProductReoisitory
    {
        Task<IEnumerable<ProductModel>> FindAll();

        Task<ProductDto> FindById(int Id);

        Task<ProductDto> Create(ProductDto dto);

        Task<ProductDto> Update(ProductDto dto);

        Task<bool> Delete(int id);
    }
}
