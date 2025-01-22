using MICO.DAL.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MICO.DAL.Context
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions option) :base(option)
        {
            
        }
        public DbSet<Departments> Departments { get; set; }
        public DbSet<Doctors> Doctors { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }

    }
}
