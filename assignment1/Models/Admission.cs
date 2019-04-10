using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace assignment1.Models
{
    public class Admission
    {
        public int ID { get; set; }
        public int AdmissionTermCode { get; set; }
        public String  AdmissionName{ get; set; }
        public int  MajorID{ get; set; }
        public int  DepartmentID{ get; set; }
    }
}