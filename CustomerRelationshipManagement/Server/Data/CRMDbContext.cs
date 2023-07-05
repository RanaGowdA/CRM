using CustomerRelationshipManagement.Shared;
using CustomerRelationshipManagement.Shared.Models.Implementation;
using CustomerRelationshipManagement.Shared.Models.Interfaces;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace CustomerRelationshipManagement.Server.Data
{
    public class CRMDbContext : DbContext
    {
        public DbSet<Lead> Leads { get; set; }
        public DbSet<Opportunity> Opportunities { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<TemplateConfiguration> TemplateConfigurations { get; set; }
        public DbSet<EngagementModel> EngagementModels { get; set; }
        public DbSet<ClientAccount> ClientAccounts { get; set; }

        public CRMDbContext(DbContextOptions<CRMDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Lead>().HasOne(x => x.Opportunity).WithOne().HasForeignKey<Lead>("LeadId").IsRequired();
            modelBuilder.Entity<Lead>().HasOne(x => x.Project).WithOne().HasForeignKey<Lead>("LeadId").IsRequired(); 
            modelBuilder.Entity<ClientAccount>().HasOne(x => x.Configuration).WithOne().HasForeignKey<TemplateConfiguration>("ClientAccountId").IsRequired();
            modelBuilder.Entity<ClientAccount>().HasOne(x => x.EngagementModel).WithOne().HasForeignKey<EngagementModel>("ClientAccountId").IsRequired();
            modelBuilder.Entity<ClientAccount>().HasMany(e => e.Leads).WithOne().IsRequired();

            base.OnModelCreating(modelBuilder);

        }
    }
}
