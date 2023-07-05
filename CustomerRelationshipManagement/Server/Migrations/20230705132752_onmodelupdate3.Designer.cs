﻿// <auto-generated />
using System;
using CustomerRelationshipManagement.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CustomerRelationshipManagement.Server.Migrations
{
    [DbContext(typeof(CRMDbContext))]
    [Migration("20230705132752_onmodelupdate3")]
    partial class onmodelupdate3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.19");

            modelBuilder.Entity("CustomerRelationshipManagement.Shared.Lead", b =>
                {
                    b.Property<int>("LeadId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address1")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("BusinessType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("CreatedById")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Fax")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("ForecastedValue")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ForecastedValueCurrency")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Geo")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Industry")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsLCFL")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasDefaultValue(false);

                    b.Property<bool>("IsLCFO")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasDefaultValue(false);

                    b.Property<bool>("IsLCFP")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasDefaultValue(false);

                    b.Property<bool>("IsOpportunity")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasDefaultValue(false);

                    b.Property<bool>("IsProject")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasDefaultValue(false);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("LeadSource")
                        .HasColumnType("INTEGER");

                    b.Property<int>("LeadStatus")
                        .HasColumnType("INTEGER");

                    b.Property<string>("MobilePhone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("NumberOfEmployees")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Offering")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("OpportunityId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Organization")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("PostalCode")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ProjectId1")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SalesType")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SalesTypeNature")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ServiceLines")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TagList")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Visiblity")
                        .HasColumnType("INTEGER");

                    b.Property<string>("WebSite")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LeadId");

                    b.HasIndex("OpportunityId");

                    b.HasIndex("ProjectId1");

                    b.ToTable("Leads");
                });

            modelBuilder.Entity("CustomerRelationshipManagement.Shared.Models.Interfaces.EngagementModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Organization")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("EngagementModels");
                });

            modelBuilder.Entity("CustomerRelationshipManagement.Shared.Models.Interfaces.TemplateConfiguration", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Segment")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("TemplateConfigurations");
                });

            modelBuilder.Entity("CustomerRelationshipManagement.Shared.Opportunity", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CreatedById")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("TEXT");

                    b.Property<int>("LastEditedById")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("TEXT");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Visiblity")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Opportunities");
                });

            modelBuilder.Entity("CustomerRelationshipManagement.Shared.Project", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CreatedById")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("TEXT");

                    b.Property<int>("InpState")
                        .HasColumnType("INTEGER");

                    b.Property<int>("LastEditedById")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("TEXT");

                    b.Property<int>("PaymentStatus")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Visiblity")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("CustomerRelationshipManagement.Shared.Lead", b =>
                {
                    b.HasOne("CustomerRelationshipManagement.Shared.Opportunity", "Opportunity")
                        .WithMany()
                        .HasForeignKey("OpportunityId");

                    b.HasOne("CustomerRelationshipManagement.Shared.Project", "Project")
                        .WithMany()
                        .HasForeignKey("ProjectId1");

                    b.Navigation("Opportunity");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("CustomerRelationshipManagement.Shared.Opportunity", b =>
                {
                    b.HasOne("CustomerRelationshipManagement.Shared.Lead", "Lead")
                        .WithOne()
                        .HasForeignKey("CustomerRelationshipManagement.Shared.Opportunity", "Id");

                    b.Navigation("Lead");
                });

            modelBuilder.Entity("CustomerRelationshipManagement.Shared.Project", b =>
                {
                    b.HasOne("CustomerRelationshipManagement.Shared.Lead", "Lead")
                        .WithOne()
                        .HasForeignKey("CustomerRelationshipManagement.Shared.Project", "Id");

                    b.Navigation("Lead");
                });
#pragma warning restore 612, 618
        }
    }
}
