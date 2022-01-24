using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Entities;

namespace Web.Context
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base (options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Sirket> Companies { get; set; }
        public DbSet<Urun> Products { get; set; }
        public DbSet<Tip> Tip { get; set; }
        public DbSet<Tedarikci> Supplierss { get; set; }
        public DbSet<Birim> Units { get; set; }
        public DbSet<Islem> Islemler { get; set; }
    }
}
