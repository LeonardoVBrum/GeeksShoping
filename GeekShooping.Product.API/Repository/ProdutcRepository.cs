using GeekShooping.Product.API.Context;
using GeekShooping.Product.API.Dtos;
using GeekShooping.Product.API.Model;
using Microsoft.EntityFrameworkCore;

namespace GeekShooping.Product.API.Repository
{
    public class ProdutcRepository : IProductReoisitory
    {
        private readonly GeekContext _context;

        public ProdutcRepository(GeekContext context)
        {
            _context = context;
        }

        public Task<ProductDto> Create(ProductDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ProductModel>> FindAll()
        {

            var list = await _context.Products.ToListAsync();

            return list;
        }

        public async Task<ProductDto> FindById(int Id)
        {
            var prod = await _context.Products.FirstOrDefaultAsync(p => p.Id == Id);

            if (prod == null)
            {
                return null;

            }
            var dto = new ProductDto
            {
                Id = prod.Id,
                Name = prod.Name,
                Price = prod.Price,
                Description = prod.Description,
                CategoryName = prod.CategoryName,
                ImageUrl = prod.ImageUrl
            };

            return dto;


        }

        public async Task<ProductDto> Update(ProductDto dto)
        {
            var prod = await _context.Products.FirstOrDefaultAsync(p => p.Id == dto.Id);

            if (prod == null)
            {
                return null;

            }


            prod.Id = dto.Id;
            prod.Name = dto.Name;
            prod.Price = dto.Price;
            prod.Description = dto.Description;
            prod.CategoryName = dto.CategoryName;
            prod.ImageUrl = dto.ImageUrl;

            await _context.SaveChangesAsync();
            
            return dto;
        }


    }
}
