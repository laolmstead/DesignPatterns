using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class BiographyBookFactory : BookFactory
    {
        protected override Book? CreateBook(string title, string author, GenreType genre)
        {
            return new BiographyBook(title, author, GenreType.Biography);
        }
    }
}
