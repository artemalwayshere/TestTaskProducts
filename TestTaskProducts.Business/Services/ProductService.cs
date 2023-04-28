using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTaskProducts.DAL.Data;
using TestTaskProducts.DAL.Models;

namespace TestTaskProducts.Business.Services
{
    public class ProductService : IProductService
    {
        private readonly IRepository _repo;

        public ProductService(IRepository repo)
        {
            _repo = repo;
        }

        public List<QueryModel> GetProductsWithCategories()
        {
            return _repo.GetAllProductWithCategories().Result;
        }
    }
}
