using Microsoft.AspNetCore.Mvc;
using CourseRegistration.Models;
using System.Diagnostics;

namespace CourseRegistration.Controllers
{
    public class InstructorsController : Controller
    {
        public IActionResult Instructors()
        {
            InstructorsViewModel ivm = new InstructorsViewModel();
            List<DTO.Instructors> instructors = new List<DTO.Instructors>()
            {
                new DTO.Instructors { Id = 1, FirstName = "John", LastName = "Doe", Courses = "P.E.", EmailAdd = "johndoe@yahoo", },
                new DTO.Instructors { Id = 2, FirstName = "Jane", LastName = "Doe", Courses = "Science", EmailAdd = "janedoe@yahoo", }
            };

            ivm.Instructors = instructors;
            return View(ivm);
        }

    }
}
