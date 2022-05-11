using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

using ArtefactsManager.Data.Models;

namespace ArtefactsManager.Data
{
    public partial class ArtefactsManagerDatabaseContext : DbContext
    {
        public ArtefactsManagerDatabaseContext()
        {
        }

        public ArtefactsManagerDatabaseContext(DbContextOptions<ArtefactsManagerDatabaseContext> options)
            : base(options)
        {
        }

        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRole { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<CategoryCharacter> CategoryCharacter { get; set; }

        public DbSet<Cave> Caves { get; set; }

        public DbSet<Character> Characters { get; set; }

        public DbSet<Dragon> Dragons { get; set; }

        public DbSet<Ent> Ents { get; set; }

        public DbSet<Grove> Groves { get; set; }

        public DbSet<Mage> Mages { get; set; }

        public DbSet<Quarter> Quarters { get; set; }

        public DbSet<Species> Species { get; set; }

        public DbSet<Tower> Towers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySQL("Server=localhost;Database=Artefacts_Manager_Database;user=artefact_manager;password=artefact_manager");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserRole>().HasKey(userRole => new { userRole.UserId, userRole.RoleId });

            modelBuilder.Entity<CategoryCharacter>().HasKey(categoryCharacter => new { categoryCharacter.CharacterId, categoryCharacter.CategoryId });
        }

    }
}