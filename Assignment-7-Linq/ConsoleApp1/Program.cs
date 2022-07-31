using ClassLibrary1;

var books = Book.GenerateBookDB();


// Where, OrderBy, Select
var filteredBooksByPages = books.
    Where(book => book.Pages < 200 && book.Pages > 100).
    OrderBy(book => book.Pages).
    Select(book => book.Title);

Console.WriteLine("\nBooks between 100 and 200 pages");
foreach(var book in filteredBooksByPages)
{
    Console.WriteLine(book);
}

Console.WriteLine("\n");


// Grouping
var groupedBooksByRead = books.
    GroupBy(book => book.Read);

Console.WriteLine("\nGrouping books into read/unread");
foreach (var group in groupedBooksByRead)
{
    if (group.Key == true) { Console.WriteLine($"Read books:"); }
    else { Console.WriteLine($"Unread books:"); }

    foreach (var book in group)
    {
        Console.WriteLine($"{book.Title}: {book.Author}");
    }
    Console.WriteLine("\n");
}

// Conversion
var bookArray = books.ToArray();

Console.WriteLine("\nConverting books to an array and displaying the books with even page numbers");  
for (int i = 0; i < bookArray.Length; i++)
{
    if (i % 2 == 0) { Console.WriteLine(bookArray[i]); }
}

// Element Operatos
Console.WriteLine("\nFirst Book under 100 pages.");
var firstSmallBook = books.First(book => book.Pages < 100);
Console.WriteLine(firstSmallBook);

// Aggregation
var nrOfBooks = books.Count();
Console.WriteLine("\n Counting the nr of books");
Console.WriteLine(nrOfBooks);

// Quantifiers
var authorsWithHInName = books.
    Where(book => book.Author.ToLower().Contains("h")).
    Select(book => book.Author);

Console.WriteLine("\nAuthors with 'H' in their name");
foreach(var author in authorsWithHInName)
{
    Console.WriteLine(author);
}

