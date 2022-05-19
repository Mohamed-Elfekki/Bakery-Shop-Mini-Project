using BakeryShop.Data;
using BakeryShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BakeryShop.Pages
{
    public class IndexModel : PageModel
    {
        private readonly BakeryShopContext _db; 
        public IndexModel(BakeryShopContext db) => this._db = db;
        public IList<Product> Products { get;set; }
        public Product FeaturedProduct { get;set; }

        public async Task OnGetAsync()
        {
            Products = await _db.Products.ToListAsync();
            FeaturedProduct = Products.ElementAt(new Random().Next(Products.Count));

        }
    }
}
