using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BelajarASPNetMVC.Data.Databases;

namespace BelajarASPNetMVC.Data
{
    public class AppDbContext: DbContext
    {
        // DbSet Here
        public DbSet<Company> Company { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}
