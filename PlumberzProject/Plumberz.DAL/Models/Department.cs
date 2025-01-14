using Plumberz.DAL.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plumberz.DAL.Models
{
    public class Department : BaseAuditableEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        // One-to-many relationship
        public ICollection<Expert> Experts { get; set; }
    }
}
