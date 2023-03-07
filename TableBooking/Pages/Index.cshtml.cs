using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TableBooking.Data;
using TableBooking.Models;

namespace TableBooking.Pages
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext context;
        public List<TableModel> Tables { get; set; }

        // Använd Dependency Injection för att injicera AppDbContext i den här klassen
        public IndexModel(AppDbContext context)
        {
            this.context = context;
        }



        // Körs innan sidan ska visas
        public void OnGet()
        {

        }
    }
}