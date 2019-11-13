using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace ProductsAndCategories.Models
{
    public class CategoryViewModel
    {
        public Category NewCategory{get;set;}
        public List<Category> AllCategories{get;set;}
    }
}