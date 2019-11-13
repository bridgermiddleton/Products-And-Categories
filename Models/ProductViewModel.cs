using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace ProductsAndCategories.Models
{
    public class ProductViewModel
    {
        public Product NewProduct{get;set;}
        public List<Product> AllProducts{get;set;}
    }
}