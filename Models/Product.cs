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
        public string PicAddress { get; set; } = "https://images.unsplash.com/photo-1556217256-f4e659e15103?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=701&q=80";

    }
}