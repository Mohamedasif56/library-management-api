using LibraryManagement.Domain.Entities;

namespace LibraryManagement.Application.Interfaces
{
    public interface IMemberRepository
    {
        Task<Member?> GetByIdAsync(int id);
        Task<IEnumerable<Member>> GetAllAsync();
        Task<Member> AddAsync(Member member);
        Task<Member> UpdateAsync(Member member);
        Task<bool> DeleteAsync(int id);
    }
}
