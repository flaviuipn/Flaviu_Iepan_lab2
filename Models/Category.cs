﻿using System.ComponentModel.DataAnnotations;

namespace Flaviu_Iepan_lab2.Models
{
    public class Category
    {
        
        public int ID { get; set; }
        [Display(Name = "Category Name:")]

        public string CategoryName { get; set; }
    
        public ICollection<BookCategory>? BookCategories { get; set; }
    }
}
