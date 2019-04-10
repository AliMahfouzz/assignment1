using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using assignment1.Models;

namespace assignment1.Controllers
{
    public class CourseController : Controller
    {
        private ApplicationDbContext _context;

        public CourseController() {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Course
        public ActionResult Index()
        {
            var courses = _context.courses.ToList();
            return View(courses);
        }
        public ActionResult Create(courses course)
        {
            _context.courses.Add(course);
            _context.SaveChanges();
            return View();
        }
    }
}