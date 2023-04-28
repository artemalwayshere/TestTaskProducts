using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTaskProducts.DAL.Models;

namespace TestTaskProducts.Business.Services
{
    public interface IProductService
    {
        List<QueryModel> GetProductsWithCategories();
    }
}
