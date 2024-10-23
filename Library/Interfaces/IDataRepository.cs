using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Interfaces
{
    public interface IDataRepository
    {
        bool AddUser(User user);
        bool DeleteUser(string userId);
        List<User> GetAllUsers();
        User GetUserById(string userId);
        bool UpdateUser(User user);
    }
}
