using Students.Models.Concrete;
using Students.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Students.Controllers
{
    public class HomeController : Controller
    {

        StudentManager studentManager;
        public ActionResult Index()
        {
            studentManager = new StudentManager();
            var studentsValue = studentManager.GetAll();
            return View(studentsValue.OrderByDescending(x=>x.ID).ToList()); ;
        }



        [HttpGet]
        public ActionResult AddClient()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddClient(Student student)
        {
            studentManager = new StudentManager();
            studentManager.AddStudent(student);
            return RedirectToAction("Index");
        }

    }

}
