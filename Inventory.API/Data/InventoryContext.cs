using Inventory.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Inventory.API.Data
    {
            public class InventoryContext: DbContext
    {
        public InventoryContext(DbContextOptions<InventoryContext> options) : base(options)
        {

        }
        // DbSets for each entity
        public DbSet<Building> Buildings { get; set; }
        public DbSet<Floor> Floors { get; set; }
        public DbSet<Room> Rooms { get; set; }
        
        public DbSet<Department> Departments { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeInventoryRole> EmployeeInventoryRoles { get; set; }

        public DbSet<Item> Items { get; set; }
        public DbSet<ItemType> ItemTypes { get; set; }
        public DbSet<ItemStatus> ItemStatuses { get; set; }
        public DbSet<ItemHasStatus> ItemHasStatuses { get; set; }

        public DbSet<ItemManipulationType> ItemManipulationTypes { get; set; }
        public DbSet<ItemHistory> ItemHistories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //Prevents, that database wont drop when deleting an employee that is head of department
            modelBuilder.Entity<Employee>()
            .HasOne(e => e.Department)
            .WithMany(d => d.Employees)
            .HasForeignKey(e => e.DepartmentId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Department>()
            .HasOne(d => d.HeadOfDepartment)
            .WithMany()
            .HasForeignKey(d => d.HeadOfDepartmentId)
            .OnDelete(DeleteBehavior.Restrict);

            // Prevent cascading deletes for Item Owner and CurrentHolder
            modelBuilder.Entity<Item>()
            .HasOne(i => i.Owner)
            .WithMany()
            .HasForeignKey(i => i.OwnerId)
            .OnDelete(DeleteBehavior.Restrict); 

            modelBuilder.Entity<Item>()
            .HasOne(i => i.CurrentHolder)
            .WithMany()
            .HasForeignKey(i => i.CurrentHolderId)
            .OnDelete(DeleteBehavior.Restrict);

            // Prevent cascading deletes for ItemHistory references
            modelBuilder.Entity<ItemHistory>()
            .HasOne(h => h.Employee)
            .WithMany()
            .HasForeignKey(h => h.EmployeeId)
            .OnDelete(DeleteBehavior.Restrict); 

            modelBuilder.Entity<ItemHistory>()
            .HasOne(h => h.Item)
            .WithMany()
            .HasForeignKey(h => h.ItemId)
            .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

