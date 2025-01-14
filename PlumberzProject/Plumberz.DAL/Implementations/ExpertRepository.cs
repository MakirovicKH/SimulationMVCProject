using Plumberz.DAL.Contexts;
using Plumberz.DAL.Interfaces;
using Plumberz.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plumberz.DAL.Implementations
{
    public class ExpertRepository : Repository<Expert>, IExpertRepository
    {
        public ExpertRepository(AppDbContext context) : base(context)
        {
        }
    }
}
