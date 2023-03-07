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


        // Anv�nd Dependency Injection f�r att injicera ITablesRepo och dess implementering (TablesRepo) i den h�r klassen
        public BookModel(ITablesRepo repo)
        {
			this.repo = repo;
		}
        public void OnGet(int id)
        {
            // Anv�nd repot f�r att h�mta ett (1) bord.
            selectedTable = repo.GetById(id);
        }

        public void OnPost(int id)
        {

        }
    }
}
