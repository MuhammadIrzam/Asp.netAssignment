using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myproject.Models
{
    public class MyDbContext:DbContext
    {
        MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }
        public DbSet<Join> joins { get; set; }
        public DbSet<Course> course { get; set; }
        public DbSet<Assignment> assignment { get; set; }
        public DbSet<User> users { get; set; }
    }
}
