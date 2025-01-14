using Microsoft.EntityFrameworkCore;
using Plumberz.DAL.Contexts;
using Plumberz.DAL.Interfaces;
using Plumberz.DAL.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plumberz.DAL.Implementations
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly AppDbContext _context;
        public Repository(AppDbContext context)
        {
            _context = context;
        }

        DbSet<T> Table => _context.Set<T>();
        public async Task AddAsync(T entity)
        {
            await Table.AddAsync(entity);
        }

        public void DeleteAsync(T entity)
        {
            Table.Remove(entity);
        }

        public void DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            var items = await Table.ToListAsync();
            return items;
        }

        public async Task<T> GetByIdAsync(int id)
        {
            var item = await Table.FirstOrDefaultAsync(e=>e.Id==id);
            return item;
        }

        public void UpdateAsync(T entity)
        {
            Table.Update(entity);
        }
    }
}
