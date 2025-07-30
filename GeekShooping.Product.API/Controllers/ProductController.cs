using GeekShooping.Product.API.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GeekShooping.Product.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductReoisitory _product;
        public ProductController(IProductReoisitory product)
        {
            _product = product;
        }

        [HttpGet("BuscarTodos")]
        public async Task<IActionResult> FindAll()
        {
            var resp = await _product.FindAll();
            return Ok(resp);
        }

        [HttpGet("BuscarPorId{id}")]
        public async Task<IActionResult> FindById(int id)
        {
            var res = await _product.FindById(id);
            return Ok(res);
        }

    }
}
