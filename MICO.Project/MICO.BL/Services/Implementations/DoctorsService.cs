using AutoMapper;
using MICO.BL.Services.Interfaces;
using MICO.DAL.Models;
using MICO.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MICO.BL.Services.Implementations
{


    public class DoctorsService : IDoctorsService
    {
        private readonly IGenericRepository<Doctors> _repository; 
        private readonly IMapper _mapper;
        public DoctorsService(IGenericRepository<Doctors> repository,IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<Doctors> AddAsync(Doctors entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Doctors entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Doctors>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Doctors> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public void Update(Doctors entity)
        {
            throw new NotImplementedException();
        }
    }
}
