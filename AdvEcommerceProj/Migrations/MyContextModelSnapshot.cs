﻿// <auto-generated />
using System;
using AdvEcommerceProj.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AdvEcommerceProj.Migrations
{
    [DbContext(typeof(MyContext))]
    partial class MyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AdvEcommerceProj.Models.Category", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("name");

                    b.HasKey("id");

                    b.ToTable("category");
                });

            modelBuilder.Entity("AdvEcommerceProj.Models.CreditCardInfocs", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("creditcardnumber");

                    b.Property<DateTime>("expdate");

                    b.Property<int>("orderid");

                    b.HasKey("id");

                    b.HasIndex("orderid");

                    b.ToTable("creditcardinfo");
                });

            modelBuilder.Entity("AdvEcommerceProj.Models.Customers", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age");

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.Property<string>("Phone");

                    b.HasKey("id");

                    b.ToTable("customers");
                });

            modelBuilder.Entity("AdvEcommerceProj.Models.Order", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Quantity");

                    b.Property<int>("customerid");

                    b.Property<DateTime>("order_date");

                    b.HasKey("id");

                    b.HasIndex("customerid");

                    b.ToTable("order");
                });

            modelBuilder.Entity("AdvEcommerceProj.Models.Products", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<decimal>("Price");

                    b.Property<int>("Stock");

                    b.Property<int?>("categoryid");

                    b.Property<int>("catid");

                    b.Property<int>("sid");

                    b.Property<int?>("supplierid");

                    b.HasKey("ID");

                    b.HasIndex("categoryid");

                    b.HasIndex("supplierid");

                    b.ToTable("products");
                });

            modelBuilder.Entity("AdvEcommerceProj.Models.Supplier", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("Name");

                    b.Property<string>("Phone");

                    b.HasKey("id");

                    b.ToTable("supplier");
                });

            modelBuilder.Entity("AdvEcommerceProj.Models.CreditCardInfocs", b =>
                {
                    b.HasOne("AdvEcommerceProj.Models.Order", "order")
                        .WithMany()
                        .HasForeignKey("orderid")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AdvEcommerceProj.Models.Order", b =>
                {
                    b.HasOne("AdvEcommerceProj.Models.Customers", "customer")
                        .WithMany("order")
                        .HasForeignKey("customerid")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AdvEcommerceProj.Models.Products", b =>
                {
                    b.HasOne("AdvEcommerceProj.Models.Category", "category")
                        .WithMany("product")
                        .HasForeignKey("categoryid");

                    b.HasOne("AdvEcommerceProj.Models.Supplier", "supplier")
                        .WithMany("products")
                        .HasForeignKey("supplierid");
                });
#pragma warning restore 612, 618
        }
    }
}
