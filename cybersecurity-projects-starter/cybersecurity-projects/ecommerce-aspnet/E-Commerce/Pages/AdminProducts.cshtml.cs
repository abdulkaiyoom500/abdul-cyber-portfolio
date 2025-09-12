using E_Commerce.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace E_Commerce.Pages
{
    public class AdminProductsModel : PageModel
    {
        public readonly AppDataContext _db;

        public List<Product> ProductList { get; set; }
        public AdminProductsModel(AppDataContext db)
        {
            _db = db;
        }

        [BindProperty] public Product Product { get; set; }

        public void OnGet()
        {
            ProductList = _db.Products.ToList();
        }
        public IActionResult OnPost(int productId)
        {
            var productToDelete = _db.Products.FirstOrDefault(p => p.Id == productId);
            if (productToDelete == null)
            {
                return NotFound();
            }
            _db.Products.Remove(productToDelete);
            _db.SaveChanges();
            return RedirectToPage("Index");
        }
    }
}
