using Education.DAL.Contexts;
using Education.DAL.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using Plumberz.DAL.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education.DAL.Repository.Implementations
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        readonly AppDbContext _context; 
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

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await Table.ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
           return await Table.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<int> SaveChangesAsync()
        {
           return await _context.SaveChangesAsync();
        }

        public void Update(T entity)
        {
            Table.Update(entity);
        }
    }
}
