﻿// <auto-generated />
using System;
using CSharpWars.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CSharpWars.DataAccess.Migrations
{
    [DbContext(typeof(CSharpWarsDbContext))]
    partial class CSharpWarsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0-preview.19074.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CSharpWars.Model.Bot", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CurrentHealth");

                    b.Property<int>("CurrentStamina");

                    b.Property<int>("LocationX");

                    b.Property<int>("LocationY");

                    b.Property<int>("MaximumHealth");

                    b.Property<int>("MaximumStamina");

                    b.Property<string>("Memory");

                    b.Property<string>("Name");

                    b.Property<int>("Orientation");

                    b.Property<int>("PreviousMove");

                    b.Property<string>("Script");

                    b.Property<int>("SysId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<Guid?>("TeamId");

                    b.HasKey("Id")
                        .HasAnnotation("SqlServer:Clustered", false);

                    b.HasIndex("SysId")
                        .HasAnnotation("SqlServer:Clustered", true);

                    b.HasIndex("TeamId");

                    b.ToTable("BOTS");
                });

            modelBuilder.Entity("CSharpWars.Model.Player", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("Secret");

                    b.Property<int>("SysId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id")
                        .HasAnnotation("SqlServer:Clustered", false);

                    b.HasIndex("SysId")
                        .HasAnnotation("SqlServer:Clustered", true);

                    b.ToTable("PLAYERS");
                });

            modelBuilder.Entity("CSharpWars.Model.Bot", b =>
                {
                    b.HasOne("CSharpWars.Model.Player", "Team")
                        .WithMany("Bots")
                        .HasForeignKey("TeamId");
                });
#pragma warning restore 612, 618
        }
    }
}
