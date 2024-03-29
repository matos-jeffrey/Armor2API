﻿// <auto-generated />
using Armor2BuildAPI.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Armor2BuildAPI.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20190905070041_InitialBuild")]
    partial class InitialBuild
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Armor2BuildAPI.Entities.Mod", b =>
                {
                    b.Property<int>("ModID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Affinity")
                        .IsRequired();

                    b.Property<string>("Armor")
                        .IsRequired();

                    b.Property<int>("Cost");

                    b.Property<string>("Description");

                    b.Property<string>("ImageURL");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("ModID");

                    b.ToTable("Mods");
                });
#pragma warning restore 612, 618
        }
    }
}
