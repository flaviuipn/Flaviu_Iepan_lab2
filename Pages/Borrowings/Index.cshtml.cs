﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Flaviu_Iepan_lab2.Data;
using Flaviu_Iepan_lab2.Models;

namespace Flaviu_Iepan_lab2.Pages.Borrowings
{
    public class IndexModel : PageModel
    {
        private readonly Flaviu_Iepan_lab2.Data.Flaviu_Iepan_lab2Context _context;

        public IndexModel(Flaviu_Iepan_lab2.Data.Flaviu_Iepan_lab2Context context)
        {
            _context = context;
        }

        public IList<Borrowing> Borrowing { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Borrowing != null)
            {
                Borrowing = await _context.Borrowing
                .Include(b => b.Book)
                  .ThenInclude(b => b.Author)
                .Include(b => b.Member).ToListAsync();
            }
        }
    }
}