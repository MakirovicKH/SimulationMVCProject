using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plumberz.BL.DTOs
{
    public class UpdateExpertDTO
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Specialty { get; set; }
        public string PhoneNumber { get; set; }
        public IFormFile Image { get; set; }
    }
}
