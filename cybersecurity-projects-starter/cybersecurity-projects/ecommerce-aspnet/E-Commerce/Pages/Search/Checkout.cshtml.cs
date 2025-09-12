using E_Commerce.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Pages.Search
{
    public class CheckoutModel : PageModel
    {
        private readonly AppDataContext _db;

        public CheckoutModel(AppDataContext db)
        {
            _db = db;
        }

        public List<CartItem> CartItems { get; set; } = new List<CartItem>();
        public decimal Total { get; set; }

        public async Task OnGetAsync()
        {
            CartItems = await _db.CartItems.Include(c => c.Product).ToListAsync();
            Total = CartItems.Sum(i => i.Product.Price * i.Quantity);
        }
    }
}
