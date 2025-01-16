using CompRepair.Core.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CompRepair.Core.Database;

public class AppDbContext : DbContext
{
    public DbSet<CategoryEntity> Categories { get; set; }
    public DbSet<ClientEntity> Clients { get; set; }
    public DbSet<DeviceTypeEntity> DeviceTypes { get; set; }
    public DbSet<LogEntity> Logs { get; set; }
    public DbSet<ManufacturerEntity> Manufacturers { get; set; }
    public DbSet<OrderStatusEntity> OrderStatuses { get; set; }
    public DbSet<PartEntity> Parts { get; set; }
    public DbSet<RepairOrderEntity> RepairOrders { get; set; }
    public DbSet<UsedPartEntity> UsedParts { get; set; }
    public DbSet<UserEntity> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string basePath = AppDomain.CurrentDomain.BaseDirectory;
        string settingsPath = Path.Combine(basePath, "Settings", "appsettings.json");

        var configuration = new ConfigurationBuilder()
            .SetBasePath(Path.GetDirectoryName(settingsPath))
            .AddJsonFile("appsettings.json")
            .Build();

        string connectionString = configuration.GetConnectionString("Database")
                                  ?? throw new InvalidOperationException("Connection string 'Database' not found.");
        
        optionsBuilder.UseNpgsql(connectionString)
            .UseLazyLoadingProxies();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasPostgresExtension("uuid-ossp");

