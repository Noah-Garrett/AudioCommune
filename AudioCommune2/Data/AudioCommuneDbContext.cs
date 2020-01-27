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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<playlist>()
                .HasKey(c => new { c.UserID, c.ServerID });

            modelBuilder.Entity<UserServer>()
               .HasKey(c => new { c.UserID, c.ServerID });
        }

        public AudioCommuneDbContext(DbContextOptions<AudioCommuneDbContext> options)
            : base(options)
        {
        }
    }
}
