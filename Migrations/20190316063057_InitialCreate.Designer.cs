﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using bit285_assignment3_api.Models;

namespace bit285_assignment3_api.Migrations
{
    [DbContext(typeof(BitDataContext))]
    [Migration("20190316063057_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("bit285_assignment3_api.Models.Activity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ActivityDate");

                    b.Property<long?>("ActorId");

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.HasIndex("ActorId");

                    b.ToTable("Activities");
                });

            modelBuilder.Entity("bit285_assignment3_api.Models.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmailAddress")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("Password");

                    b.Property<int>("Program");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("bit285_assignment3_api.Models.Activity", b =>
                {
                    b.HasOne("bit285_assignment3_api.Models.User", "Actor")
                        .WithMany("Activities")
                        .HasForeignKey("ActorId");
                });
#pragma warning restore 612, 618
        }
    }
}
