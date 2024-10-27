using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Interfaces
{
    public interface IBorrowHistoryRepository
    {
        List<BorrowBook> LoadBorrowHistory();
        void SaveBorrowHistory(List<BorrowBook> history);
    }
}
