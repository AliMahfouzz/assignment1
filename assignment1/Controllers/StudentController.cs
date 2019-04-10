using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using assignment1.Models;

namespace assignment1.Controllers
{
    public class StudentController : Controller
    {
        private ApplicationDbContext _context;

        public StudentController() {

            _context = new ApplicationDbContext();

        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Student
        public ActionResult Index()
        {
            var students = _context.students.ToList();
            return View(students);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Student student)
        {
            _context.students.Add(student);
            _context.SaveChanges();

            return RedirectToAction("Index","Student");
        }

        
    }
}