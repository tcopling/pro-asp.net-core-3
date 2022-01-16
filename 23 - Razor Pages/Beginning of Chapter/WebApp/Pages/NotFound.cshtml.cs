using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp.Models;
using System.Collections.Generic;

namespace  WebApp.Pages
{
    public class NotFoundModel : PageModel
    {
       private DataContext context;

       public IEnumerable<Product> Products {get; set;} 

       public NotFoundModel(DataContext ctx)
       {
           context = ctx;           
       }  

       public void OnGetAsync(long id = 1) {
           Products = context.Products;
       }
    }
}