using EF.Core.Repository.Interface.Manager;
using RepositoryApp.Models;

namespace RepositoryApp.Interfaces.Manager
{
    public interface IProductManager:ICommonManager<Product>
    {
        Product GetById(int id);
    }
}
