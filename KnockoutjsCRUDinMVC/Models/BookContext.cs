﻿using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace KnockoutjsCRUDinMVC.Models
{
    public class BookContext : DbContext
    {
        public BookContext() : base("BookContext")
        {
        }

        public DbSet<Book> Book { get; set; }
        public DbSet<Author> Author { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}