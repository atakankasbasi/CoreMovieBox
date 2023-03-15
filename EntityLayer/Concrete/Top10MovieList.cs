﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Top10MovieList
    {
        [Key]
        public int MovieID { get; set; }
        public string Image { get; set; }
    }
}