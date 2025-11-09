namespace LibraryManagement.Domain.Entities
{
    public class Book
    {
        public int Id { get; private set; }
        public string Title { get; private set; } = null!;
        public string Author { get; private set; } = null!;
        public string? ISBN { get; private set; }
        public int PublishedYear { get; private set; }
        public int TotalCopies { get; private set; }
        public int AvailableCopies { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime? UpdatedAt { get; private set; }

        // Constructor
        public Book(string title, string author, int publishedYear, int totalCopies, string? isbn = null)
        {
            if(string.IsNullOrWhiteSpace(title)) throw new ArgumentException("Title is required", nameof(title));
            if(string.IsNullOrWhiteSpace(author)) throw new ArgumentException("Author is required", nameof(author));
            if(totalCopies < 0) throw new ArgumentException("TotalCopies cannot be negative", nameof(totalCopies));

            Title = title;
            Author = author;
            ISBN = isbn;
            PublishedYear = publishedYear;
            TotalCopies = totalCopies;
            AvailableCopies = totalCopies;
            CreatedAt = DateTime.UtcNow;
        }

        public void UpdateDetails(string title, string author, int publishedYear, int totalCopies, string? isbn = null)
        {
            if(string.IsNullOrWhiteSpace(title)) throw new ArgumentException("Title is required", nameof(title));
            if(string.IsNullOrWhiteSpace(author)) throw new ArgumentException("Author is required", nameof(author));
            if(totalCopies < 0) throw new ArgumentException("TotalCopies cannot be negative", nameof(totalCopies));

            Title = title;
            Author = author;
            PublishedYear = publishedYear;
            ISBN = isbn;

            // adjust available copies if total changed
            int diff = totalCopies - TotalCopies;
            TotalCopies = totalCopies;
            AvailableCopies = Math.Max(0, AvailableCopies + diff);

            UpdatedAt = DateTime.UtcNow;
        }
    }
}