        modelBuilder.Entity<CategoryEntity>(builder =>
        {
            builder.ToTable("categories");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id)
                .HasColumnType("uuid")
                .HasDefaultValueSql("uuid_generate_v4()")
                .IsRequired();
            
            builder.Property(c => c.Name)
                .HasColumnType("varchar(100)")
                .IsRequired();
            
            builder.HasMany(x => x.Parts)
                .WithOne(x => x.Category)
                .HasForeignKey(x => x.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<ClientEntity>(builder =>
        {
            builder.ToTable("clients");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id)
                .HasColumnType("uuid")
                .HasDefaultValueSql("uuid_generate_v4()")
                .IsRequired();
            
            builder.Property(x => x.FullName)
                .HasColumnType("varchar(100)")
                .IsRequired();
            
            builder.Property(x => x.Email)
                .HasColumnType("varchar(100)")
                .IsRequired(false);
            
            builder.Property(x => x.Phone)
                .HasColumnType("varchar(20)")
                .IsRequired();
            
            builder.Property(x => x.BirthDate)
                .HasColumnType("timestamp with time zone")
                .IsRequired(false);
            
            builder.HasMany(x => x.RepairOrders)
                .WithOne(x => x.Client)
                .HasForeignKey(x => x.ClientId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<DeviceTypeEntity>(builder =>
        {
            builder.ToTable("device_types");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id)
                .HasColumnType("uuid")
                .HasDefaultValueSql("uuid_generate_v4()")
                .IsRequired();
            
            builder.Property(c => c.Name)
                .HasColumnType("varchar(100)")
                .IsRequired();
            
            builder.HasMany(x => x.RepairOrders)
                .WithOne(x => x.DeviceType)
                .HasForeignKey(x => x.DeviceTypeId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<LogEntity>(builder =>
        {
            builder.ToTable("logs");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id)
                .HasColumnType("uuid")
                .HasDefaultValueSql("uuid_generate_v4()")
                .IsRequired();

            builder.Property(c => c.CreatedAt)
                .HasColumnType("timestamp with time zone")
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .IsRequired();

            builder.Property(c => c.UserId)
                .HasColumnType("uuid");
            
            builder.Property(c => c.Message)
                .HasColumnType("text")
                .IsRequired();
            
            builder.Property(c => c.LogType)
                .HasColumnType("varchar(20)")
                .IsRequired();
        });

        modelBuilder.Entity<ManufacturerEntity>(builder =>
        {
            builder.ToTable("manufacturers");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id)
                .HasColumnType("uuid")
                .HasDefaultValueSql("uuid_generate_v4()")
                .IsRequired();
            
            builder.Property(c => c.Name)
                .HasColumnType("varchar(100)")
                .IsRequired();
            
            builder.HasMany(x => x.Parts)
                .WithOne(x => x.Manufacturer)
                .HasForeignKey(x => x.ManufacturerId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<OrderStatusEntity>(builder =>
        {
            builder.ToTable("order_statuses");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id)
                .HasColumnType("uuid")
                .HasDefaultValueSql("uuid_generate_v4()")
                .IsRequired();
            
            builder.Property(c => c.Name)
                .HasColumnType("varchar(100)")
                .IsRequired();
            
            builder.HasMany(x => x.RepairOrders)
                .WithOne(x => x.Status)
                .HasForeignKey(x => x.StatusId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<PartEntity>(builder =>
        {
            builder.ToTable("parts");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id)
                .HasColumnType("uuid")
                .HasDefaultValueSql("uuid_generate_v4()")
                .IsRequired();
            
            builder.Property(c => c.Name)
                .HasColumnType("varchar(100)")
                .IsRequired();
            
            builder.Property(c => c.Description)
                .HasColumnType("text")
                .IsRequired(false);
            
            builder.Property(c => c.Price)
                .HasColumnType("decimal(10,2)")
                .IsRequired();
            
            builder.Property(c => c.StockQuantity)
                .HasColumnType("integer")
                .IsRequired();
            
            builder.HasMany(x => x.UsedParts)
                .WithOne(x => x.Part)
                .HasForeignKey(x => x.PartId)
                .OnDelete(DeleteBehavior.Restrict);
            
            builder.HasOne(x => x.Manufacturer)
                .WithMany(x => x.Parts)
                .HasForeignKey(x => x.ManufacturerId)
                .OnDelete(DeleteBehavior.Restrict);
            
            builder.HasOne(x => x.Category)
                .WithMany(x => x.Parts)
                .HasForeignKey(x => x.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<RepairOrderEntity>(builder =>
        {
            builder.ToTable("repair_orders");
            builder.HasKey(c => c.SerialNumber);
            builder.Property(c => c.SerialNumber)
                .HasColumnType("uuid")
                .HasDefaultValueSql("uuid_generate_v4()")
                .IsRequired();

            builder.Property(c => c.Problem)
                .HasColumnType("text")
                .IsRequired();
            
            builder.Property(c => c.Diagnosis)
                .HasColumnType("text")
                .IsRequired();
            
            builder.Property(c => c.EstimatedCost)
                .HasColumnType("decimal(10,2)")
                .IsRequired();
            
            builder.Property(c => c.FinalCost)
                .HasColumnType("decimal(10,2)")
                .IsRequired(false);
            
            builder.Property(c => c.CompletedAt)
                .HasColumnType("timestamp with time zone")
                .IsRequired(false);
            
            builder.HasMany(x => x.UsedParts)
                .WithOne(x => x.RepairOrder)
                .HasForeignKey(x => x.RepairOrderId)
                .OnDelete(DeleteBehavior.Cascade);
            
            builder.HasOne(x => x.Client)
                .WithMany(x => x.RepairOrders)
                .HasForeignKey(x => x.ClientId)
                .OnDelete(DeleteBehavior.Restrict);
            
            builder.HasOne(x => x.Technician)
                .WithMany(x => x.RepairOrders)
                .HasForeignKey(x => x.TechnicianId)
                .OnDelete(DeleteBehavior.Restrict);
            
            builder.HasOne(x => x.Status)
                .WithMany(x => x.RepairOrders)
                .HasForeignKey(x => x.StatusId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<UsedPartEntity>(builder =>
        {
            builder.ToTable("used_parts");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id)
                .HasColumnType("uuid")
                .HasDefaultValueSql("uuid_generate_v4()")
                .IsRequired();

            builder.Property(c => c.Quantity)
                .HasColumnType("integer")
                .IsRequired();
            
            builder.Property(c => c.PricePerUnit)
                .HasColumnType("decimal(10,2)")
                .IsRequired();
            
            builder.HasOne(x => x.Part)
                .WithMany(x => x.UsedParts)
                .HasForeignKey(x => x.PartId)
                .OnDelete(DeleteBehavior.Restrict);
            
            builder.HasOne(x => x.RepairOrder)
                .WithMany(x => x.UsedParts)
                .HasForeignKey(x => x.RepairOrderId)
                .OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<UserEntity>(builder =>
        {
            builder.ToTable("users");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id)
                .HasColumnType("uuid")
                .HasDefaultValueSql("uuid_generate_v4()")
                .IsRequired();

            builder.Property(c => c.FullName)
                .HasColumnType("varchar(100)")
                .IsRequired();
            
            builder.Property(c => c.Username)
                .HasColumnType("varchar(50)")
                .IsRequired();
            
            builder.HasIndex(c => c.Username)
                .IsUnique();
            
            builder.Property(c => c.Phone)
                .HasColumnType("varchar(20)")
                .IsRequired();
            
            builder.Property(c => c.Email)
                .HasColumnType("varchar(100)")
                .IsRequired();
            
            builder.Property(c => c.Password)
                .HasColumnType("varchar(300)")
                .IsRequired();
            
            builder.Property(c => c.Role)
                .HasColumnType("varchar(20)")
                .IsRequired();
            
            builder.Property(c => c.HiredDate)
                .HasColumnType("timestamp with time zone")
                .IsRequired();
            
            builder.Property(c => c.FiredDate)
                .HasColumnType("timestamp with time zone")
                .IsRequired(false);
            
            builder.Property(c => c.Salary)
                .HasColumnType("decimal(10,2)")
                .IsRequired();
            
            builder.Property(c => c.BirthDate)
                .HasColumnType("timestamp with time zone")
                .IsRequired();
            
            builder.HasMany(x => x.RepairOrders)
                .WithOne(x => x.Technician)
                .HasForeignKey(x => x.TechnicianId)
                .OnDelete(DeleteBehavior.Restrict);
        });
    }
}