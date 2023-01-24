using Dapper.Contrib.Extensions;
using GroceryStore.Models;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStore.Controllers
{

    public class ProductController : Controller
    {
        static MySqlConnection db = new MySqlConnection("Server=localhost;Database=grocerystore;Uid=root;Password=abc727");
        public IActionResult Index()
        {
            List<Product> prods = db.GetAll<Product>().ToList();
            return View(prods);
        }

        public IActionResult Detail(int id )
        {
            Product prod = db.Get<Product>(id);
            //return Content($"Detail for {id}: {prod.name}");
            return View(prod);
        }

        public IActionResult EditForm(int id)
        {
            Product prod = db.Get<Product>(id);
            //return Content($"EditForm for {id}");
            return View(prod);
        }

        [HttpPost]
        public IActionResult Edit( Product prod)
        {
            db.Update(prod);

            //return Content("Edit");

            return RedirectToAction("Index");
        }

      
        public IActionResult Delete(int id)
        {
            Product prod = db.Get<Product>(id);
            db.Delete(prod);
            return RedirectToAction("Index");
        }

        public IActionResult AddForm()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Add(Product prod)
        {

            db.Insert(prod);

            return RedirectToAction("Index");
        }
    }
}
