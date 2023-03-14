using Microsoft.AspNetCore.Mvc;
using System;

namespace Asp.ASPNETCore_CRUD.Controllers
{
    public class NewsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public class Student
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
        }

        public String StringOut(int id, Student student)
        {
            return $"Helo world {id} - {student.firstName} {student.lastName}   ";
        }
        
        public IActionResult Details(int id, Student student)
        {
            var obj = new { ID = id, Student = student };
            return Json(obj);
        }

    }
}
