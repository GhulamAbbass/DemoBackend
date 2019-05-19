using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrackingWorldDemo.Models
{
    public class Product
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public uint Price { get; set; }
        [Required]
        public string Brand { get; set; }
        [Required]
        public string Seller { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Features { get; set; }
     }
}