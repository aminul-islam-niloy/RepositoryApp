using EF.Core.Repository.Repository;
using Microsoft.EntityFrameworkCore;
using RepositoryApp.Interfaces.Repository;
using RepositoryApp.Models;

namespace RepositoryApp.Repository
{
    public class ProductRepository : CommonRepository<Product>, IProductRepository
    {
        public ProductRepository(DbContext dbContext) : base(dbContext)
        {

        }
    }
}
