using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class SciFiBook : Book
    {
        internal SciFiBook(string title, string author, GenreType genre) : 
                    base(title, author, genre)
        {
        }

        internal override string? Id => $"SCIFI-{RandomNumberGenerator.GetInt32(100000, 999999)}";
    }
}
