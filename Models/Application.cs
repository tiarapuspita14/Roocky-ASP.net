﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace roocky.Models
{
    public class Application
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
