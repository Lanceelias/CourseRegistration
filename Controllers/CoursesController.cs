using Microsoft.AspNetCore.Mvc;
using CourseRegistration.Models;
using System.Diagnostics;

namespace CourseRegistration.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult Courses()
        {
            CoursesViewModel cvm = new CoursesViewModel();
            List<DTO.Courses> courses = new List<DTO.Courses>()
            {
                new DTO.Courses {Id = 1, CourseName = "P.E.", CourseNumber = 11, Description = "Physical Education"},
                new DTO.Courses {Id = 2, CourseName = "Science", CourseNumber =21, Description ="Science" }
            };

            cvm.Courses = courses;
            return View(cvm);
        }
    }
}
