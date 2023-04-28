using Microsoft.EntityFrameworkCore;
using TestTaskProducts.DAL.Context;
using TestTaskProducts.DAL.Models;

namespace TestTaskProducts.DAL.Data
{
    public class Repository : IRepository
    {
        private readonly AppDbContext _context;

        public Repository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<QueryModel>> GetAllProductWithCategories()
        {
            var response = await (from p in _context.Products
                           join c in _context.Categories on p.CategoryId equals c.Id
                           select new QueryModel
                           { 
                              ProductName = p.Name,
                              CategoryName = c.Name
                           }).ToListAsync();

            return response;
        }
    }
}
