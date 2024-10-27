using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Buzea_Ana_Lab2.Models;

namespace Buzea_Ana_Lab2.Data
{
    public class Buzea_Ana_Lab2Context : DbContext
    {
        public Buzea_Ana_Lab2Context (DbContextOptions<Buzea_Ana_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Buzea_Ana_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Buzea_Ana_Lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Buzea_Ana_Lab2.Models.Author> Author { get; set; } = default!;
    }
}
