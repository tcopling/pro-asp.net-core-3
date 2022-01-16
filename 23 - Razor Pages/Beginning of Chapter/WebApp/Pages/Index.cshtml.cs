using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;
using WebApp.Models;
using Microsoft.AspNetCore.Mvc;


namespace  WebApp.Pages
{
    public class IndexModel : PageModel
    {
        private DataContext context;

        public Product Product {get; set;}

        public IndexModel(DataContext ctx)
        {
            context = ctx;
        }

        /*
        public async Task OnGetAsync(long id = 1)
        {
            Product = await context.Products.FindAsync(id);
        }
        */

        public async Task<IActionResult> OnGetAsync(long id = 1)
        {
           Product = await context.Products.FindAsync(id);
           if (Product == null)
           {
               return RedirectToPage("NotFound");
           }
           return Page();   //makes sense because in mvc we return a View
        }
    }
}