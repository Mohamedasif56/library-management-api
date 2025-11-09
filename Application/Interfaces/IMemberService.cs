using LibraryManagement.Application.DTOs;

namespace LibraryManagement.Application.Interfaces
{
    public interface IMemberService
    {
        Task<IEnumerable<MemberDto>> GetAllAsync();
        Task<MemberDto?> GetByIdAsync(int id);
        Task<MemberDto> CreateAsync(CreateMemberRequest request);
        Task<MemberDto?> UpdateAsync(UpdateMemberRequest request);
        Task<bool> DeleteAsync(int id);
    }
}
