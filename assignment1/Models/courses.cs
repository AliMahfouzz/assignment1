using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace assignment1.Models
{
    public class courses
    {
        public int ID { get; set; }
        public String CourseName { get; set; }
        public int Credits { get; set; }
        public Admission Admission { get; set; } 
        public int AdmissionDepartmentID { get; set; }

    }
}