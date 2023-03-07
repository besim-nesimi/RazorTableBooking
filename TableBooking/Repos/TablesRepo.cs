using TableBooking.Data;
using TableBooking.Models;

namespace TableBooking.Repos
{
    public class TablesRepo : ITablesRepo
    {
        private readonly AppDbContext _context;

        public TablesRepo(AppDbContext context)
        {
            this._context = context;
        }
        public bool BookTableById(int id)
        {
            TableModel? tableToBook = GetById(id);

            if(tableToBook != null)
            {
                tableToBook.IsBooked = true;

                _context.SaveChanges();
            }
			return true;

            
        }

        public List<TableModel> GetAll()
        {
            return _context.Tables.ToList();
        }

        public TableModel GetById(int id)
        {
            return _context.Tables.FirstOrDefault(x => x.Id == id);
        }
    }
}
