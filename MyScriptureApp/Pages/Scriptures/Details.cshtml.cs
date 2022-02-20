using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyScriptureApp.Data;
using MyScriptureApp.Models;

namespace MyScriptureApp.Pages.Scriptures
{
    public class DetailsModel : PageModel
    {
        private readonly MyScriptureApp.Data.MyScriptureAppContext _context;

        public DetailsModel(MyScriptureApp.Data.MyScriptureAppContext context)
        {
            _context = context;
        }

        public Entry Entry { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Entry = await _context.Entry.FirstOrDefaultAsync(m => m.Id == id);

            if (Entry == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
