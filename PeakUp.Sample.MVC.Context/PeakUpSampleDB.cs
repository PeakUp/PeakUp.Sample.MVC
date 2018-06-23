using Microsoft.EntityFrameworkCore;
using System;
using JetBrains.Annotations;

namespace PeakUp.Sample.MVC.Context
{
    public class PeakUpSampleDB : DbContext
    {
        public PeakUpSampleDB(DbContextOptions<PeakUpSampleDB> options) : base(options)
        {
        }

        protected PeakUpSampleDB()
        {
        }

        public DbSet<PeakUp.Sample.MVC.Entities.Product> Products { get; set; }
        public DbSet<PeakUp.Sample.MVC.Entities.Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PeakUp.Sample.MVC.Entities.Product>().HasOne(x => x.Category).WithMany(x => x.Products).HasForeignKey(x => x.CategoryId);
            base.OnModelCreating(modelBuilder);
        }
    }
}
