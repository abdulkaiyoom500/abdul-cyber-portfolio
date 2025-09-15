using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SOFT40081_StarterCode.Models;

namespace SOFT40081_StarterCode.Pages
{
    [Authorize]
    public class ProductModel : PageModel
    {
        private readonly AppDataContext _db;

        public List<Product> ProductList { get; set; }

        public ProductModel(AppDataContext db)
        {
            _db = db;
        }

        public void OnGet()
        {
            ProductList = _db.Products.ToList();
        }
    }
}