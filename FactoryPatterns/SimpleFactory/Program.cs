using SimpleFactory;

BookSimpleFactory bookSimpleFactory = new BookSimpleFactory();
List<Book> books = new List<Book>();

// Biography book
Book? bioBook = bookSimpleFactory.Create("If You Ask Me: (And of Course You Won't)", "White, Betty", GenreType.Biography);
if (bioBook != null)
    books.Add(bioBook);

Book? fictionBook = bookSimpleFactory.Create("American Gods", "Gaiman, Neil", GenreType.Fiction);
if (fictionBook != null)
    books.Add(fictionBook);

Book? nonFictionBook = bookSimpleFactory.Create("Black Swan", "Taleb, Nassim Nicholas", GenreType.NonFiction);
if (nonFictionBook != null)
    books.Add(nonFictionBook);

Book? mysteryBook = bookSimpleFactory.Create("Gone Girl", "Flynn, Gillian", GenreType.Mystery);
if (mysteryBook != null)
    books.Add(mysteryBook);

Book? sciFiBook = bookSimpleFactory.Create("All Systems Red", "Wells, Martha", GenreType.SciFi);
if (sciFiBook != null)
    books.Add(sciFiBook);

foreach (Book book in books)
{
    Console.WriteLine($"Id:  {book.Id}");
    Console.WriteLine($"Title:  {book.Title}");
    Console.WriteLine($"Author:  {book.Author}");
    Console.WriteLine($"Genre:  {book.Genre}");
    Console.WriteLine();
}