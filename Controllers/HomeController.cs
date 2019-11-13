using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProductsAndCategories.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace ProductsAndCategories.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;
        public HomeController(MyContext context)
        {
            dbContext = context;
        }
        [HttpGet("products")]
        public IActionResult AddProductPage()
        {
            ProductViewModel ViewModel = new ProductViewModel()
            {
                AllProducts = dbContext.Products.ToList()
            };
            return View(ViewModel);
        }
        [HttpPost]
        public IActionResult NewProduct(ProductViewModel modelData)
        {
            if (ModelState.IsValid)
            {
                Product newProduct = modelData.NewProduct;
                dbContext.Add(newProduct);
                dbContext.SaveChanges();
                return RedirectToAction("AddProductPage", new {productid = newProduct.ProductId});
            }
            modelData.AllProducts = dbContext.Products.ToList();
            return View("AddProductPage", modelData);
            
        }
        [HttpGet("categories")]
        public IActionResult AddCategoryPage()
        {
            CategoryViewModel ViewModel = new CategoryViewModel()
            {
                AllCategories = dbContext.Categories.ToList()
            };
            return View(ViewModel);
        }
        [HttpPost]
        public IActionResult NewCategory(CategoryViewModel modelData)
        {
            if (ModelState.IsValid)
            {
               Category newCategory = modelData.NewCategory;
                dbContext.Add(newCategory);
                dbContext.SaveChanges();
                return RedirectToAction("AddCategoryPage", new { categoryid = newCategory.CategoryId }); 
            }
            modelData.AllCategories = dbContext.Categories.ToList();
            return View("AddCategoryPage", modelData);
            

        }
        [HttpGet("products/{productid}")]
        public IActionResult ProductPage(int productid)
        {
            ProductAndCategoriesViewModel ViewModel = new ProductAndCategoriesViewModel()
            {
                TheProduct = dbContext.Products.Where(p => p.ProductId == productid).Include(p => p.Categories).ThenInclude(p => p.Category).FirstOrDefault(),
                NonAssociatedCategories = dbContext.Categories.Where(c => c.Products.All(p => p.ProductId != productid)).ToList()
            };

            return View(ViewModel);
        }
        [HttpPost]
        public IActionResult AddCategory(ProductAndCategoriesViewModel modelData)
        {
            if (ModelState.IsValid)
            {
                Association newAssociation = modelData.NewAssociation;
                Console.WriteLine("**********************HELLO**************************");
                Console.WriteLine(ModelState.ErrorCount);
                Console.WriteLine(JsonConvert.SerializeObject(ModelState.Keys));
                Console.WriteLine(JsonConvert.SerializeObject(ModelState.Values));
                Console.WriteLine(ModelState.ValidationState);
                dbContext.Add(newAssociation);
                dbContext.SaveChanges();


                return RedirectToAction("ProductPage", new { productid = newAssociation.ProductId }); 
            }
        
        return View("ProductPage",modelData);
            
        }
        [HttpGet("categories/{categoryid}")]
        public IActionResult CategoryPage(int categoryid)
        {
            CategoryAndProductsViewModel ViewModel = new CategoryAndProductsViewModel()
            {
                TheCategory = dbContext.Categories.Where(c => c.CategoryId == categoryid).Include(c => c.Products).ThenInclude(c => c.Product).FirstOrDefault(),
                NonassociatedProducts = dbContext.Products.Where(p => p.Categories.All(c => c.CategoryId != categoryid)).ToList()
            };
            return View(ViewModel);
        }
        [HttpPost]
        public IActionResult AddProduct(CategoryAndProductsViewModel modelData)
        {
            if (ModelState.IsValid)
            {
                Association newAssociation = modelData.NewAssociation;
                dbContext.Add(newAssociation);
                dbContext.SaveChanges();
                return RedirectToAction("CategoryPage", new {categoryid = newAssociation.CategoryId}); 
            }
            return View("CategoryPage", modelData);
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
