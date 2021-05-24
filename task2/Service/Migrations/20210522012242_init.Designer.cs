﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Service;

namespace Service.Migrations
{
    [DbContext(typeof(BankingContext))]
    [Migration("20210522012242_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasPostgresEnum(null, "transaction_direction", new[] { "income", "outcome" })
                .HasPostgresEnum(null, "transaction_status", new[] { "pending", "completed", "declined" })
                .HasPostgresEnum(null, "transaction_type", new[] { "transfer", "fee", "fx" })
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("Service.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<decimal>("Balance")
                        .HasColumnType("numeric")
                        .HasColumnName("balance");

                    b.Property<string>("Currency")
                        .HasColumnType("text")
                        .HasColumnName("currency");

                    b.Property<string>("Name")
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("accounts");
                });

            modelBuilder.Entity("Service.Transaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("AccountId")
                        .HasColumnType("integer")
                        .HasColumnName("account_id");

                    b.Property<decimal>("Amount")
                        .HasColumnType("numeric")
                        .HasColumnName("amount");

                    b.Property<string>("Currency")
                        .HasColumnType("text")
                        .HasColumnName("currency");

                    b.Property<TransactionDirection>("Direction")
                        .HasColumnType("transaction_direction")
                        .HasColumnName("direction");

                    b.Property<TransactionStatus>("Status")
                        .HasColumnType("transaction_status")
                        .HasColumnName("status");

                    b.Property<TransactionType>("Type")
                        .HasColumnType("transaction_type")
                        .HasColumnName("type");

                    b.HasKey("Id");

                    b.ToTable("transactions");
                });
#pragma warning restore 612, 618
        }
    }
}
