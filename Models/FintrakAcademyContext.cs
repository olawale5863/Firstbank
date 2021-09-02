using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FIRSTBANKOFNIGERIA.Models
{
    public partial class FintrakAcademyContext : DbContext
    {
        public FintrakAcademyContext()
        {
        }

        public FintrakAcademyContext(DbContextOptions<FintrakAcademyContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CustomerInformation> CustomerInformation { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=INAOBATAN;Database=FintrakAcademy; user id=sa; password=sqluser10$;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomerInformation>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Address)
                    .HasMaxLength(225)
                    .IsUnicode(false);

                entity.Property(e => e.DateofBirth)
                    .HasMaxLength(225)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(225)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(225)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LastName)
                    .HasMaxLength(225)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNo)
                    .HasMaxLength(225)
                    .IsUnicode(false);

                entity.Property(e => e.Sex)
                    .HasMaxLength(225)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(225)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
