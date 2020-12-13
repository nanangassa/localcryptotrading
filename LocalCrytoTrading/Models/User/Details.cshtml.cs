using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesUser.Data;

namespace LocalCrytoTrading.Models
{
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesUser.Data.RazorPagesUserContext _context;

        public DetailsModel(RazorPagesUser.Data.RazorPagesUserContext context)
        {
            _context = context;
        }

        public User User { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            User = await _context.User.FirstOrDefaultAsync(m => m.UserID == id);

            if (User == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
