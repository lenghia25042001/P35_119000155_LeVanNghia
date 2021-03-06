#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using LeVanNghia.Model;

namespace LeVanNghia.Pages_comment
{
    public class CreateModel : PageModel
    {
        private readonly CategoryContext _context;

        public CreateModel(CategoryContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public comment comment { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.comment.Add(comment);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
