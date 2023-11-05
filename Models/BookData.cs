using System.ComponentModel.DataAnnotations;

namespace Flaviu_Iepan_lab2.Models
{
    public class BookData
    {
        public IEnumerable<Book> Books { get; set; }
        public IEnumerable<Category> Categories { get; set; }

        [Display(Name = "Book Categories:")]
        public IEnumerable<BookCategory> BookCategories { get; set; }
    }
}
