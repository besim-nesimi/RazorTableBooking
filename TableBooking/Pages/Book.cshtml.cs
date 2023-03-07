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
		public string ErrorMessage { get; private set; }


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

        public IActionResult OnPost(int id)
        {
            // ModelState.IsValid kollar så att alla Required o.s.v. är uppfyllda
            if(ModelState.IsValid)
            {
                // Boka ett bord
                bool bookStatus = repo.BookTableById(id, GuestName, GuestEmail);

                if(bookStatus)
                {
                    return RedirectToPage("/Index");
                }

                ErrorMessage = "Table does not exist!";
            }

            selectedTable = GetTable(id);

            return Page();
        }

        public TableModel? GetTable(int id)
        {
            return repo.GetById(id);
        } 
    }
}
