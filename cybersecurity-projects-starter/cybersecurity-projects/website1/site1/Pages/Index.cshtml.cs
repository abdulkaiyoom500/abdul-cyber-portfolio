using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SOFT40081_StarterCode.Models;

namespace SOFT40081_StarterCode.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly AppDataContext _context;

        public IndexModel(ILogger<IndexModel> logger, AppDataContext context)
        {
            _logger = logger;
            _context = context;
        }

        public List<Product> Products { get; private set; }

        public void OnGet()
        {
            Products = _context.Products.ToList();
        }
    }
}