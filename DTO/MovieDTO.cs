﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MovieDTO
    {
        public int MovieID { get; set; }
        public string MovieName { get; set; }
        public string MovieDescription { get; set; }
        public int MovieDuration { get; set; }
        public string ImageLink { get; set; }
    }
}
