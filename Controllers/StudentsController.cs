using CourseRegistration.Models;
using Microsoft.AspNetCore.Mvc;

namespace CourseRegistration.Controllers
{
    public class StudentsController : Controller
    {
        public IActionResult Students()
        {
            StudentsViewModel svm = new StudentsViewModel();
            List<DTO.Students> students = new List<DTO.Students>()
            {
                new DTO.Students {Id = 1, FirstName = "John", LastName = "Smith", EmailAdd = "johnsmith@yahoo.com", PhoneNumber = 123456},
                new DTO.Students {Id = 2, FirstName = "Jane", LastName = "Smith", EmailAdd = "janesmith@yahoo.com", PhoneNumber = 1234567}
            };

            svm.Students = students;
            return View(svm);
        }
    }
}
