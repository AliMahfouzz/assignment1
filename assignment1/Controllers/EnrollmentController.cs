using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using assignment1.Models;
namespace assignment1.Controllers
{
    public class EnrollmentController : Controller
    {
        private ApplicationDbContext _context;

        public EnrollmentController() {

            _context = new ApplicationDbContext();

        }
        
        // GET: Enrollment
        public ActionResult Index()
        {
            var enrollments = _context.enrollments.ToList();
            return View(enrollments);
        }
        [HttpGet]
        public ActionResult Create()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult Create(Enrollment enrollment)
        {
            _context.enrollments.Add(enrollment);
            _context.SaveChanges();
            return RedirectToAction("Index","Enrollment");
        }
    }
}