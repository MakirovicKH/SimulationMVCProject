using AutoMapper;
using Listrace.BL.DTOs.PlacesDTOs;
using Listrace.BL.Services.Interfaces;
using Listrace.DAL.Models;
using Listrace.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listrace.BL.Services.Implementations
{
    public class PlacesService : IPlacesService
    {
        readonly IPlacesRepository _repository;
        readonly IMapper _mapper;
        public PlacesService(IPlacesRepository repository,IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public Task<Places> AddPlaces(AddPlacesDTO addPlacesDTO)
        {
            throw new NotImplementedException();
        }

        public  async Task DeleteAsync(int id)
        {
            var res = await GetPlacesByIdAsync(id);
            _repository.Delete(res);
        }

        public async Task<ICollection<Places>> GetAllPlaces()
        {
          ICollection<Places> res= await _repository.GetAllAsync();
            return res;
           
        }

        public async Task<Places> GetPlacesByIdAsync(int id)
        {
            var res = await _repository.GetByIdAsync(id);
            if(res is null)
            {
                throw new Exception("Entity not found");
            }
            _mapper.Map<Places>(res);
            return res;
        }

        public async Task<int> SaveChangesAsync(int id)
        {
          var items = await _repository.SaveChangesAsync(id);
            return items;
        }

        public async Task UpdateAsync(UpdatePlacesDTO updatePlacesDTO)
        {
            

        }

        Task<GetPlacesDTO> IPlacesService.GetPlacesByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
