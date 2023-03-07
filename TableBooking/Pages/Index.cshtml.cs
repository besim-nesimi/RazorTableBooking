using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TableBooking.Data;
using TableBooking.Models;
using TableBooking.Repos;

namespace TableBooking.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ITablesRepo repo;

        // List property som ska innehålla tables från DB
        public List<TableModel> Tables { get; set; }

        // Använd Dependency Injection för att injicera ITablesRepo och dess implementering (TablesRepo) i den här klassen
        public IndexModel(ITablesRepo repo)
        {
            this.repo = repo;
        }

        // Körs innan sidan ska visas
        public void OnGet()
        {
            // Hämta tables från DB och lägg dem i list-propertyn som skapats.
            Tables = repo.GetAll();
        }
    }
}