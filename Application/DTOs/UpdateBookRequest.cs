namespace LibraryManagement.Application.DTOs
{
    public record UpdateBookRequest(int Id, string Title, string Author, int PublishedYear, int TotalCopies, string? ISBN);
}
