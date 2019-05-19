using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TrackingWorldDemo.Models;

namespace TrackingWorldDemo.Pages.Product
{
    public class DetailsModel : PageModel
    {
        private readonly TrackingWorldDemo.Models.Context _context;

        public DetailsModel(TrackingWorldDemo.Models.Context context)
        {
            _context = context;
        }

        public TrackingWorldDemo.Models.Product Product { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Product = await _context.Products.FirstOrDefaultAsync(m => m.ID == id);

            if (Product == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
