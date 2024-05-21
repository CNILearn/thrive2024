using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace PrimaryConstructors;

internal class BookService(ILogger<BookService> logger, IBookRepository bookRepository, ICacheService cacheService, IOptions<BookServiceOptions> options)
{
    // You can assign the parameters to fields/properties
    // OR you can use them directly in your methods (as shown below).

    public IAsyncEnumerable<Book> GetBooksAsync()
    {
        logger.LogInformation("Getting books");
        return bookRepository.GetBooksAsync();
    }

    public async Task<Book> GetBookAsync(int id)
    {
        logger.LogInformation("Getting book {Id}", id);
        return await bookRepository.GetBookAsync(id);
    }
}