using AutoMapper;
using Education.BL.DTOs.NewsDTO;
using Education.BL.Services.Interfaces;
using Education.DAL.Models;
using Education.DAL.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education.BL.Services.Implementations
{
    public class NewsService : INewsService
    {
        readonly INewsRepository _repository;
        readonly IMapper _mapper;
        readonly DbContext _context;
        
        public NewsService(INewsRepository repository, IMapper mapper,DbContext context)
        {
            _repository = repository;
            _mapper = mapper;
            _context = context;
         
        }
        public async Task<News> AddNews(AddNewsDTO addNewsDTO)
        {
            var folder = Path.Combine("wwwroot", "UploadImage");
            var pathToSave =  Path.Combine(Directory.GetCurrentDirectory(), folder);
            if (!Directory.Exists(pathToSave))
            {
                Directory.CreateDirectory(pathToSave);
            }

            var filename = addNewsDTO.Image.FileName;
            var fullPath = Path.Combine(pathToSave, filename);
            if (File.Exists(pathToSave))
            {
                filename = Path.GetFileNameWithoutExtension(filename) + Guid.NewGuid + Path.GetExtension(filename);
            }

            News news =  _mapper.Map<News >(addNewsDTO);
            news.ImageURL = filename;
            news.CreatedDate = DateTime.Now;
            News createnews = await  _repository.AddAsync(news);
          await  _context.SaveChangesAsync();
            return createnews;

        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<News>> GetAllNews()
        {
            throw new NotImplementedException();
        }

        public Task<GetNewsDTO> GetNewsByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(AddNewsDTO addNewsDTO)
        {
            throw new NotImplementedException();
        }
    }
}
