using Education.DAL.Contexts;
using Education.DAL.Models;
using Education.DAL.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education.DAL.Repository.Implementations
{
    public class NewsRepository : GenericRepository<News>, INewsRepository
    {
        public NewsRepository(AppDbContext context) : base(context)
        {
        }
    }
}
