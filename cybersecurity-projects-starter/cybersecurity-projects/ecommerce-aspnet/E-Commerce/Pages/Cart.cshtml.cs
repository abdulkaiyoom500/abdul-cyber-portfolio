using E_Commerce.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Pages
{
    public class CartModel : PageModel
    {
        private readonly AppDataContext _db;

        public CartModel(AppDataContext db)
        {
            _db = db;
        }

        public List<CartItem> CartItems { get; set; } = new List<CartItem>();

        public async Task OnGetAsync()
        {
            CartItems = await _db.CartItems.Include(c => c.Product).ToListAsync();
        }

        public async Task<IActionResult> OnPostUpdateQuantitiesAsync(Dictionary<int, int> quantities)
        {
            foreach (var item in quantities)
            {
                var cartItem = await _db.CartItems.FindAsync(item.Key);
                if (cartItem != null)
                {
                    cartItem.Quantity = item.Value;
                }
            }

            await _db.SaveChangesAsync();
            return RedirectToPage();
        }

        public async Task<IActionResult> OnPostRemoveAsync(int cartItemId)
        {
            var cartItem = await _db.CartItems.FindAsync(cartItemId);
            if (cartItem != null)
            {
                _db.CartItems.Remove(cartItem);
                await _db.SaveChangesAsync();
            }

            return RedirectToPage();
        }
    }
}
