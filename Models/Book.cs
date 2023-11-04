﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace Flaviu_Iepan_lab2.Models
{
    public class Book
    {
        public int ID { get; set; }

        [Display(Name = "Book Title:")]
        public string Title { get; set; }

        [Column(TypeName = "decimal(6, 2)")]


        [Display(Name = "Price:")]
        public decimal Price { get; set; }

        [DataType(DataType.Date)]

        [Display(Name = "Publishing Date:")]
        public DateTime PublishingDate { get; set; }
        public int? PublisherID { get; set; }
        public Publisher? Publisher { get; set; }

        public int? AuthorID{ get; set; }
        public Author? Author { get; set; }
    }
}