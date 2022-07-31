namespace ClassLibrary1
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
        public bool Read { get; set; }
        public override string ToString()
        {
            return Read ?
                $"{Title} by {Author} has {Pages} pages and you have read it already." :
                $"{Title} by {Author} has {Pages} pages and you haven't read yet.";
        }
        static public List<Book> GenerateBookDB()
        {
            return new List<Book>
            {
                new Book { Id = 1, Title = "Dracula", Author = "Bram Stoker", Pages = 418, Read = false },
                new Book { Id = 2, Title = "Moby Dick", Author = "Herman Melville", Pages = 752, Read = true },
                new Book { Id = 3, Title = "Frankenstein", Author = "Mary Shelley", Pages = 280, Read = true },
                new Book { Id = 4, Title = "The Dog It Was That Died", Author = "Tom Stoppard", Pages = 192, Read = true },
                new Book { Id = 5, Title = "Get in the van", Author = "Henry Rollins", Pages = 247, Read = false },
                new Book { Id = 6, Title = "Heart of Darkness", Author = "Joseph Conrad", Pages = 72, Read = false },
                new Book { Id = 7, Title = "Charlie and the Chocolate Factory", Author = "Roald Dahl", Pages = 176, Read = true },
                new Book { Id = 8, Title = "Great Expectations", Author = "Charles Dickens", Pages = 544, Read = true },
                new Book { Id = 9, Title = "The Adventures of Tom Sawyer", Author = "Mark Twain", Pages = 216, Read = true },
                new Book { Id = 10, Title = "The Turn of the Screw", Author = "Henry James", Pages = 174, Read = true },
                new Book { Id = 11, Title = "Strange Case of Dr Jekyll and Mr Hyde", Author = "R. L. Stevenson", Pages = 141, Read = false },
                new Book { Id = 12, Title = "The Trial", Author = "Franz Kafka", Pages = 106, Read = true },
                new Book { Id = 13, Title = "Bartleby, the Scrivener", Author = "Herman Melville", Pages = 68, Read = false }
            };
        }
    }
}