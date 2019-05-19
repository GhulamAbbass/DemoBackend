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
    public class IndexModel : PageModel
    {
        private readonly TrackingWorldDemo.Models.Context _context;

        public IndexModel(TrackingWorldDemo.Models.Context context)
        {
            _context = context;
        }

        public IList<TrackingWorldDemo.Models.Product> Product { get;set; }

        public async Task OnGetAsync()
        {
            Product = await _context.Products.ToListAsync();
        }
    }
}
