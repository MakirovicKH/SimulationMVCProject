using Plumberz.DAL.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plumberz.DAL.Models
{
    public class Expert : BaseAuditableEntity
    {
        public string Name { get; set; }
        public string Specialty { get; set; }  
        public string PhoneNumber { get; set; }
        public string ImageUrl { get; set; }

        public int DepartmentId { get; set; }

        public Department Department { get; set; }
    }
}
