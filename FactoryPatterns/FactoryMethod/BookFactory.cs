using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal abstract class BookFactory
    {
        protected abstract Book? CreateBook(string title, string author, GenreType genre);
        public Book? Create(string title, string author, GenreType genre)
        {
            return CreateBook(title, author, genre);
        }
    }
}
