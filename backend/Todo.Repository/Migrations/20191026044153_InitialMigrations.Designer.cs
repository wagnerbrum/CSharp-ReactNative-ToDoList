﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Todo.Repository.Data;

namespace Todo.Repository.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20191026044153_InitialMigrations")]
    partial class InitialMigrations
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Todo.Domain.Entities.Item", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("nome");

                    b.Property<int?>("todoid");

                    b.HasKey("id");

                    b.HasIndex("todoid");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("Todo.Domain.Entities.ToDo", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("descricao");

                    b.HasKey("id");

                    b.ToTable("Todos");
                });

            modelBuilder.Entity("Todo.Domain.Entities.Item", b =>
                {
                    b.HasOne("Todo.Domain.Entities.ToDo", "todo")
                        .WithMany("items")
                        .HasForeignKey("todoid");
                });
#pragma warning restore 612, 618
        }
    }
}
