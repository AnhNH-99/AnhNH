﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnhNH.Application.ViewModels.Stories.Manages
{
    public class StoryUpdateRequest
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public int Status { get; set; }
        public int Author { get; set; }
    }
}
