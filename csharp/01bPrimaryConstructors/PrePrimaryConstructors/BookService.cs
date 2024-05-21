using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace PrePrimaryConstructors;

internal class BookService
{
    private readonly ILogger<BookService> _logger;

    private readonly IBookRepository _bookRepository;

    private readonly ICacheService _cacheService;

    private readonly IOptions<BookServiceOptions> _options;

    public BookService(ILogger<BookService> logger, IBookRepository bookRepository, ICacheService cacheService, IOptions<BookServiceOptions> options)
    {
        _bookRepository = bookRepository;
        _cacheService = cacheService;
        _options = options;
        _logger = logger;
    }

    public IAsyncEnumerable<Book> GetBooksAsync()
    {
        _logger.LogInformation("Getting books");
        return _bookRepository.GetBooksAsync();
    }

    public async Task<Book> GetBookAsync(int id)
    {
        _logger.LogInformation("Getting book {Id}", id);
        return await _bookRepository.GetBookAsync(id);
    }
}