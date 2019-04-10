using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace assignment1.Models
{
    public class Enrollment
    {
        [Key]
        public int TermCode { get; set; }
        public Student Student { get; set; }
        public int StudentID { get; set; }
        public courses course { get; set; }
        public int courseID { get; set; }
        public int MajorID { get; set; }
        public int Grade { get; set; }
        public Boolean EnrolledIndicator { get; set; }
        public Boolean PaymentIndicator { get; set; }
    }
}