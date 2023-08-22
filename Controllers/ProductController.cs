using Microsoft.AspNetCore.Mvc;
using RepositoryApp.Data;
using RepositoryApp.Interfaces.Manager;
using RepositoryApp.Manager;
using RepositoryApp.Models;

namespace RepositoryApp.Controllers
{
    public class ProductController : Controller
    {
        private IProductManager _productManager;
        //create constructor 
        public ProductController(ProductManager productManager  )
        {

            _productManager = productManager;
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

        public ActionResult Edit(int id)
        {
            var product= _productManager.GetById(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        [HttpPost]
        public ActionResult Edit(Product product)
        {
            string messe = "";
            bool isUpdate = _productManager.Update(product);
            if (isUpdate)
            {
                return RedirectToAction("Index");
            }
            else
            {
                messe = "Product not update";
            }

            ViewBag.Messege = messe;


            return View(product);
        }

        public ActionResult Details(int id)
        {
            var product = _productManager.GetById( id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        public ActionResult Delete(int id) {

            var product = _productManager.GetById(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        
        }

        [HttpPost]
        public ActionResult Delete(Product product)
        { 

            bool isDeleted=_productManager.Delete(product);
            if (isDeleted)
            {
                return RedirectToAction("Index");
            }

        return View();
        
        }

    }
}
