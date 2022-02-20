using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyScriptureApp.Models;

namespace MyScriptureApp.Pages.Scriptures
{
    public class IndexModel : PageModel
    {
        private readonly MyScriptureApp.Data.MyScriptureAppContext _context;

        public IndexModel(MyScriptureApp.Data.MyScriptureAppContext context)
        {
            _context = context;
        }

        public IList<Entry> Entry { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Books { get; set; }
        [BindProperty(SupportsGet = true)]
        public string ScriptureBook { get; set; }
        public string Book { get; private set; }
        public string EntryDate { get; private set; }

        public string BookSort { get; private set; }

        public string DateSort { get; private set; }

        public async Task OnGetAsync()
        {
            
            IQueryable<string> bookQuery = from m in _context.Entry
                                           orderby m.Book
                                           select m.Book;
            var entries = from m in _context.Entry
                          select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
                entries = entries.Where(s => s.Thoughts.Contains(SearchString));
            }
            if (!string.IsNullOrEmpty(ScriptureBook))
            {
                entries = entries.Where(x => x.Book == ScriptureBook);
            }
            Books = new SelectList(await bookQuery.Distinct().ToListAsync());
            Entry = await entries.ToListAsync();

        }
        public async Task OnGetSort(string sortOrder)
        {
            BookSort = string.IsNullOrEmpty(sortOrder) ? "book_desc" : "";
            DateSort = sortOrder == "Date" ? "date_desc" : "Date";

            IQueryable<Entry> entries = from m in _context.Entry
                                           select m;
            switch (sortOrder)
            {
                case "book_desc":
                    entries = entries.OrderByDescending(s => s.Book);
                    break;
                case "Date":
                    entries = entries.OrderBy(s => s.EntryDate);
                    break;
                case "date_desc":
                    entries = entries.OrderByDescending(s => s.EntryDate);
                    break;
                default:
                    entries = entries.OrderBy(s => s.EntryDate);
                    break;
            }
            Entry = await entries.AsNoTracking().ToListAsync();
        }
    }
}