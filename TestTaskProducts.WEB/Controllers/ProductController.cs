using Microsoft.AspNetCore.Mvc;
using TestTaskProducts.Business.Services;
using TestTaskProducts.DAL.Models;

namespace TestTaskProducts.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        /// <summary>
        /// Get all products with categories
        /// </summary>
        /// <returns>List of joined tables of products and categories</returns>
        [HttpGet]
        public async Task<List<QueryModel>> GetProductsWithCat()
        {
            return _productService.GetProductsWithCategories();
        }
    }
}