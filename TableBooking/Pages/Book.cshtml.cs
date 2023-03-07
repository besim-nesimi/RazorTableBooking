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

        public IActionResult OnPost(int id)
        {
            // ModelState.IsValid kollar s� att alla Required o.s.v. �r uppfyllda
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
