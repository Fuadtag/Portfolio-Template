using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace _20191910WeekendTask.Models
{
    public class Experience
    {
        [Required]
        public int Id { get; set; }
        
        public string Position { get; set; }
        public string Company { get; set; }
        public DateTime StartDate { get; set; }
        
        public DateTime? EndDate{ get; set; }
        public string Description { get; set; }
    }
}