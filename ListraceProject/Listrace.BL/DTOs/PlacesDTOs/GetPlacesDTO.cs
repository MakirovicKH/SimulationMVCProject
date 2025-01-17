using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listrace.BL.DTOs.PlacesDTOs
{
    public class GetPlacesDTO
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public int RaitingCount { get; set; }
        public float Point { get; set; }
        public decimal MinimalPrice { get; set; }
        public decimal MaximalPrice { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public bool isDeleted { get; set; } = false;
    }
}
