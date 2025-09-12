using E_Commerce.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace E_Commerce.Pages.Search
{
    public class SearchModel : PageModel
    {
        private readonly AppDataContext _db;

        public SearchModel(AppDataContext db)
        {
            _db = db;
        }

        public IList<Product> SearchResults { get; set; }

        public void OnGet(string q)
        {
            SearchResults = _db.Products
                               .Where(p => p.Name.Contains(q) || p.Description.Contains(q) || p.Category.Contains(q))
                               .ToList();
        }
    }

}
