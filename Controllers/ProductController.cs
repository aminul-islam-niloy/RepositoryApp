using Microsoft.AspNetCore.Mvc;
using RepositoryApp.Data;
using RepositoryApp.Interfaces.Manager;
using RepositoryApp.Manager;
using RepositoryApp.Models;

namespace RepositoryApp.Controllers
{
    public class ProductController : Controller
    {
        ApplicationDBContext _dbContext;
        IProductManager _productManager;
        //create constructor 
        public ProductController(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
            _productManager=new ProductManager(dbContext);
        }

        public IActionResult Index()
        {
            var product = _productManager.GetAll();
            return View(product);
        }

        public IActionResult Create()
        {
            return View();
        }
       
        [HttpPost]
        public IActionResult Create(Product product)
        {

            string messe = "";
           bool isSaved = _productManager.Add(product);
            if (isSaved)
            {
                messe = "Product save";
            }
            else
            {
                messe = "Product save";
            }
           
            ViewBag.Messege = messe;
            return View();
        }
    }
}
