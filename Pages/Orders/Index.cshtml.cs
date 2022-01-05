#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProiectWEB.Data;
using ProiectWEB.Models;

namespace ProiectWEB.Pages.Orders
{
    public class IndexModel : PageModel
    {
        private readonly ProiectWEB.Data.ProiectWEBContext _context;

        public IndexModel(ProiectWEB.Data.ProiectWEBContext context)
        {
            _context = context;
        }

        public IList<Order> Order { get;set; }

        public async Task OnGetAsync()
        {
            Order = await _context.Order.ToListAsync();
        }
    }
}
