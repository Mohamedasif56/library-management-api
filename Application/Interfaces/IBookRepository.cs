using LibraryManagement.Domain.Entities;

namespace LibraryManagement.Application.Interfaces
{
    public interface IBookRepository
    {
        Task<Book?> GetByIdAsync(int id);
        Task<IEnumerable<Book>> GetAllAsync();
        Task<Book> AddAsync(Book book);
        Task<Book> UpdateAsync(Book book);
        Task<bool> DeleteAsync(int id);
    }
}
