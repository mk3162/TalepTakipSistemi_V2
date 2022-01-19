using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Entities;

namespace Web.Context
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext(DbContextOptions options) :base(options)
        {

        }

        public DbSet<Kullanici> Kullanicilar { get; set; }
    }
}
