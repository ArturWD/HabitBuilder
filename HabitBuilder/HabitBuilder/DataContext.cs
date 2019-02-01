using HabitBuilder.Core.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HabitBuilder
{
    public class DataContext : DbContext
    {
        public DataContext()
            : base("name=MyEntities")
        {

        }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Date> Dates { get; set; }
        public virtual DbSet<Day> Days { get; set; }
        public virtual DbSet<DayStatus> DayStatuses { get; set; }
        public virtual DbSet<Habit> Habits { get; set; }
        public virtual DbSet<Reason> Reasons { get; set; }
        public virtual DbSet<Status> Statuses { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            /*
            modelBuilder.Entity<Category>()
                .ToTable("Category")
                .Property(c => c.CategoryName)
                .HasMaxLength(100)
                .IsRequired();

            
            modelBuilder.Entity<Keyword>()
                .ToTable("Keyword")
                .Property(c => c.KeywordName)
                .HasMaxLength(100)
                .IsRequired();

            
            modelBuilder.Entity<Resource>()
                .ToTable("Resource")
                .Property(c => c.ResourceName)
                .HasMaxLength(150)
                .IsRequired();

            modelBuilder.Entity<Resource>()
                .Property(c => c.URL)
                .IsRequired();

            modelBuilder.Entity<Resource>()
                .Property(c => c.CategoryId)
                .IsRequired();

            modelBuilder.Entity<Resource>()
                .HasRequired(r => r.Category)
                .WithMany(c => c.Resources)
                .HasForeignKey(r => r.CategoryId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Resource>()
                .HasMany(r => r.Keywords)
                .WithMany(k => k.Resources)
                .Map(m =>
                {
                    m.ToTable("ResourceKeywords");
                    m.MapLeftKey("ResourceId");
                    m.MapRightKey("KeywordId");
                });

            base.OnModelCreating(modelBuilder);
            */
        }
    }
}