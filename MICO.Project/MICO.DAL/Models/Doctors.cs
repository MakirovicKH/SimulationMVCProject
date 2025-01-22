using MICO.DAL.Models.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MICO.DAL.Models
{
    public class Doctors : BaseAuditableEntity
    {
        public string Name { get; set; }
        public string Image {  get; set; }
        public int DepartmentId { get; set; }


        public Departments Departments { get; set; }
        
    }
}
