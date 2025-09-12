using E_Commerce.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;

namespace E_Commerce.Pages
{
    public class ProductsModel : PageModel
    {
        public readonly AppDataContext _db;

        public Dictionary<string, List<Product>> ProductsByCategory { get; set; }

        public List<Product> ProductList { get; set; }

        public ProductsModel(AppDataContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
            ProductsByCategory = _db.Products
                                    .AsEnumerable()
                                    .GroupBy(p => p.Category)
                                    .ToDictionary(g => g.Key, g => g.ToList());
        }

        public async Task<IActionResult> OnPostAddToCartAsync(int productId)
        {
            
            if (!User.Identity.IsAuthenticated)
            {
                
                return RedirectToPage("/Account/Login", new { area = "Identity", ReturnUrl = Request.Path.ToString() });
            }

            
            var product = _db.Products.FirstOrDefault(p => p.Id == productId);
            if (product != null)
            {
                var cartItem = _db.CartItems.FirstOrDefault(c => c.ProductId == productId);
                if (cartItem == null)
                {
                    _db.CartItems.Add(new CartItem { ProductId = productId, Quantity = 1 });
                }
                else
                {
                    cartItem.Quantity++;
                }
                await _db.SaveChangesAsync();
            }

            return RedirectToPage();
        }
    }
}
