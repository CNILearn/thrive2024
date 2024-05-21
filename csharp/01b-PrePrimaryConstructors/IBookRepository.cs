namespace PrePrimaryConstructors;

internal interface IBookRepository
{
    IAsyncEnumerable<Book> GetBooksAsync();

    Task<Book> GetBookAsync(int id);
}