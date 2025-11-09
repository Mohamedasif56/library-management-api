namespace LibraryManagement.Application.DTOs
{
    public record CreateMemberRequest(string FullName, string Email, string? PhoneNumber);
}
