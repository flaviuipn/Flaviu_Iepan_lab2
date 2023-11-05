using System.ComponentModel.DataAnnotations;

namespace Flaviu_Iepan_lab2.Models
{
    public class Borrowing
    {
        public int ID { get; set; }
        [Display(Name = "Member Full Name:")]
        public int? MemberID { get; set; }
        public Member? Member { get; set; }
        [Display(Name = "Book Details:")]
        public int? BookID { get; set; }
        public Book? Book { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReturnDate { get; set; }
    }
}
