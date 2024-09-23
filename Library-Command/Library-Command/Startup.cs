// Isabelly Barbosa Gonçalves CB3021467

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Internal;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using System.Text;

namespace Library_Command;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddRouting();
    }

    public void Configure(IApplicationBuilder app)
    {
        var builder = new RouteBuilder(app);

        builder.MapRoute("book/Name", GetBookName);
        builder.MapRoute("book/ToString", GetBook);
        builder.MapRoute("book/GetAuthorNames", GetBookAuthors);
        builder.MapRoute("livro/ApresentarLivro", ApresentarLivro);

        var routes = builder.Build();

        app.UseRouter(routes);
    }

    public Task GetBookName(HttpContext context)
    {
        var dbContext = new LibraryDbContext();
        var libraryRepository = new LibraryRepository(dbContext);

        var book = libraryRepository.GetBook(1);

        return context.Response.WriteAsync(book.GetName());
    }

    public Task GetBook(HttpContext context)
    {
        var dbContext = new LibraryDbContext();
        var libraryRepository = new LibraryRepository(dbContext);

        var book = libraryRepository.GetBook(1);

        return context.Response.WriteAsync(book.ToString());
    }

    public Task GetBookAuthors(HttpContext context)
    {
        var dbContext = new LibraryDbContext();
        var libraryRepository = new LibraryRepository(dbContext);

        var book = libraryRepository.GetBook(1);

        return context.Response.WriteAsync(book.GetAuthorNames());
    }

    public Task ApresentarLivro(HttpContext context)
    {
        var dbContext = new LibraryDbContext();
        var libraryRepository = new LibraryRepository(dbContext);

        var book = libraryRepository.GetBook(1);

        return context.Response.WriteAsync($"Nome: {book.GetName()}, Autores: {book.GetAuthorNames()}");
    }
}
