using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TableBooking.Models;
using TableBooking.Repos;

namespace TableBooking.Pages
{
    public class BookModel : PageModel
    {
		private readonly ITablesRepo repo;
        public TableModel? selectedTable { get; set; }
        
        [BindProperty]
        [Required(ErrorMessage = "Your name is required!")]
        public string GuestName { get; set; }
        
        [BindProperty]
		[Required(ErrorMessage = "Your E-mail is required!")]
		public string GuestEmail { get; set; }


        // Använd Dependency Injection för att injicera ITablesRepo och dess implementering (TablesRepo) i den här klassen
        public BookModel(ITablesRepo repo)
        {
			this.repo = repo;
		}
        public void OnGet(int id)
        {
            // Använd repot för att hämta ett (1) bord.
            selectedTable = repo.GetById(id);
        }

        public void OnPost(int id)
        {

        }
    }
}
