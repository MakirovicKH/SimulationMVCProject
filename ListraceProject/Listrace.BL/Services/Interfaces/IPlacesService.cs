using Listrace.BL.DTOs.PlacesDTOs;
using Listrace.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Listrace.BL.Services.Interfaces
{
    public interface IPlacesService
    {
        public Task<Places> AddPlaces(AddPlacesDTO addPlacesDTO);
        public Task<ICollection<Places>> GetAllPlaces();
        public Task<GetPlacesDTO> GetPlacesByIdAsync(int id);
        public Task UpdateAsync(UpdatePlacesDTO updatePlacesDTO);
        public Task DeleteAsync(int id);
        Task<int> SaveChangesAsync(int id);

    }
}
