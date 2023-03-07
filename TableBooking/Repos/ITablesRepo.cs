using TableBooking.Models;

namespace TableBooking.Repos
{
    public interface ITablesRepo
    {
        List<TableModel> GetAll();

        TableModel GetById(int id);

        bool BookTable(int id);
    }
}
