using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Flaviu_Iepan_lab2.Models;

namespace Flaviu_Iepan_lab2.Data
{
    public class Flaviu_Iepan_lab2Context : DbContext
    {
        public Flaviu_Iepan_lab2Context (DbContextOptions<Flaviu_Iepan_lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Flaviu_Iepan_lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Flaviu_Iepan_lab2.Models.Publisher>? Publisher { get; set; }

        public DbSet<Flaviu_Iepan_lab2.Models.Author>? Author { get; set; }

        public DbSet<Flaviu_Iepan_lab2.Models.Category>? Category { get; set; }
    }
}
