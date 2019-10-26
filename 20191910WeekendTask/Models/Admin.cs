using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace _20191910WeekendTask.Areas.Admin.Models
{
    public class Admin
    {
        public int Id { get; set; }
        
        public string Username { get; set; }
        public string Password { get; set; }
    }
}