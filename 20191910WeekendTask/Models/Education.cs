using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _20191910WeekendTask.Models
{
    public class Education
    {
        public int Id{ get; set; }
        public string University { get; set; }
        public string Degree { get; set; }
        public string Description { get; set; }
        public decimal GPA { get; set; }
    }
}