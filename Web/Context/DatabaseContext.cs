﻿using Microsoft.EntityFrameworkCore;
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
        public DbSet<Sirket> Sirketler { get; set; }
        public DbSet<Urun> Urunler { get; set; }
        public DbSet<Tip> Tipler { get; set; }
        public DbSet<Tedarikci> Suppliers { get; set; }
        public DbSet<Birim> Birimler { get; set; }
        public DbSet<IslemTip> IslemTipleri { get; set; }
    }
}