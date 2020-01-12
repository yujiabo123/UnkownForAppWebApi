using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace com.unkown.app.Models
{
    public partial class AlexAppContext : DbContext
    {
        public AlexAppContext()
        {
        }

        public AlexAppContext(DbContextOptions<AlexAppContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccountInfo> AccountInfo { get; set; }
        public virtual DbSet<VertifyRecord> VertifyRecord { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("data source=DESKTOP-LCR8SOO;initial catalog=AlexApp;user id=sa;password=123456;MultipleActiveResultSets=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountInfo>(entity =>
            {
                entity.HasKey(e => e.AccountId);

                entity.HasIndex(e => e.AccountId)
                    .HasName("UQ__AccountI__349DA5A7BBC96FC9")
                    .IsUnique();

                entity.HasIndex(e => e.Phone)
                    .HasName("IX_AccountInfo")
                    .IsUnique();

                entity.Property(e => e.AccountId).ValueGeneratedNever();

                entity.Property(e => e.Account)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.MachineId)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Qq)
                    .HasColumnName("QQ")
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.WeChat)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.WeiBo)
                    .HasMaxLength(50)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VertifyRecord>(entity =>
            {
                entity.Property(e => e.VertifyCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
