using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CRUD.Models;


namespace CRUD.Controllers
{
    public class CrudsController : Controller
    {
        private CrudContext dbContext;

        public CrudsController (CrudContext context)
        {
            dbContext = context;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            List< Dishes> AllDishes = dbContext.Dishes.OrderByDescending(a=>a.Id).Take(5).ToList();
            
            System.Console.WriteLine(AllDishes);



            return View(AllDishes);
        }

        [HttpPost("create")]
        public IActionResult Create(Dishes newDishes){
            newDishes.CreatedAt = DateTime.Now;
            newDishes.UpdatedAt = DateTime.Now;
            dbContext.Add(newDishes);
            dbContext.SaveChanges();
            
            return RedirectToAction("Index");
        }

        [HttpGet("new")]
        public IActionResult New()
        {
            System.Console.WriteLine("hey wherer are you ");
            return View ();
        }
       
       [HttpGet("/{ID}")]
       public IActionResult Show(int ID)
       {
        Dishes Dish = dbContext.Dishes.Where(d => d.Id == ID).FirstOrDefault();
        
           return View("Show" ,Dish);
       }
       [HttpGet("delete/{ID}")]
       public IActionResult DeleteDish(int ID)
       {
            Dishes Dish = dbContext.Dishes.Where(d => d.Id == ID).FirstOrDefault();
    
    // Then pass the object we queried for to .Remove() on Users
    dbContext.Dishes.Remove(Dish);
    
    // Finally, .SaveChanges() will remove the corresponding row representing this User from DB 
    dbContext.SaveChanges();
    //    
    return RedirectToAction("Index");
       }

        [HttpGet("/edit/{ID}")]
        public IActionResult EditPage(int ID)
        {
            Dishes Dish = dbContext.Dishes.FirstOrDefault(d => d.Id == ID);

            return View("edit", Dish);
        }

        [HttpPost("/edit/{ID}")]
        public IActionResult Edit(Dishes dish, int ID){
            Dishes Dish = dbContext.Dishes.FirstOrDefault(d => d.Id == ID);
            Dish.Name=dish.Name;
            Dish.Chef=dish.Chef;
            Dish.Description=dish.Description;
            Dish.Tastiness=dish.Tastiness;
            Dish.Calories=dish.Calories;
            Dish.UpdatedAt=dish.UpdatedAt;
            return View("Show", Dish);
        }
    }
}
