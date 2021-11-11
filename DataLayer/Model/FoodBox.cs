using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Model
{
    public class FoodBox
    {
        public int ID { get; set; }
        [Required] [MaxLength(30)] public string Name { get; set; }
        [Required] [MaxLength(30)] public string Type { get; set; }
        [Required] [Column(TypeName = "smallmoney")] public decimal Price { get; set; }

        [Required] public virtual Restaurant restaurant { get; set; }
        public virtual Customer customer { get; set; }
    }
}