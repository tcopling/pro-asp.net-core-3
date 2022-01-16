using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;
using WebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApp.Pages
{
    public class HandlerSelectorModel : PageModel
    {
        private DataContext context;

        public Product Product { get; set; }

        public HandlerSelectorModel(DataContext ctx)
        {
            //ViewData["myName"] = "Terrance";
            context = ctx;
        }

        public async Task OnGetAsync (long id = 1)
        {
             Product = await context.Products.FindAsync(id);
        }
        
        public async Task OnGetRelatedAsync(long id = 1)
        {
            Product = await context.Products
                .Include(p => p.Supplier)
                .Include(p => p.Category)
                .FirstOrDefaultAsync(p => p.ProductId == id);

                Product.Supplier.Products = null;
                Product.Category.Products = null;
        }

    }
}