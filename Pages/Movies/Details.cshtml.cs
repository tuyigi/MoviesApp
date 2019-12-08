using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MoviesApp.Data;
using MoviesApp.Models;

namespace MoviesApp.Pages.Movies
{
    public class DetailsModel : PageModel
    {
        private readonly MoviesApp.Data.MoviesContext _context;

        public DetailsModel(MoviesApp.Data.MoviesContext context)
        {
            _context = context;
        }

        public Movie Movie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Movie = await _context.Movies
                .Include(m => m.Category).FirstOrDefaultAsync(m => m.id == id);

            if (Movie == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
