using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPageWeb.Data;
using RazorPageWeb.Model;

namespace RazorPageWeb.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _dbContext;
        public IEnumerable<Category> Categories { get; set; }

        public IndexModel(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void OnGet()
        {
            Categories = _dbContext.Categories;
        }
    }
}
