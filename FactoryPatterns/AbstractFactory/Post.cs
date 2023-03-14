using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public abstract class Post
    {
        public int Id { get; } = RandomNumberGenerator.GetInt32(1, 999999);
        public string? Username { get; set; }
        public string? Content { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
