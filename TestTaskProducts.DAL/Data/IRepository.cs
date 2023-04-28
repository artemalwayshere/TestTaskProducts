using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTaskProducts.DAL.Models;

namespace TestTaskProducts.DAL.Data
{
    public interface IRepository
    {
        Task<List<QueryModel>> GetAllProductWithCategories();
    }
}
