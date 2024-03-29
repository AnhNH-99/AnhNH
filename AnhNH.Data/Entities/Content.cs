﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnhNH.Data.Entities
{
    public class Content
    {
        public int Id { get; set; }
        public int ChapterId { get; set; }
        public string? Name { get; set; }
        public string? BaseImage { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
        public Boolean DeletedFlag { get; set; }
        public Chapter? Chapter { get; set; }
    }
}
