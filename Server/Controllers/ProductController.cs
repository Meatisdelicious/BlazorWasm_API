using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static BlazorWasm_API.Shared.Product;
using Microsoft.Build.Tasks.Deployment.Bootstrapper;

namespace BlazorWasm_API.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private ProductService _productService;
        public ProductController(ProductService productService)
        {
            _productService = productService;
        }

        public ProductService Get_productService()
        {
            return _productService;
        }

        [HttpGet]
        [Route("GetProducts")]
        public ActionResult<List<Product>> GetProducts()
        {
            return _productService.GetProducts();
        }
        [HttpPost]
        [Route("AddProduct")]
        public ActionResult AddProduct([FromBody]Product product)
        {
            _productService.AddProduct(product);
            return Ok();
        }
        [HttpDelete]
        [Route("DeleteProduct")]
        public ActionResult DeleteProduct([FromQuery]string productCode)
        {
            _productService.DeleteProduct(productCode);
            return Ok();
        }
    }
}
