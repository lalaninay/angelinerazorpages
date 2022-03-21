#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using angelinerazorpages.Data;

namespace angelinerazorpages.Pages.preaching
{
    public class IndexModel : PageModel
    {
        private readonly angelinerazorpages.Data.angelinerazorpagesContext _context;

        public IndexModel(angelinerazorpages.Data.angelinerazorpagesContext context)
        {
            _context = context;
        }

        public IList<Class> Class { get;set; }

        public async Task OnGetAsync()
        {
            Class = await _context.Class.ToListAsync();
        }
    }
}
