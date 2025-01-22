using MICO.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MICO.BL.Services.Interfaces
{
    public interface IDepartmentsService
    {
        Task<IEnumerable<Departments>> GetAllAsync();
        Task<Departments> GetByIdAsync(int id);
        Task<Departments> AddAsync(Departments entity);
        void Delete(Departments entity);
        void Update(Departments entity);
        Task<int> SaveChangesAsync();
    }
}
