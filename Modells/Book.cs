namespace Library.Modells
{
    public class Book
    {
        public int Id { get; set; }

        public required string Title { get; set; }

        public required string Author { get; set; }

        public int PublishedYear { get; set; }

        public string? Genre { get; set; }

        public decimal Price { get; set; }
    }

}
