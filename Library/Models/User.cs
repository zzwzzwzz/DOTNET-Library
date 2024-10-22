using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public abstract class User
    {
        public required string UserId { get; set; }
        public required string Username { get; set; }
        public required string Password { get; set; }
        public abstract string GetUserType();
    }
}
