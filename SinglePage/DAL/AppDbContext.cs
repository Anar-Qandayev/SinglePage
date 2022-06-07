using Microsoft.EntityFrameworkCore;
using SinglePage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SinglePage.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions  options):base(options)
        {

        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Award> Awards { get; set; }
        public DbSet<Interest> Interests { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Education> Educations { get; set; }
    }
}
