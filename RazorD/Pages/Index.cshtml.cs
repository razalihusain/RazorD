using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorD.Data;
using RazorD.Models;

namespace RazorD.Pages
{
    public class IndexModel : PageModel
    {
        private readonly RazorD.Data.RazorDContext _context;

        public IndexModel(RazorD.Data.RazorDContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
