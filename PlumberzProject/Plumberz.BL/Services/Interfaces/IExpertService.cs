using Plumberz.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plumberz.BL.Services.Interfaces
{
    public interface IExpertService
    {
        Task<IEnumerable<Expert>> GetAllAsync();
        Task<Expert> GetByIdAsync(int id);
        Task AddAsync(Expert entity);
        void UpdateAsync(Expert entity);
        void DeleteAsync(int id);
    }
}
