 using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
namespace ProductsAndCategories.Models
{
    public class Product
    {
        [Key]
        public int ProductId{get;set;}
        [Required]
        public string Name{get;set;}
        [Required]
        public string Description{get;set;}
        [Required]
        public int Price{get;set;}
        public DateTime CreatedAt = DateTime.Now;
        public DateTime UpdatedAt = DateTime.Now;
        public List<Association> Categories {get;set;}
    }
}