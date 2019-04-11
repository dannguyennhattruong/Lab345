using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Lab345.Data;
using Lab345.Models;
using Lab345.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lab345.Controllers
{
    public class CheeseController : Controller
    {
        public readonly Database _database;
        public CheeseController(Database database)
        {
            _database = database;
        }
        // GET: /<controller>/           
        public IActionResult Index(string sortOrder, string searchString, string currentFilter, int? page)
        {
            ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }
            ViewData["CurrentFilter"] = searchString;
            CheeseListViewModel model = new CheeseListViewModel()
            {
                // Cheeses = CheeseData.GetAll()                 
                Cheeses = _database.Cheeses
            };
            if (!String.IsNullOrEmpty(searchString))
            {
                model.Cheeses = model.Cheeses.Where(s => s.Name.ToLower().Contains(searchString.ToLower())).ToList();
            }
            switch (sortOrder)
            {
                case "name_desc":
                    model.Cheeses = model.Cheeses.OrderByDescending(s => s.Name).ToList();
                    break;
                case "country_desc":
                    model.Cheeses.OrderByDescending(s => s.Name);
                    break;
                case "year_desc":
                    model.Cheeses.OrderByDescending(s => s.Name);
                    break;
            }
            int pageSize = 3;
            return View(PaginatedCheeseList<Cheese>.Create(model.Cheeses.AsQueryable(), page ?? 1, pageSize));
        }

        /*public IActionResult Add()
        {
            CheeseViewModel addCheeseViewModel = new CheeseViewModel();
            return View(addCheeseViewModel);
        }
        [HttpPost]
        public IActionResult Add(CheeseViewModel newCheeseVM, IFormFile photo)
        {
            if (ModelState.IsValid)
            {
                Cheese newCheese = new Cheese();
                if (photo == null || photo.Length == 0)
                {
                    newCheese.Photo = "image_tb.png";
                }
                else
                {
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images", photo.FileName);
                    var stream = new FileStream(path, FileMode.Create);
                    photo.CopyToAsync(stream);
                    newCheese.Photo = photo.FileName;
                }
                newCheese.Name = newCheeseVM.Name;
                newCheese.Descriptions = newCheeseVM.Descriptions;
                newCheese.Country = newCheeseVM.Country;
                newCheese.Price = newCheeseVM.Price;
                newCheese.Quantity = newCheeseVM.Quantity;
                newCheese.Type = newCheeseVM.Type;



                _database.Cheeses.Add(newCheese);
                return RedirectToAction("Index");
            }
            else
            {
                return View(newCheeseVM);
            }
        }*/

        public IActionResult Detail(int id)
        {
            //var cheese = CheeseData.GetCheeseById(id);             
            var cheese = _database.Cheeses.FirstOrDefault(ch => ch.CheeseId == id);
            return View(cheese);
        }
        /*public IActionResult Edit(int id)
        {
            var cheese = _database.Cheeses.FirstOrDefault(ch => ch.CheeseId == id);
            CheeseViewModel cheeseViewModel = new CheeseViewModel()

            {
                Name = cheese.Name,
			Descriptions = cheese.Descriptions,                 
			Country = cheese.Country,                 
			Year = cheese.Year,                 
			Price = cheese.Price,               
			Quantity = cheese.Quantity

            };
            return View(cheeseViewModel);
        }

        [HttpPost]
        public IActionResult Edit(int id, CheeseViewModel newCheese)
        {             //CheeseData.Update(id, newCheese); 


            var cheese = _database.Cheeses.FirstOrDefault(ch => ch.CheeseId == id);
            cheese.Name = newCheese.Name;
            cheese.Descriptions = newCheese.Descriptions;
            cheese.Country = newCheese.Country;
            cheese.Year = newCheese.Year;
            cheese.Price = newCheese.Price;
            cheese.Quantity = newCheese.Quantity;
            cheese.Type = newCheese.Type;
            cheese.CreateOn = DateTime.Now;
            ViewBag.status = 1;
            return View(newCheese);
        }

        [HttpGet]
        [HttpPost]
        public IActionResult Delete(int id)
        {
            _database.Cheeses.RemoveAll(ch => ch.CheeseId == id);
            return Ok();
        }*/

    }
}
