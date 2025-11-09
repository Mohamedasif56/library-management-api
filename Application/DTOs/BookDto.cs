namespace LibraryManagement.Application.DTOs
{
    public record BookDto(int Id, string Title, string Author, int PublishedYear, int TotalCopies, int AvailableCopies);
}
