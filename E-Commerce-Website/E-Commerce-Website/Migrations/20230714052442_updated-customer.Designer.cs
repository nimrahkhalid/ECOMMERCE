﻿// <auto-generated />
using E_Commerce_Website.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace E_Commerce_Website.Migrations
{
    [DbContext(typeof(myContext))]
    [Migration("20230714052442_updated-customer")]
    partial class updatedcustomer
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("E_Commerce_Website.Models.Admin", b =>
                {
                    b.Property<int>("admin_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("admin_id"), 1L, 1);

                    b.Property<string>("admin_email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("admin_image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("admin_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("admin_password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("admin_id");

                    b.ToTable("tbl_admin");
                });

            modelBuilder.Entity("E_Commerce_Website.Models.Cart", b =>
                {
                    b.Property<int>("cart_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("cart_id"), 1L, 1);

                    b.Property<int>("cart_status")
                        .HasColumnType("int");

                    b.Property<int>("cust_id")
                        .HasColumnType("int");

                    b.Property<int>("prod_id")
                        .HasColumnType("int");

                    b.Property<int>("product_quantity")
                        .HasColumnType("int");

                    b.HasKey("cart_id");

                    b.ToTable("tbl_cart");
                });

            modelBuilder.Entity("E_Commerce_Website.Models.Category", b =>
                {
                    b.Property<int>("category_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("category_id"), 1L, 1);

                    b.Property<string>("category_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("category_id");

                    b.ToTable("tbl_category");
                });

            modelBuilder.Entity("E_Commerce_Website.Models.Customer", b =>
                {
                    b.Property<int>("customer_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("customer_id"), 1L, 1);

                    b.Property<string>("customer_address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("customer_city")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("customer_country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("customer_email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("customer_gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("customer_image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("customer_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("customer_password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("customer_phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("customer_id");

                    b.ToTable("tbl_customer");
                });

            modelBuilder.Entity("E_Commerce_Website.Models.Faqs", b =>
                {
                    b.Property<int>("faq_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("faq_id"), 1L, 1);

                    b.Property<string>("faq_answer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("faq_question")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("faq_id");

                    b.ToTable("tbl_faqs");
                });

            modelBuilder.Entity("E_Commerce_Website.Models.Feedback", b =>
                {
                    b.Property<int>("feedback_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("feedback_id"), 1L, 1);

                    b.Property<string>("user_message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("user_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("feedback_id");

                    b.ToTable("tbl_feedback");
                });

            modelBuilder.Entity("E_Commerce_Website.Models.Product", b =>
                {
                    b.Property<int>("product_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("product_id"), 1L, 1);

                    b.Property<int>("cat_id")
                        .HasColumnType("int");

                    b.Property<string>("product_description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("product_image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("product_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("product_price")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("product_id");

                    b.HasIndex("cat_id");

                    b.ToTable("tbl_product");
                });

            modelBuilder.Entity("E_Commerce_Website.Models.Product", b =>
                {
                    b.HasOne("E_Commerce_Website.Models.Category", "Category")
                        .WithMany("Product")
                        .HasForeignKey("cat_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("E_Commerce_Website.Models.Category", b =>
                {
                    b.Navigation("Product");
                });
#pragma warning restore 612, 618
        }
    }
}
