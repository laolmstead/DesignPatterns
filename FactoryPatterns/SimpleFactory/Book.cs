using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    internal abstract class Book
    {
        internal Book(string title, string author, GenreType genre)
        {
            Title = title;
            Author = author;
            Genre = genre;
        }

        internal string? Title { get; set; }
        internal string? Author { get; set; }
        internal GenreType Genre { get; set; }
        internal abstract string? Id { get; }
    }
}
