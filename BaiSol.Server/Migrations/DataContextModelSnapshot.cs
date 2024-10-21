﻿// <auto-generated />
using System;
using DataLibrary.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BaiSol.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("DataLibrary.Models.AppUsers", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("AdminEmail")
                        .HasColumnType("text");

                    b.Property<int?>("ClientId")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("RefreshToken")
                        .HasColumnType("text");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("DataLibrary.Models.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClientAddress")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ClientContactNum")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsMale")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("DataLibrary.Models.Equipment", b =>
                {
                    b.Property<int>("EQPTId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("EQPTId"));

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("EQPTCategory")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("EQPTCode")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("EQPTDescript")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("EQPTPrice")
                        .HasColumnType("numeric");

                    b.Property<int>("EQPTQOH")
                        .HasColumnType("integer");

                    b.Property<string>("EQPTStatus")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("EQPTUnit")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTimeOffset>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("EQPTId");

                    b.ToTable("Equipment");
                });

            modelBuilder.Entity("DataLibrary.Models.Gantt.GanttData", b =>
                {
                    b.Property<int>("TaskId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Relational:JsonPropertyName", "TaskId");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("TaskId"));

                    b.Property<DateTime?>("ActualEndDate")
                        .HasColumnType("timestamp with time zone")
                        .HasAnnotation("Relational:JsonPropertyName", "ActualEndDate");

                    b.Property<DateTime?>("ActualStartDate")
                        .HasColumnType("timestamp with time zone")
                        .HasAnnotation("Relational:JsonPropertyName", "ActualStartDate");

                    b.Property<int?>("Duration")
                        .HasColumnType("integer")
                        .HasAnnotation("Relational:JsonPropertyName", "Duration");

                    b.Property<int?>("ParentId")
                        .HasColumnType("integer")
                        .HasAnnotation("Relational:JsonPropertyName", "ParentId");

                    b.Property<DateTime?>("PlannedEndDate")
                        .HasColumnType("timestamp with time zone")
                        .HasAnnotation("Relational:JsonPropertyName", "PlannedEndDate");

                    b.Property<DateTime?>("PlannedStartDate")
                        .HasColumnType("timestamp with time zone")
                        .HasAnnotation("Relational:JsonPropertyName", "PlannedStartDate");

                    b.Property<string>("Predecessor")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "Predecessor");

                    b.Property<int?>("Progress")
                        .HasColumnType("integer")
                        .HasAnnotation("Relational:JsonPropertyName", "Progress");

                    b.Property<string>("TaskName")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "TaskName");

                    b.HasKey("TaskId");

                    b.ToTable("GanttData");
                });

            modelBuilder.Entity("DataLibrary.Models.Installer", b =>
                {
                    b.Property<int>("InstallerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("InstallerId"));

                    b.Property<string>("AdminId")
                        .HasColumnType("text");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("MyProperty")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTimeOffset>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("InstallerId");

                    b.HasIndex("AdminId");

                    b.ToTable("Installer");
                });

            modelBuilder.Entity("DataLibrary.Models.Labor", b =>
                {
                    b.Property<int>("LaborId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("LaborId"));

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<decimal>("LaborCost")
                        .HasColumnType("numeric");

                    b.Property<string>("LaborDescript")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("LaborNumUnit")
                        .HasColumnType("integer");

                    b.Property<int>("LaborQuantity")
                        .HasColumnType("integer");

                    b.Property<string>("LaborUnit")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("LaborUnitCost")
                        .HasColumnType("numeric");

                    b.Property<string>("ProjectProjId")
                        .HasColumnType("text");

                    b.Property<DateTimeOffset>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("LaborId");

                    b.HasIndex("ProjectProjId");

                    b.ToTable("Labor");
                });

            modelBuilder.Entity("DataLibrary.Models.Material", b =>
                {
                    b.Property<int>("MTLId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("MTLId"));

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("MTLCategory")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("MTLCode")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("MTLDescript")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("MTLPrice")
                        .HasColumnType("numeric");

                    b.Property<int>("MTLQOH")
                        .HasColumnType("integer");

                    b.Property<string>("MTLStatus")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("MTLUnit")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTimeOffset>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("MTLId");

                    b.ToTable("Material");
                });

            modelBuilder.Entity("DataLibrary.Models.Payment", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<DateTimeOffset?>("AcknowledgedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("AcknowledgedById")
                        .HasColumnType("text");

                    b.Property<decimal?>("CashAmount")
                        .HasColumnType("numeric");

                    b.Property<DateTimeOffset?>("CashPaidAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsAcknowledged")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsCashPayed")
                        .HasColumnType("boolean");

                    b.Property<string>("ProjectProjId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("checkoutUrl")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("AcknowledgedById");

                    b.HasIndex("ProjectProjId");

                    b.ToTable("Payment");
                });

            modelBuilder.Entity("DataLibrary.Models.Project", b =>
                {
                    b.Property<string>("ProjId")
                        .HasColumnType("text");

                    b.Property<string>("ClientId")
                        .HasColumnType("text");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<decimal?>("Discount")
                        .HasColumnType("numeric");

                    b.Property<decimal>("ProfitRate")
                        .HasColumnType("numeric");

                    b.Property<string>("ProjDescript")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ProjName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("SystemType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTimeOffset>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<decimal?>("VatRate")
                        .HasColumnType("numeric");

                    b.Property<decimal>("kWCapacity")
                        .HasColumnType("numeric");

                    b.HasKey("ProjId");

                    b.HasIndex("ClientId");

                    b.ToTable("Project");
                });

            modelBuilder.Entity("DataLibrary.Models.ProjectWorkLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("AssignedByAdminId")
                        .HasColumnType("text");

                    b.Property<DateTimeOffset>("DateAssigned")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("FacilitatorId")
                        .HasColumnType("text");

                    b.Property<int?>("InstallerId")
                        .HasColumnType("integer");

                    b.Property<string>("ProjectProjId")
                        .HasColumnType("text");

                    b.Property<DateTimeOffset?>("WorkEnded")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("WorkEndedReason")
                        .HasColumnType("text");

                    b.Property<DateTimeOffset?>("WorkStarted")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("AssignedByAdminId");

                    b.HasIndex("FacilitatorId");

                    b.HasIndex("InstallerId");

                    b.HasIndex("ProjectProjId");

                    b.ToTable("ProjectWorkLog");
                });

            modelBuilder.Entity("DataLibrary.Models.Requisition", b =>
                {
                    b.Property<int>("ReqId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ReqId"));

                    b.Property<int>("QuantityRequested")
                        .HasColumnType("integer");

                    b.Property<int>("RequestSupplySuppId")
                        .HasColumnType("integer");

                    b.Property<DateTimeOffset?>("ReviewedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("ReviewedById")
                        .HasColumnType("text");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTimeOffset>("SubmittedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("SubmittedById")
                        .HasColumnType("text");

                    b.HasKey("ReqId");

                    b.HasIndex("RequestSupplySuppId");

                    b.HasIndex("ReviewedById");

                    b.HasIndex("SubmittedById");

                    b.ToTable("Requisition");
                });

            modelBuilder.Entity("DataLibrary.Models.Supply", b =>
                {
                    b.Property<int>("SuppId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("SuppId"));

                    b.Property<int?>("EQPTQuantity")
                        .HasColumnType("integer");

                    b.Property<int?>("EquipmentEQPTId")
                        .HasColumnType("integer");

                    b.Property<int?>("MTLQuantity")
                        .HasColumnType("integer");

                    b.Property<int?>("MaterialMTLId")
                        .HasColumnType("integer");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<string>("ProjectProjId")
                        .HasColumnType("text");

                    b.HasKey("SuppId");

                    b.HasIndex("EquipmentEQPTId");

                    b.HasIndex("MaterialMTLId");

                    b.HasIndex("ProjectProjId");

                    b.ToTable("Supply");
                });

            modelBuilder.Entity("DataLibrary.Models.UserLogs", b =>
                {
                    b.Property<int>("LogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("LogId"));

                    b.Property<string>("Action")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("EntityId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("EntityName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTimeOffset>("Timestamp")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("UserIPAddress")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UserRole")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LogId");

                    b.HasIndex("UserId");

                    b.ToTable("UserLogs");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("DataLibrary.Models.AppUsers", b =>
                {
                    b.HasOne("DataLibrary.Models.Client", "Client")
                        .WithMany("Admin")
                        .HasForeignKey("ClientId");

                    b.Navigation("Client");
                });

            modelBuilder.Entity("DataLibrary.Models.Installer", b =>
                {
                    b.HasOne("DataLibrary.Models.AppUsers", "Admin")
                        .WithMany("Installer")
                        .HasForeignKey("AdminId");

                    b.Navigation("Admin");
                });

            modelBuilder.Entity("DataLibrary.Models.Labor", b =>
                {
                    b.HasOne("DataLibrary.Models.Project", "Project")
                        .WithMany()
                        .HasForeignKey("ProjectProjId");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("DataLibrary.Models.Payment", b =>
                {
                    b.HasOne("DataLibrary.Models.AppUsers", "AcknowledgedBy")
                        .WithMany()
                        .HasForeignKey("AcknowledgedById");

                    b.HasOne("DataLibrary.Models.Project", "Project")
                        .WithMany()
                        .HasForeignKey("ProjectProjId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AcknowledgedBy");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("DataLibrary.Models.Project", b =>
                {
                    b.HasOne("DataLibrary.Models.AppUsers", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId");

                    b.Navigation("Client");
                });

            modelBuilder.Entity("DataLibrary.Models.ProjectWorkLog", b =>
                {
                    b.HasOne("DataLibrary.Models.AppUsers", "AssignedByAdmin")
                        .WithMany()
                        .HasForeignKey("AssignedByAdminId");

                    b.HasOne("DataLibrary.Models.AppUsers", "Facilitator")
                        .WithMany()
                        .HasForeignKey("FacilitatorId");

                    b.HasOne("DataLibrary.Models.Installer", "Installer")
                        .WithMany()
                        .HasForeignKey("InstallerId");

                    b.HasOne("DataLibrary.Models.Project", "Project")
                        .WithMany()
                        .HasForeignKey("ProjectProjId");

                    b.Navigation("AssignedByAdmin");

                    b.Navigation("Facilitator");

                    b.Navigation("Installer");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("DataLibrary.Models.Requisition", b =>
                {
                    b.HasOne("DataLibrary.Models.Supply", "RequestSupply")
                        .WithMany()
                        .HasForeignKey("RequestSupplySuppId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataLibrary.Models.AppUsers", "ReviewedBy")
                        .WithMany()
                        .HasForeignKey("ReviewedById");

                    b.HasOne("DataLibrary.Models.AppUsers", "SubmittedBy")
                        .WithMany()
                        .HasForeignKey("SubmittedById");

                    b.Navigation("RequestSupply");

                    b.Navigation("ReviewedBy");

                    b.Navigation("SubmittedBy");
                });

            modelBuilder.Entity("DataLibrary.Models.Supply", b =>
                {
                    b.HasOne("DataLibrary.Models.Equipment", "Equipment")
                        .WithMany()
                        .HasForeignKey("EquipmentEQPTId");

                    b.HasOne("DataLibrary.Models.Material", "Material")
                        .WithMany()
                        .HasForeignKey("MaterialMTLId");

                    b.HasOne("DataLibrary.Models.Project", "Project")
                        .WithMany()
                        .HasForeignKey("ProjectProjId");

                    b.Navigation("Equipment");

                    b.Navigation("Material");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("DataLibrary.Models.UserLogs", b =>
                {
                    b.HasOne("DataLibrary.Models.AppUsers", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("DataLibrary.Models.AppUsers", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("DataLibrary.Models.AppUsers", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataLibrary.Models.AppUsers", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("DataLibrary.Models.AppUsers", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DataLibrary.Models.AppUsers", b =>
                {
                    b.Navigation("Installer");
                });

            modelBuilder.Entity("DataLibrary.Models.Client", b =>
                {
                    b.Navigation("Admin");
                });
#pragma warning restore 612, 618
        }
    }
}
