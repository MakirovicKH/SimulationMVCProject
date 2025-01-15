using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education.BL.DTOs.NewsDTO
{
    public class AddNewsDTO
    {
        [MaxLength(100)]
        public string Title { get; set; }
        public string Content { get; set; }
        public IFormFile Image { get; set; }
    }
}
