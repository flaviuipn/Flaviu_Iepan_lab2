using System.ComponentModel.DataAnnotations;

namespace Flaviu_Iepan_lab2.Models
{
    public class Author
    {
        public int ID { get; set; }

        [Display(Name = "Author First Name:")]
        public string FirstName { get; set; }


        [Display(Name = "Author Last Name:")]
        public string LastName { get; set; }

        public ICollection<Book>? Books { get; set; }
    }
}
