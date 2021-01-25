using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Server_Side_App.Models
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Bool> Books { get; set; }
        
    }
}
