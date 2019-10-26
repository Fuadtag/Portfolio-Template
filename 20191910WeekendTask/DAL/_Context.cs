using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using _20191910WeekendTask.Models;
using _20191910WeekendTask.Areas.Admin.Models;

namespace _20191910WeekendTask.DAL
{
    public class _Context : DbContext
    {
        public _Context() : base("TemplateDb")
        { }
            public DbSet<Award> Awards { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Interests> Interests { get; set; }
        public DbSet<Skills> Skills{ get; set; }
        public DbSet<Admin> Admins { get; set; }


    }
    

    
}