using LibraryManagement.Application.DTOs;
using LibraryManagement.Application.Interfaces;
using LibraryManagement.Domain.Entities;

namespace LibraryManagement.Application.Services
{
    public class MemberService : IMemberService
    {
        private readonly IMemberRepository _repo;
        public MemberService(IMemberRepository repo)
        {
            _repo = repo;
        }

        public async Task<MemberDto> CreateAsync(CreateMemberRequest request)
        {
            var member = new Member(request.FullName, request.Email, request.PhoneNumber);
            var result = await _repo.AddAsync(member);
            return new MemberDto(result.Id, result.FullName, result.Email, result.PhoneNumber);
        }

        public async Task<bool> DeleteAsync(int id)
            => await _repo.DeleteAsync(id);

        public async Task<IEnumerable<MemberDto>> GetAllAsync()
            => (await _repo.GetAllAsync()).Select(x => new MemberDto(x.Id, x.FullName, x.Email, x.PhoneNumber));

        public async Task<MemberDto?> GetByIdAsync(int id)
        {
            var member = await _repo.GetByIdAsync(id);
            if (member == null) return null;
            return new MemberDto(member.Id, member.FullName, member.Email, member.PhoneNumber);
        }

        public async Task<MemberDto?> UpdateAsync(UpdateMemberRequest request)
        {
            var member = await _repo.GetByIdAsync(request.Id);
            if (member == null) return null;

            member.Update(request.FullName, request.Email, request.PhoneNumber);
            await _repo.UpdateAsync(member);

            return new MemberDto(member.Id, member.FullName, member.Email, member.PhoneNumber);
        }
    }
}
