﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Model
{
    public class Restaurant
    {
        public int ID { get; set; }
        [Required] [MaxLength(30)] public string Name { get; set; }
        [MaxLength(30)] public string Username { get; set; }
        [MaxLength(30)] public string Password { get; set; }

        public virtual ICollection<FoodBox> FoodBoxes { get; set; }
    }
}