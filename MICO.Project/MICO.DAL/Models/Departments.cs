﻿using MICO.DAL.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MICO.DAL.Models
{
    public class Departments : BaseAuditableEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image {  get; set; }


        public ICollection<Doctors> Doctors { get; set; }
    }
}
