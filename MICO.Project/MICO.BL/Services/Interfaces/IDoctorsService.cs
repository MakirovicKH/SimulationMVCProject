using MICO.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MICO.BL.Services.Interfaces
{
    public interface IDoctorsService
    {

        Task<IEnumerable<Doctors>> GetAllAsync();
        Task<Doctors> GetByIdAsync(int id);
        Task<Doctors> AddAsync(Doctors entity);
        void Delete(Doctors entity);
        void Update(Doctors entity);
        Task<int> SaveChangesAsync();
    }
}
