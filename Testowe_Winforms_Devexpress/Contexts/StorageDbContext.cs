using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testowe_Winforms_Devexpress.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace Testowe_Winforms_Devexpress.Contexts
{
    public class StorageDbContext:DbContext
    {
        public StorageDbContext():base("MSSQL_Connect")
        {
            this.Database.Log = s=> System.Diagnostics.Debug.WriteLine(s);
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Storage> Storages { get; set; }
        public DbSet<StorageDoc> StorageDocs { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var AccountEntity = modelBuilder.Entity<Account>();
            AccountEntity.HasKey(e => e.Login);
            AccountEntity.Property(e => e.Password)
                .IsRequired();
            AccountEntity.Property(e => e.Name)
                .HasMaxLength(30);
            AccountEntity.Property(e => e.Created)
                .HasColumnType("datetime2");           
            AccountEntity.Property(e => e.LastUpdated)
                .HasColumnType("datetime2");            
            AccountEntity.Property(e => e.Logged)
                .HasColumnType("datetime2");

            var ClientEntity = modelBuilder.Entity<Client>();
            ClientEntity.HasIndex(e => e.ContactName);
            ClientEntity.HasIndex(e => e.Name);
            ClientEntity.HasKey(e => e.ClientId)
                .Property(e => e.ClientId)
                .HasColumnName("ClientID")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            ClientEntity.Property(e => e.ContactName)
                .HasMaxLength(30)
                .IsRequired();
            ClientEntity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsRequired();
            ClientEntity.Property(e => e.Address)
                .HasMaxLength(120); 
            ClientEntity.Property(e => e.Phone)
                .HasMaxLength(24);

            var ProductEntity = modelBuilder.Entity<Product>();
            ProductEntity.HasIndex(e=>e.Name);
            ProductEntity.HasKey(e=> e.ProductId)
                .Property(e=> e.ProductId)
                .HasColumnName("ProductID")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            ProductEntity.Property(e => e.SupplierId)
                .HasColumnName("SupplierID");
            ProductEntity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsRequired();
            ProductEntity.Property(e => e.ArrivalDate)
                .HasColumnType("datetime2");
            ProductEntity.Property(e => e.Netto)
                .HasColumnType("money");
            ProductEntity.Property(e => e.Brutto)
                .HasColumnType("money");
            ProductEntity.Property(e => e.StorageId)
                .IsOptional();
            ProductEntity.Property(e => e.UnitsLeft)
                .IsConcurrencyToken();

            var OrderProductEntity = modelBuilder.Entity<OrderProduct>();
            OrderProductEntity.HasKey(e => e.OrderProductId)
                .Property(e => e.OrderProductId)
                .HasColumnName("OrderProductID")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            OrderProductEntity.Property(e => e.OrderDate)
                .HasColumnType("datetime2");

            var StorageEntity = modelBuilder.Entity<Storage>();
            StorageEntity.HasIndex(e => e.Name);
            StorageEntity.HasKey(e => e.StorageId)
                .Property(e => e.StorageId)
                .HasColumnName("StorageID")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            StorageEntity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsRequired();
            StorageEntity.Property(e => e.Address)
                .HasMaxLength(120);

            var StorageDocEntity = modelBuilder.Entity<StorageDoc>();
            StorageDocEntity.HasIndex(e => e.Name);
            StorageDocEntity.HasKey(e => e.StorageDocId)
                .Property(e=>e.StorageDocId)
                .HasColumnName("StorageDocID")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            StorageDocEntity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsRequired();
            StorageDocEntity.Property(e => e.StorageId)
                .IsOptional();

            
        }

    }
}
