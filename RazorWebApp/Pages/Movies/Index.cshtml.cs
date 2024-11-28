    using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorWebApp.Data;
using RazorWebApp.Models;

namespace RazorWebApp.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly RazorWebApp.Data.RazorWebAppContext _context;

        public IndexModel(RazorWebApp.Data.RazorWebAppContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
