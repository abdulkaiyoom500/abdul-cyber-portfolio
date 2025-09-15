using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SOFT40081_StarterCode.Models;

namespace SOFT40081_StarterCode.Pages
{
    [Authorize]
    public class addProductModel : PageModel
    {

        public readonly AppDataContext _db;

        [BindProperty]
        public Product Product { get; set; }
        public addProductModel(AppDataContext db)
        {
            _db = db;
        }
        public IActionResult OnPost()
        {
            _db.Products.Add(Product);
            _db.SaveChanges();
            return RedirectToPage("Index");
        }
        public void OnGet()
        {
        }
    }
}