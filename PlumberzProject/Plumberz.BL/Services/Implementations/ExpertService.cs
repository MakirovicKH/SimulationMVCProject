using Plumberz.BL.Services.Interfaces;
using Plumberz.DAL.Interfaces;
using Plumberz.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plumberz.BL.Services.Implementations
{
    public class ExpertService : IExpertService
    {
        private readonly IExpertRepository _expertRepository;
        public ExpertService(IExpertRepository expertRepository)
        {
            _expertRepository = expertRepository;
        }
        public async Task AddAsync(Expert entity)
        {
            await _expertRepository.AddAsync(entity);
        }

        public async Task DeleteAsync(int id)
        {

            _expertRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<Expert>> GetAllAsync()
        {
            var items = await _expertRepository.GetAllAsync();
            return items;
        }

        public async Task<Expert> GetByIdAsync(int id)
        {
            var items = await _expertRepository.GetByIdAsync(id);
            return items;
        }


        

        public async Task UpdateAsync(Expert entity)
        {
           _expertRepository.UpdateAsync(entity);
        }

        void IExpertService.DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        void IExpertService.UpdateAsync(Expert entity)
        {
            throw new NotImplementedException();
        }
    }
}
