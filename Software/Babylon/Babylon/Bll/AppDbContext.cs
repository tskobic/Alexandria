﻿using Dll.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Bll
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("AppContext")
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Membership> Memberships { get; set; }
        public DbSet<Receipt> Receipts { get; set; }
        public DbSet<Literature> Literatures { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Loan> Loans { get; set; }
        public DbSet<PickingOut> PickingsOut { get; set; }
        public DbSet<PickingIn> PickingsIn { get; set; }
        public DbSet<LoanItem> LoanItems { get; set; }
        public DbSet<PickingInItem> PickingInItems { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<Receipt>()
                    .HasRequired(m => m.User)
                    .WithMany(t => t.UserReceipt)
                    .HasForeignKey(m => m.User_Id)
                    .WillCascadeOnDelete(false);

            modelBuilder.Entity<Receipt>()
                        .HasRequired(m => m.Employee)
                        .WithMany(t => t.EmployeeReceipt)
                        .HasForeignKey(m => m.Employee_Id)
                        .WillCascadeOnDelete(false);

            modelBuilder.Entity<PickingInItem>().HasKey(x => new { x.PickingIn_Id, x.Literaure_Id });
            modelBuilder.Entity<PickingInItem>()
              .HasRequired(x => x.PickingIn)
              .WithMany(x => x.PickingInItem)
              .HasForeignKey(x => x.PickingIn_Id)
              .WillCascadeOnDelete(true);
            modelBuilder.Entity<PickingInItem>()
              .HasRequired(x => x.Literature)
              .WithMany(x => x.PickingInItem)
              .HasForeignKey(x => x.Literaure_Id)
              .WillCascadeOnDelete(true);
        }
    }
}
