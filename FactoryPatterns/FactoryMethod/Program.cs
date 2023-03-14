using FactoryMethod;

List<Book> books = new List<Book>();

BiographyBookFactory biographyBookFactory = new BiographyBookFactory();
Book? bioBook = biographyBookFactory.Create("A Beautiful Mind", "Nasar, Sylvia", GenreType.Biography);
if (bioBook != null)
    books.Add(bioBook);

FictionBookFactory fictionBookFactory = new FictionBookFactory();
Book? fictionBook = fictionBookFactory.Create("Crime and Punishment", "Dostoyevsky, Fyodor", GenreType.Fiction);
if (fictionBook != null)
    books.Add(fictionBook);

NonFictionBookFactory nonFictionBookFactory = new NonFictionBookFactory();
Book? nonFictionBook = nonFictionBookFactory.Create("Thinking Fast and Slow", "Kahneman, Daniel", GenreType.NonFiction);
if (nonFictionBook != null)
    books.Add(nonFictionBook);

MysteryBookFactory mysteryBookFactory = new MysteryBookFactory();
Book? mysteryBook = mysteryBookFactory.Create("The Girl with the Dragon Tattoo", "Larsson, Stieg", GenreType.Mystery);
if (mysteryBook != null)
    books.Add(mysteryBook);

SciFiBookFactory sciFiBookFactory = new SciFiBookFactory();
Book? sciFiBook = sciFiBookFactory.Create("The Hitchhiker's Guide to the Galaxy", "Adams, Douglas", GenreType.SciFi);
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
