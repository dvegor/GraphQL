using Seminar3.Abstractions;
using Seminar3.Contracts.Requests.Products;
using Seminar3.Contracts.Responses;
using Microsoft.AspNetCore.Mvc;


namespace Seminar3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductServices _productServices;

        public ProductController(IProductServices productServices)
        {
            _productServices = productServices;
        }

        [HttpGet]
        [Route("products/{id}")]
        public ActionResult<ProductResponse> GetProductById(int id)
        {
            var product = _productServices.GetProductById(id);

            return Ok(product);
        }

        [HttpGet]
        [Route("products")]
        public ActionResult<IEnumerable<ProductResponse>> GetProducts()
        {
            var products = _productServices.GetProducts();

            return Ok(products);
        }

        [HttpPost]
        [Route("create")]
        public ActionResult<int> AddProducts(ProductCreateRequest request)
        {
            try
            {
                var id = _productServices.AddProduct(request);
                return Ok(id);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}