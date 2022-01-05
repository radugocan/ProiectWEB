#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProiectWEB.Models;

namespace ProiectWEB.Data
{
    public class ProiectWEBContext : DbContext
    {
        public ProiectWEBContext (DbContextOptions<ProiectWEBContext> options)
            : base(options)
        {
        }

        public DbSet<ProiectWEB.Models.Order> Order { get; set; }
    }
}
