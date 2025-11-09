using LibraryManagement.Application.DTOs;

namespace LibraryManagement.Application.Interfaces
{
    public interface IBookService
    {
        Task<IEnumerable<BookDto>> GetAllAsync();
        Task<BookDto?> GetByIdAsync(int id);
        Task<BookDto> CreateAsync(CreateBookRequest request);
        Task<BookDto?> UpdateAsync(UpdateBookRequest request);
        Task<bool> DeleteAsync(int id);
    }
}
