using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    internal class NonFictionBook : Book
    {
        internal NonFictionBook(string title, string author, GenreType genre) : 
                         base(title, author, genre)
        {
        }

        internal override string? Id => $"NF-{RandomNumberGenerator.GetInt32(100000, 999999)}";
    }
}
