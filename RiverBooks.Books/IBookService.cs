namespace RiverBooks.Books;

internal interface IBookService
{
	Task<List<BookDto>> ListBooksAync();
	Task<BookDto> GetBookByIdAsync(Guid id);
	Task CreateBookAsync(BookDto newBook);
	Task DeleteBookAsync(Guid id);
	Task UpdateBookPriceAsync(Guid bookId, decimal newPrice);
}
