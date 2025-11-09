namespace LibraryManagement.Application.DTOs
{
    public record CreateBookRequest(string Title, string Author, int PublishedYear, int TotalCopies, string? ISBN);
}
