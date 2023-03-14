using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class MysteryBookFactory : BookFactory
    {
        protected override Book? CreateBook(string title, string author, GenreType genre)
        {
            return new MysteryBook(title, author, genre);
        }
    }
}
