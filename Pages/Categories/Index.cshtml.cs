using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Mechetiuc_Denisa_Lab8.Data;
using Mechetiuc_Denisa_Lab8.Models;

namespace Mechetiuc_Denisa_Lab8.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly Mechetiuc_Denisa_Lab8.Data.Mechetiuc_Denisa_Lab8Context _context;

        public IndexModel(Mechetiuc_Denisa_Lab8.Data.Mechetiuc_Denisa_Lab8Context context)
        {
            _context = context;
        }

        public IList<Category> Category { get;set; }

        public async Task OnGetAsync()
        {
            Category = await _context.Category.ToListAsync();
        }
    }
}
