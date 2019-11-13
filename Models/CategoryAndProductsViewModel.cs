using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace ProductsAndCategories.Models
{
    public class CategoryAndProductsViewModel
    {
        public Category TheCategory{get;set;}
        public Association NewAssociation{get;set;}
        public List<Product> NonassociatedProducts{get;set;}
    }
}