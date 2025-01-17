using Listrace.DAL.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listrace.DAL.Models
{
    public class Places : BaseAuditableEntity
    {
        public string Title { get; set; }
        public string Description { get; set; } 
        public string ImageURL { get; set; }
        public int RaitingCount { get; set; }
        public float Point {  get; set; }
        public decimal MinimalPrice { get; set; }
        public decimal MaximalPrice { get; set; }
        public Category Category { get; set; }  
        public int CategoryId { get; set; }

    }
}
