namespace PrimaryConstructors;

internal interface IBookRepository
{
    IAsyncEnumerable<Book> GetBooksAsync();

    Task<Book> GetBookAsync(int id);
}