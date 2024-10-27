using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Interfaces
{
    public interface IBookRepository
    {
        List<Book> LoadBooks();
        void SaveBooks(List<Book> books);
    }

    public interface IBorrowHistoryRepository
    {
        List<BorrowBook> LoadBorrowHistory();
        void SaveBorrowHistory(List<BorrowBook> history);
    }
}
