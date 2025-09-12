using E_Commerce.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace E_Commerce.Pages
{
    public class addProductModel : PageModel
    {
        public readonly AppDataContext _db;


        public addProductModel(AppDataContext db)
        {
            _db = db;
        }
        [BindProperty]

        public Product Product { get; set; }

        public IActionResult OnPost()
        {
            _db.Products.Add(Product);
            _db.SaveChanges();
            return RedirectToPage("Index");
        }
        public IActionResult OnGet(int? Id)
        {
            if (Id.HasValue)
            {
                var ProductToUpdate = _db.Products.FirstOrDefault(x => x.Id == Id);
                _db.Products.Remove(ProductToUpdate);
                if (ProductToUpdate == null)
                {
                    return NotFound();
                }
                Product = ProductToUpdate;
            }
            else
            {
                Product = new Product();
            }
            _db.SaveChanges();
            return Page();
        }
    }
}
