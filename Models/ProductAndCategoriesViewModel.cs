using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace ProductsAndCategories.Models
{
    public class ProductAndCategoriesViewModel
    {
        public Product TheProduct{get;set;}
        public List<Category> NonAssociatedCategories{get;set;}
        public Association NewAssociation {get;set;}

    }
}