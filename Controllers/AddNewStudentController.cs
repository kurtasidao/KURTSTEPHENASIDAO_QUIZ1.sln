using KURTSTEPHENASIDAO_QUIZ1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KURTSTEPHENASIDAO_QUIZ1.Controllers
{
    public class AddNewStudentController : Controller
    {
        private object context;

        public ActionResult Index()
        {
            var addnewstudent = context;
            return View();
        }
        public ActionResult AddNewStudent()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddNewStudent(Student students)
        {
            context.students.Add(students);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}