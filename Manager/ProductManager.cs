using EF.Core.Repository.Interface.Manager;
using EF.Core.Repository.Interface.Repository;
using EF.Core.Repository.Manager;
using RepositoryApp.Data;
using RepositoryApp.Interfaces.Manager;
using RepositoryApp.Models;
using RepositoryApp.Repository;

namespace RepositoryApp.Manager
{
    public class ProductManager : CommonManager<Product>, IProductManager
    {
        public ProductManager(ApplicationDBContext dbContext) : base(new ProductRepository(dbContext))
        {
            // 
        }
    }
}

