using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;
using WebApp.Models;


namespace  WebApp.Pages.Suppliers
{
    public class ListModel : PageModel
    {
        private DataContext context;

        public IEnumerable<string> Suppliers {get; set;}

        public ListModel (DataContext ctx)
        {
            context = ctx;
        }

        public void OnGet()
        {
            Suppliers = context.Suppliers.Select(s => s.Name);
        }
    }
}