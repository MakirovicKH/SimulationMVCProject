using Listrace.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listrace.DAL.Contexts
{
    public class AppDbContext : DbContext
    {
        public DbSet<Places> Places { get; set; }
        public DbSet<Category> Categories { get; set; }
        
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
    }
}
