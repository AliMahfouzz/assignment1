using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace assignment1.Models
{
    public class Student
    {
        public int ID { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public int AdmissionTermCode { get; set; }
        public DateTime? date { get; set; }
        public Admission Admission { get; set; }
        public int AdmissionMajorID { get; set; }



    }
}