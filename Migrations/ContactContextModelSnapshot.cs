﻿// <auto-generated />
using System;
using ContactManager.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ContactManger.Migrations
{
    [DbContext(typeof(ContactContext))]
    partial class ContactContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0");

            modelBuilder.Entity("ContactManager.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            Name = "Family"
                        },
                        new
                        {
                            CategoryId = 2,
                            Name = "Friend"
                        },
                        new
                        {
                            CategoryId = 3,
                            Name = "Work"
                        },
                        new
                        {
                            CategoryId = 4,
                            Name = "Other"
                        });
                });

            modelBuilder.Entity("ContactManager.Models.Contact", b =>
                {
                    b.Property<int>("ContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Organisation")
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .HasColumnType("TEXT");

                    b.HasKey("ContactId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Contacts");

                    b.HasData(
                        new
                        {
                            ContactId = 1,
                            CategoryId = 2,
                            DateAdded = new DateTime(2023, 2, 20, 18, 9, 1, 57, DateTimeKind.Local).AddTicks(3160),
                            Email = "delores@hotmail.com",
                            FirstName = "Delores",
                            LastName = "Del RIo",
                            Organisation = "",
                            Phone = "555-987-6543"
                        },
                        new
                        {
                            ContactId = 2,
                            CategoryId = 3,
                            DateAdded = new DateTime(2023, 2, 20, 18, 9, 1, 57, DateTimeKind.Local).AddTicks(3570),
                            Email = "efren@hotmail.com",
                            FirstName = "Efren",
                            LastName = "Herrera",
                            Organisation = "",
                            Phone = "555-456-7890"
                        },
                        new
                        {
                            ContactId = 3,
                            CategoryId = 3,
                            DateAdded = new DateTime(2023, 2, 20, 18, 9, 1, 57, DateTimeKind.Local).AddTicks(3580),
                            Email = "jzuo.govst.edu",
                            FirstName = "Jun",
                            LastName = "Zuo",
                            Organisation = "",
                            Phone = "7085344539"
                        },
                        new
                        {
                            ContactId = 4,
                            CategoryId = 1,
                            DateAdded = new DateTime(2023, 2, 20, 18, 9, 1, 57, DateTimeKind.Local).AddTicks(3580),
                            Email = "maryellen@yahoo.com",
                            FirstName = "Mary Ellen",
                            LastName = "Walton",
                            Organisation = "",
                            Phone = "555-123-4567"
                        });
                });

            modelBuilder.Entity("ContactManager.Models.Contact", b =>
                {
                    b.HasOne("ContactManager.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
