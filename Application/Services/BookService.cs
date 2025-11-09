using LibraryManagement.Application.DTOs;
using LibraryManagement.Application.Interfaces;
using LibraryManagement.Domain.Entities;

namespace LibraryManagement.Application.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _repo;
        public BookService(IBookRepository repo)
        {
            _repo = repo;
        }

        public async Task<BookDto> CreateAsync(CreateBookRequest request)
        {
            var book = new Book(request.Title, request.Author, request.PublishedYear, request.TotalCopies, request.ISBN);
            var result = await _repo.AddAsync(book);
            return new BookDto(result.Id, result.Title, result.Author, result.PublishedYear, result.TotalCopies, result.AvailableCopies);
        }

        public async Task<bool> DeleteAsync(int id)
            => await _repo.DeleteAsync(id);

        public async Task<IEnumerable<BookDto>> GetAllAsync()
            => (await _repo.GetAllAsync()).Select(x => new BookDto(x.Id, x.Title, x.Author, x.PublishedYear, x.TotalCopies, x.AvailableCopies));

        public async Task<BookDto?> GetByIdAsync(int id)
        {
            var book = await _repo.GetByIdAsync(id);
            if (book == null) return null;
            return new BookDto(book.Id, book.Title, book.Author, book.PublishedYear, book.TotalCopies, book.AvailableCopies);
        }

        public async Task<BookDto?> UpdateAsync(UpdateBookRequest request)
        {
            var book = await _repo.GetByIdAsync(request.Id);
            if (book == null) return null;

            book.UpdateDetails(request.Title, request.Author, request.PublishedYear, request.TotalCopies, request.ISBN);
            await _repo.UpdateAsync(book);

            return new BookDto(book.Id, book.Title, book.Author, book.PublishedYear, book.TotalCopies, book.AvailableCopies);
        }
    }
}
