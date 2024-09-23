// Isabelly Barbosa Gonçalves CB3021467

using Microsoft.AspNetCore.Hosting;

using Library_Command;

var context = new LibraryDbContext();
var libraryRepository = new LibraryRepository(context);



IWebHost host = new WebHostBuilder().UseKestrel().UseStartup<Startup>().Build();
host.Run();


var book = libraryRepository.GetBook(1);

Console.WriteLine("=== Métodos da classe Book ===");
Console.WriteLine();
Console.WriteLine("GetName(): " + book.GetName());
Console.WriteLine("GetAuthors(): " + book.GetAuthors());
Console.WriteLine("GetPrice(): " + book.GetPrice());
Console.WriteLine("book.SetPrice(59.99)");
book.SetPrice(59.99);
Console.WriteLine("GetQuantity(): " + book.GetQuantity());
Console.WriteLine("SetQuantity(5)");
book.SetQuantity(5);
Console.WriteLine("ToString(): " + book.ToString());
Console.WriteLine("GetAuthorNames(): " + book.GetAuthorNames());
