﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Server.Entities;

#nullable disable

namespace AspNetDemo.Migrations
{
    [DbContext(typeof(ParaLanchesDBContext))]
    [Migration("20250224124900_ImplementsInvite")]
    partial class ImplementsInvite
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Server.Entities.ApplicationUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("InvitedByUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("InvitedByUserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Server.Entities.ApplicationUser", b =>
                {
                    b.HasOne("Server.Entities.ApplicationUser", "InvitedBy")
                        .WithMany("InviteUsers")
                        .HasForeignKey("InvitedByUserId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("InvitedBy");
                });

            modelBuilder.Entity("Server.Entities.ApplicationUser", b =>
                {
                    b.Navigation("InviteUsers");
                });
#pragma warning restore 612, 618
        }
    }
}
