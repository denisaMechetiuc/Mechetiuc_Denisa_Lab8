using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Mechetiuc_Denisa_Lab8.Models;

namespace Mechetiuc_Denisa_Lab8.Data
{
    public class Mechetiuc_Denisa_Lab8Context : DbContext
    {
        public Mechetiuc_Denisa_Lab8Context (DbContextOptions<Mechetiuc_Denisa_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Mechetiuc_Denisa_Lab8.Models.Book> Book { get; set; }

        public DbSet<Mechetiuc_Denisa_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Mechetiuc_Denisa_Lab8.Models.Category> Category { get; set; }
    }
}
