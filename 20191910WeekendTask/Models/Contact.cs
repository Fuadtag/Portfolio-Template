using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace _20191910WeekendTask.Models
{
    public class Contact
    {
        public int Id{ get; set; }
        public string Adress{ get; set; }
        
        public string Phone { get; set; }
        public string Email{ get; set; }
        public string Description { get; set; }
        public string LinkedinLink { get; set; }
        public string FacebookLink { get; set; }
        public string GithubLink{ get; set; }
        public string TwitterLink { get; set; }

    }
}