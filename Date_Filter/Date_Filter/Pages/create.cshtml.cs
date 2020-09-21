using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Date_Filter.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Date_Filter.Pages
{
    public class createModel : PageModel
    {

        private readonly ApplicationDbContext _db;

        public createModel(ApplicationDbContext db)
        {
            _db = db;
        }
        [BindProperty]
        public EmpJoinDate EmpJoinDate { get; set; }


        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                await _db.NewEmployeeJoin.AddAsync(EmpJoinDate);
                await _db.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }
    }
}
