using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace login_page.Models;

public partial class PharmacyStoreContext : DbContext
{
    public PharmacyStoreContext()
    {
    }

    public PharmacyStoreContext(DbContextOptions<PharmacyStoreContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Medicine> Medicines { get; set; }

    public virtual DbSet<OperationsHistory> OperationsHistories { get; set; }

    public virtual DbSet<OperationsMedicine> OperationsMedicines { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.\\sqlexpress;Database=Pharmacy_Store;Trusted_Connection=True;TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Medicine>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PK__Medicine__A25C5AA6417BD379");

            entity.HasIndex(e => e.Name, "UQ__Medicine__737584F61913056C").IsUnique();

            entity.Property(e => e.Code)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Barcode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ExpiryDate).HasColumnName("Expiry_date");
            entity.Property(e => e.MinimumQuantity).HasDefaultValue(5);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<OperationsHistory>(entity =>
        {
            entity.HasKey(e => e.OperationId).HasName("PK__Operatio__D9469EE7645AB833");

            entity.ToTable("Operations_History");

            entity.Property(e => e.OperationId).HasColumnName("Operation_ID");
            entity.Property(e => e.OperationTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Operation_time");
            entity.Property(e => e.OperationType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("Operation_type");
        });

        modelBuilder.Entity<OperationsMedicine>(entity =>
        {
            entity.HasKey(e => new { e.OperationId, e.MedicineCode }).HasName("PK__Operatio__BDFD44D9F8BEEE18");

            entity.ToTable("Operations_medicines");

            entity.Property(e => e.OperationId).HasColumnName("Operation_ID");
            entity.Property(e => e.MedicineCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Medicine_code");

            entity.HasOne(d => d.MedicineCodeNavigation).WithMany(p => p.OperationsMedicines)
                .HasForeignKey(d => d.MedicineCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Operation__Medic__5812160E");

            entity.HasOne(d => d.Operation).WithMany(p => p.OperationsMedicines)
                .HasForeignKey(d => d.OperationId)
                .HasConstraintName("FK__Operation__Opera__571DF1D5");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
