﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Model
{
    public class Customer
    {
        public int ID { get; set; }
        [MaxLength(30)] public string Name { get; set; }

        public virtual ICollection<FoodBox> FoodBoxes { get; set; }
    }
}