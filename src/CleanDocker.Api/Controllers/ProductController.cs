using CleanDocker.Application;
using CleanDocker.Application.Contarcts;
using CleanDocker.Application.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace CleanDocker.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController(IProductService productService) : ControllerBase
    {
        [HttpGet(("get-all-product"))]
        public async Task<IActionResult> GetAllProducts(CancellationToken cancellationToken)
        {
            var res = await productService.GetAllProductAsync(cancellationToken);
            return Ok(res);
        }

        [HttpPost("add")]
        public async Task<IActionResult> AddProduct(ProductDto productDto, CancellationToken cancellationToken)
        {
            await productService.AddProductAsync(productDto, cancellationToken);
            return Created();
        }
    }
}
