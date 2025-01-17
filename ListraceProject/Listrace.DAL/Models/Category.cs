using Listrace.DAL.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listrace.DAL.Models
{
    public class Category : BaseAuditableEntity
    {
        public string Title { get; set; }
        public ICollection<Places> Places { get; set; }
    }
}
