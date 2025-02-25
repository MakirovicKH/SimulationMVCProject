﻿using Plumberz.DAL.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education.DAL.Models
{
    public class News : BaseAuditableEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime PublishedDate { get; set; }
        public string ImageURL { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }

}
