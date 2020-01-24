using System;
using Microsoft.EntityFrameworkCore;
using AudioCommune2.Models;
namespace AudioCommune2.Data
{
    public class AudioCommuneDbContext : DbContext
    {
        public DbSet<message> Messages { get; set; }

        public DbSet<playlist>Playlists { get; set; }

        public DbSet<Server>Servers { get; set; }

        public DbSet<User>Users { get; set; }

        public DbSet<UserServer>UserServers { get; set; }

        public DbSet<video>Videos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("Data Source=CheeseMVC.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<message>()
                .HasKey(c => new { c.UserID, c.ServerID });

            modelBuilder.Entity<playlist>()
               .HasKey(c => new { c.ServerID, c.UserID, c.VideoID });

            modelBuilder.Entity<UserServer>()
               .HasKey(c => new { c.UserID, c.ServerID });
        }

        public AudioCommuneDbContext()
        {
        }
    }
}
