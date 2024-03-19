using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GestaoDeLaboratorios.Models;

namespace GestaoDeLaboratorios.Pages
{
    public class IndexModel : PageModel
    {
        private readonly GestaoDeLaboratorios.Models.MyDbContext _context;

        public IndexModel(GestaoDeLaboratorios.Models.MyDbContext context)
        {
            _context = context;
        }

        public IList<Computadores> Computadores { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Computadores = await _context.Computadores.ToListAsync();
        }
    }
}
