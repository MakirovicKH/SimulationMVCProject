using Listrace.DAL.Contexts;
using Listrace.DAL.Models.Base;
using Listrace.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listrace.DAL.Repositories.Implementations
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
       private readonly AppDbContext _context;
        public GenericRepository(AppDbContext context)
        {
            _context = context;
        }
        
        DbSet<T> Table => _context.Set<T>();

        public async Task<T> AddAsync(T entity)
        {
           await Table.AddAsync(entity);
            return entity;
        }

        public void Delete(T entity)
        {
            Table.Remove(entity);
        }

        public async Task<ICollection<T>> GetAllAsync()
        {
           return await Table.ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
          return await Table.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<int> SaveChangesAsync(int id)
        {
            return await _context.SaveChangesAsync();
        }

        public void Update(T entity)
        {
           Table.Update(entity);
        }
    }
}
