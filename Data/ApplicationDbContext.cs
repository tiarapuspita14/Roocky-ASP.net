using Microsoft.EntityFrameworkCore;
using roocky.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace roocky.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options) // untuk implement dbcontextoption supaya bisa konek ke connection string
        {

        }
        public DbSet<Category> Category { get; set; } // properties untuk konek ke kelas Category (kelas model)
        public DbSet<Application> Application { get; set; } // prop unutk konek ke kelas Application
    }
}
