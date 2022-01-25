using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPageWeb.Data;
using RazorPageWeb.Model;

namespace RazorPageWeb.Pages.Categories
{
    [BindProperties]
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _applicationDb;
        public Category Category { get; set; }

        public CreateModel(ApplicationDbContext applicationDb)
        {
            _applicationDb = applicationDb;
        }



        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            if(Category.Name == Category.DisplayOrder.ToString())
            {
                ModelState.AddModelError(String.Empty, "The DisplayOrder and Name cant be the same");
            }
            if (ModelState.IsValid)
            {
                await _applicationDb.Categories.AddAsync(Category);              
                var result = await _applicationDb.SaveChangesAsync();
                if(result > 0)
                {
                    TempData["success"] = "Category created successfully!";
                }
                return RedirectToPage("Index");
            }

            return Page();
           
        }
    }
}
