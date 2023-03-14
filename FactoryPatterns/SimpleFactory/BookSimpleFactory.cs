using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    internal class BookSimpleFactory
    {
        internal Book? Create(string title, string author, GenreType genre)
        {
            switch (genre)
            {
                case GenreType.Biography:
                    return new BiographyBook(title, author, genre);
                case GenreType.Fiction:
                    return new FictionBook(title, author, genre);
                case GenreType.NonFiction:
                    return new NonFictionBook(title, author, genre);
                case GenreType.Mystery:
                    return new MysteryBook(title, author, genre);
                case GenreType.SciFi:
                    return new SciFiBook(title, author, genre);
                default:
                    return null;
            }
        }
    }
}
