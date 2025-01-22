using MICO.DAL.Context;
using MICO.DAL.Models;
using MICO.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MICO.DAL.Repositories.Implementations
{
    public class DoctorsRepository : GenericRepository<Doctors>, IDoctorsRepository
    {
        public DoctorsRepository(AppDbContext context) :base(context)
        {
            
        }
    }
}
