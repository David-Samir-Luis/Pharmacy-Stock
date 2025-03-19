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

    public virtual DbSet<DrugDateStock> DrugDateStocks { get; set; }

    public virtual DbSet<Medicine> Medicines { get; set; }

    public virtual DbSet<OperationsHistory> OperationsHistories { get; set; }

    public virtual DbSet<OperationsMedicine> OperationsMedicines { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-RTCLUQ8\\SQLEXPRESS02;Database=Pharmacy_Store;Trusted_Connection=True;TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DrugDateStock>(entity =>
        {
            entity.HasKey(e => new { e.MedicineId, e.ExpireDate }).HasName("PK__DrugDate__A946BED290565BD9");

            entity.ToTable("DrugDateStock");

            entity.Property(e => e.MedicineId).HasColumnName("Medicine_ID");

            entity.HasOne(d => d.Medicine).WithMany(p => p.DrugDateStocks)
                .HasForeignKey(d => d.MedicineId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DrugDateS__Medic__02FC7413");
        });

        modelBuilder.Entity<Medicine>(entity =>
        {
            entity.ToTable("Medicine");

            entity.HasIndex(e => e.Barcode, "UQ_Medicine_Barcode").IsUnique();

            entity.HasIndex(e => e.Name, "UQ__tmp_ms_x__737584F6B706C7E0").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Barcode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Code)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.MinimumQuantity).HasDefaultValue(5);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<OperationsHistory>(entity =>
        {
            entity.HasKey(e => e.OperationId).HasName("PK__Operatio__D9469EE74CDFD191");

            entity.ToTable("Operations_History");

            entity.Property(e => e.OperationId).HasColumnName("Operation_ID");
            entity.Property(e => e.OperationTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Operation_time");
            entity.Property(e => e.OperationType)
                .HasMaxLength(9)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Operation_type");
        });

        modelBuilder.Entity<OperationsMedicine>(entity =>
        {
            entity.HasKey(e => new { e.OperationId, e.MedicineId }).HasName("PK__tmp_ms_x__9CB68EC4C1B1045A");

            entity.ToTable("Operations_medicines");

            entity.Property(e => e.OperationId).HasColumnName("Operation_ID");
            entity.Property(e => e.MedicineId)
                .HasDefaultValueSql("('0')")
                .HasColumnName("Medicine_ID");

            entity.HasOne(d => d.Medicine).WithMany(p => p.OperationsMedicines)
                .HasForeignKey(d => d.MedicineId)
                .HasConstraintName("FK_OperationsMedicines_Medicine");

            entity.HasOne(d => d.Operation).WithMany(p => p.OperationsMedicines)
                .HasForeignKey(d => d.OperationId)
                .HasConstraintName("FK_OperationsMedicines_Operation");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
