﻿using Plumberz.DAL.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education.DAL.Models
{
    public class Category : BaseAuditableEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<News> NewsItems { get; set; }
    }

}
