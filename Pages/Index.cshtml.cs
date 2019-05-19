using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TrackingWorldDemo.Models;

namespace PunjabRestaurentApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly Context _context;
        public IndexModel(Context context)
        {
            _context = context;

        }
        public Product product { get; set; }
        public async Task<IActionResult> OnGetAsync()
        {
            product = await _context.Products.FirstOrDefaultAsync();
            return Page();
        }        
    }
}
