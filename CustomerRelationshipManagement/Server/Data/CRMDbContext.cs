using CustomerRelationshipManagement.Shared;
using CustomerRelationshipManagement.Shared.Models.Interfaces;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CustomerRelationshipManagement.Server.Data
{
    public class CRMDbContext : DbContext
    {
        public DbSet<Lead> Leads { get; set; }
        public DbSet<Opportunity> Opportunities { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<TemplateConfiguration> TemplateConfigurations { get; set; }
        public DbSet<EngagementModel> EngagementModels { get; set; }

        public CRMDbContext(DbContextOptions<CRMDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Lead>().HasOne<Opportunity>().WithOne(x => x.Lead).HasForeignKey<Opportunity>().IsRequired(true); 
            modelBuilder.Entity<Lead>().HasOne<Project>().WithOne(x => x.Lead).HasForeignKey<Project>().IsRequired(true);  

            modelBuilder.Entity<Lead>().Property(s => s.IsOpportunity).HasDefaultValue(false);
            modelBuilder.Entity<Lead>().Property(s => s.IsProject).HasDefaultValue(false);
            modelBuilder.Entity<Lead>().Property(s => s.IsLCFL).HasDefaultValue(false);
            modelBuilder.Entity<Lead>().Property(s => s.IsLCFO).HasDefaultValue(false);
            modelBuilder.Entity<Lead>().Property(s => s.IsLCFP).HasDefaultValue(false);
            base.OnModelCreating(modelBuilder);

        }
    }
}
