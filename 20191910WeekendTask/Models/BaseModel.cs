using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _20191910WeekendTask.Models
{
    public class BaseModel
    {
        public int Id { get; set; }
        public List<Award> Awards { get; set; }
        public Contact Contact { get; set; }
        public List<Education> Educations { get; set; }
        public List<Experience> Experiences { get; set; }
        public List<Interests> Interests { get; set; }
        public List<Skills> Skills { get; set; }
    }
}