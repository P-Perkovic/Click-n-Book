﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Click_and_Book.Models
{
    public class CityBlock
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
