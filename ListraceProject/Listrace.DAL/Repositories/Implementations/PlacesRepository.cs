using Listrace.DAL.Contexts;
using Listrace.DAL.Models;
using Listrace.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listrace.DAL.Repositories.Implementations
{
    public class PlacesRepository : GenericRepository<Places>, IPlacesRepository
    {
        public PlacesRepository(AppDbContext context) : base(context)
        {
            
        }
    }
}
