// Isabelly Barbosa Gonçalves CB3021467

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Command
{
    public class LibraryRepository(LibraryDbContext context)
    {
        public Book? GetBook(int id)
        {
            return context.Books.Include(b => b.Authors).Single(b => b.Id == id);
        }
    }
}
