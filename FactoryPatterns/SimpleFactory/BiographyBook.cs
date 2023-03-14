using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    internal class BiographyBook : Book
    {
        internal BiographyBook(string title, string author, GenreType genre) :
            base(title, author, genre)
        {
        }

        internal override string? Id => $"BIO-{RandomNumberGenerator.GetInt32(100000, 999999)}";
    }
}
