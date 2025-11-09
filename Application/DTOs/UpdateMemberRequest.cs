namespace LibraryManagement.Application.DTOs
{
    public record UpdateMemberRequest(int Id, string FullName, string Email, string? PhoneNumber);
}
