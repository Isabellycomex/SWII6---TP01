// Isabelly Barbosa Gonçalves CB3021467

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Library_Command
{
    public class Book
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public List<Author> Authors { get; set; } = [];
        public double Price { get; set; }
        public int Quantity { get; set; } = 0;

        public string GetName() { return Name; }
        public List<Author> GetAuthors() { return Authors; }
        public double GetPrice() { return Price; }
        public int GetQuantity() { return Quantity; }

        public void SetPrice(double price) { Price = price; }

        public void SetQuantity(int quantity) { Quantity = quantity; }

        public string GetAuthorNames()
        {
            StringBuilder sb = new();

            foreach (Author author in Authors)
            {
                sb.Append(author.Name);
                sb.Append(", ");
            }

            return sb.ToString();
        }

        public override string ToString()
        {
            StringBuilder sb = new();

            foreach (Author author in Authors)
            {
                sb.Append($"Author[name={author.Name}, email={author.Email}, gender={author.Gender}]");
                sb.Append(", ");
            }

            string authors = sb.ToString();

            return $"Book[name={Name}, authors={authors}, price={Price}, quantity={Quantity}]";
        }
    }
}
