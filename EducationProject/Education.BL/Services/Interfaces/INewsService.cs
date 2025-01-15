using Education.BL.DTOs.NewsDTO;
using Education.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education.BL.Services.Interfaces
{
    public interface INewsService
    {
        public Task<News> AddNews(AddNewsDTO addNewsDTO);
        public Task<IEnumerable<News>> GetAllNews();   
        public Task<GetNewsDTO> GetNewsByIdAsync(int id);
        public Task UpdateAsync(AddNewsDTO addNewsDTO);
        public Task DeleteAsync(int id);

    }
}
