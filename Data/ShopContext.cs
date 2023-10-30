﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Shop.Models;

namespace Shop.Data
{
    public class ShopContext : DbContext
    {
        public ShopContext (DbContextOptions<ShopContext> options)
            : base(options)
        {
        }

        public DbSet<Shop.Models.Book> Book { get; set; } = default!;

        public DbSet<Shop.Models.usersaccounts>? usersaccounts { get; set; }

        public DbSet<Shop.Models.orders>? orders { get; set; }
        public DbSet<Shop.Models.report>? report { get; set; }
    }
}
