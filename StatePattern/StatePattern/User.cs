using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class User
    {
        public User(int id, string username)
        {
            UserId = id;
            Username = username;
        }

        public int UserId { get; set; }
        public string? Username { get; set; }
    }
}
