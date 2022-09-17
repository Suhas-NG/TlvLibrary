﻿using Microsoft.EntityFrameworkCore;
using NoteOne.Domain;

namespace NoteOne.Persistence
{
    public class NoteOneDBContext : DbContext
    {
        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<Note> Notes { get; set; } = null !;
        public DbSet<Page> Pages { get; set; } = null!;
        public DbSet<Tag> Tags { get; set; } = null!;
        public DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost; Database=NoteOne; Username=postgres; Password=postgres");
        } 
     }
}