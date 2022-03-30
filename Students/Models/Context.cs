using Microsoft.EntityFrameworkCore;
using Students.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Students.Models
{
    public class Context :DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
    
}