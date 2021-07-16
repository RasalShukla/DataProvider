using Importer.persistence.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Importer.persistence.MySql
{
    public class DomainModelMySqlContext : DbContext
    {
        public DomainModelMySqlContext(DbContextOptions<DomainModelMySqlContext> options) : base(options)
        { }

        public DbSet<ImportEntityModel> ImportEntityRecords { get; set; }

       

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public override int SaveChanges()
        {
            ChangeTracker.DetectChanges();
            UpdateUpdatedProperty<ImportEntityModel>();
            return base.SaveChanges();
        }

        private void UpdateUpdatedProperty<T>() where T : class
        {
            var modifiedSourceInfo =
                ChangeTracker.Entries<T>()
                    .Where(e => e.State == EntityState.Added || e.State == EntityState.Modified);

            foreach (var entry in modifiedSourceInfo)
            {
                entry.Property("UpdatedTimestamp").CurrentValue = DateTime.UtcNow;
            }
        }
    }
}
