using ASPNETCore_CRUD.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;

namespace ASPNETCore_CRUD.Controllers
{

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var students = new List<Student>
            {
                new Student { ID = 1, Name= "haha", Email="haha@gmail.com"},
                new Student { ID = 2, Name= "haha", Email="haha@gmail.com"},
                new Student { ID = 3, Name= "haha", Email="haha@gmail.com"},
                new Student { ID = 4, Name= "haha", Email="haha@gmail.com"},
                new Student { ID = 5, Name= "haha", Email="haha@gmail.com"}
            };

            //1.View bag
            //ViewBag.Students = students; 

            //2.View data
            //ViewData["Students"] = students;

            //3.Model 

            return View(students);


        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(Contact formData)
        {
            if (!ModelState.IsValid)
            {
                return View(formData);
            }
            //return Json(formData);
            TempData["Message"] = "Thank you for your contact. We will contact soon";
            return RedirectToAction("Contact");
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
