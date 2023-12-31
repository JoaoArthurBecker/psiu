﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PSIUWeb.Models;

namespace PSIUWeb.Data
{
    public class AppDbContext : 
        IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions options) 
            : base(options)
        {
        }

        public DbSet<Pacient>? Pacients { get; set; }

        public DbSet <Psico>? psicos { get; set; }
        public DbSet<Category>? Categories { get; set; }
        public DbSet<Content>? contents { get; set; }

        public DbSet <ContentCategory>? ContentCategories { get; set; }
    }
}
