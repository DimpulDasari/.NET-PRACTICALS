using Product_cataglog.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using static System.Net.WebRequestMethods;

namespace Product_cataglog.Controllers
{
    public class ProductDetailsController : Controller
    {
        public ActionResult Index()
        {
            List<product> products = GetProducts();

            return View("index", products);
        }
        public ActionResult Details(int id)
        {
            List<product> products = GetProducts();

            product selectedProduct = products.FirstOrDefault(p => p.ProductId == id);

            if (selectedProduct == null)
            {
                return HttpNotFound();
            }

            return View("Details", selectedProduct);
        }
        private List<product> GetProducts()
        {
            return new List<product>()
            {
                new product
                {
                    ProductId = 1,
                    Image = "https://images.unsplash.com/photo-1496181133206-80ce9b88a853?w=500",
                    ProductName = "Laptop",
                    ProductCategory = "Electronics",
                    ProductPrice = 55000
                },

                new product
                {
                    ProductId = 2,
                    Image = "https://images.unsplash.com/photo-1496181133206-80ce9b88a853?w=500",
                    ProductName = "Mobile Phone",
                    ProductCategory = "Electronics",
                    ProductPrice = 25000
                },

                new product
                {
                    ProductId = 3,
                    Image = "https://images.unsplash.com/photo-1496181133206-80ce9b88a853?w=500",
                    ProductName = "Headphones",
                    ProductCategory = "Accessories",
                    ProductPrice = 2000
                },

                new product
                {
                    ProductId = 4,
                    Image = "https://images.unsplash.com/photo-1496181133206-80ce9b88a853?w=500",
                    ProductName = "Smart Watch",
                    ProductCategory = "Accessories",
                    ProductPrice = 5000
                }
            };
        }
    }
}