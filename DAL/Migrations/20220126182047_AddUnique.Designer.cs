﻿// <auto-generated />
using System;
using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DAL.Migrations
{
    [DbContext(typeof(StoreContext))]
    [Migration("20220126182047_AddUnique")]
    partial class AddUnique
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("DAL.Campaign", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<double>("Discount")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Campaigns");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Discount = 0.0,
                            Name = "No Campaign"
                        },
                        new
                        {
                            Id = 2,
                            Discount = 0.050000000000000003,
                            Name = "Christmas Campaign"
                        },
                        new
                        {
                            Id = 3,
                            Discount = 0.10000000000000001,
                            Name = "Winter Campaign"
                        },
                        new
                        {
                            Id = 4,
                            Discount = 0.10000000000000001,
                            Name = "Party Campaign "
                        });
                });

            modelBuilder.Entity("DAL.Department", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("EmployeeRefId")
                        .HasColumnType("int");

                    b.HasKey("Name");

                    b.HasIndex("EmployeeRefId");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            Name = "Dairy products",
                            EmployeeRefId = 4
                        },
                        new
                        {
                            Name = "Fruit",
                            EmployeeRefId = 2
                        },
                        new
                        {
                            Name = "Pantry",
                            EmployeeRefId = 3
                        },
                        new
                        {
                            Name = "Drink",
                            EmployeeRefId = 5
                        },
                        new
                        {
                            Name = "Bread",
                            EmployeeRefId = 2
                        },
                        new
                        {
                            Name = "Meat products",
                            EmployeeRefId = 5
                        });
                });

            modelBuilder.Entity("DAL.DepartmentProduct", b =>
                {
                    b.Property<string>("DepartmentName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("ProductBarcode")
                        .HasColumnType("int");

                    b.HasKey("DepartmentName", "ProductBarcode");

                    b.HasIndex("ProductBarcode");

                    b.ToTable("DepartmentProducts");

                    b.HasData(
                        new
                        {
                            DepartmentName = "Dairy products",
                            ProductBarcode = 1010
                        },
                        new
                        {
                            DepartmentName = "Dairy products",
                            ProductBarcode = 1015
                        },
                        new
                        {
                            DepartmentName = "Dairy products",
                            ProductBarcode = 1018
                        },
                        new
                        {
                            DepartmentName = "Fruit",
                            ProductBarcode = 1023
                        },
                        new
                        {
                            DepartmentName = "Fruit",
                            ProductBarcode = 1025
                        },
                        new
                        {
                            DepartmentName = "Fruit",
                            ProductBarcode = 1026
                        },
                        new
                        {
                            DepartmentName = "Pantry",
                            ProductBarcode = 1032
                        },
                        new
                        {
                            DepartmentName = "Pantry",
                            ProductBarcode = 1035
                        },
                        new
                        {
                            DepartmentName = "Pantry",
                            ProductBarcode = 1038
                        },
                        new
                        {
                            DepartmentName = "Drink",
                            ProductBarcode = 1044
                        },
                        new
                        {
                            DepartmentName = "Drink",
                            ProductBarcode = 1048
                        },
                        new
                        {
                            DepartmentName = "Drink",
                            ProductBarcode = 1046
                        },
                        new
                        {
                            DepartmentName = "Bread",
                            ProductBarcode = 1055
                        },
                        new
                        {
                            DepartmentName = "Bread",
                            ProductBarcode = 1057
                        },
                        new
                        {
                            DepartmentName = "Bread",
                            ProductBarcode = 1062
                        },
                        new
                        {
                            DepartmentName = "Meat products",
                            ProductBarcode = 1068
                        },
                        new
                        {
                            DepartmentName = "Meat products",
                            ProductBarcode = 1073
                        },
                        new
                        {
                            DepartmentName = "Meat products",
                            ProductBarcode = 1077
                        });
                });

            modelBuilder.Entity("DAL.Employee", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("JobTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersonNumber")
                        .HasColumnType("int");

                    b.Property<string>("TelNr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("TrainedDate")
                        .HasColumnType("date");

                    b.Property<int?>("TrainerID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("PersonNumber")
                        .IsUnique();

                    b.HasIndex("TrainerID");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            JobTitle = "Manager",
                            Name = "Peter",
                            PersonNumber = 111,
                            TelNr = "07907821"
                        },
                        new
                        {
                            ID = 2,
                            JobTitle = "General staff",
                            Name = "Emma",
                            PersonNumber = 134,
                            TelNr = "07036271",
                            TrainedDate = new DateTime(2021, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TrainerID = 1
                        },
                        new
                        {
                            ID = 3,
                            JobTitle = "General staff",
                            Name = "Pelle",
                            PersonNumber = 126,
                            TelNr = "07807866",
                            TrainedDate = new DateTime(2021, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TrainerID = 1
                        },
                        new
                        {
                            ID = 4,
                            JobTitle = "General staff",
                            Name = "Maria",
                            PersonNumber = 154,
                            TelNr = "07007865",
                            TrainedDate = new DateTime(2021, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TrainerID = 1
                        },
                        new
                        {
                            ID = 5,
                            JobTitle = "General staff",
                            Name = "Eric",
                            PersonNumber = 144,
                            TelNr = "07907943",
                            TrainedDate = new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TrainerID = 1
                        });
                });

            modelBuilder.Entity("DAL.EmployeeMail", b =>
                {
                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.HasKey("Email", "EmployeeId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("EmployeeMails");

                    b.HasData(
                        new
                        {
                            Email = "Perter@yahoo.com",
                            EmployeeId = 1
                        },
                        new
                        {
                            Email = "Emma@msn.com",
                            EmployeeId = 2
                        },
                        new
                        {
                            Email = "Pelle@hotmail.com",
                            EmployeeId = 3
                        },
                        new
                        {
                            Email = "Pelle.karlsson@hotmail.com",
                            EmployeeId = 3
                        },
                        new
                        {
                            Email = "Maria@sina.com",
                            EmployeeId = 4
                        },
                        new
                        {
                            Email = "Eric@yahoo.com",
                            EmployeeId = 5
                        });
                });

            modelBuilder.Entity("DAL.Ingredient", b =>
                {
                    b.Property<string>("Contains")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("ProductBarcode")
                        .HasColumnType("int");

                    b.HasKey("Contains", "ProductBarcode");

                    b.HasIndex("ProductBarcode");

                    b.ToTable("Ingredients");

                    b.HasData(
                        new
                        {
                            Contains = "protein minerals vitamins",
                            ProductBarcode = 1010
                        },
                        new
                        {
                            Contains = "fat water salts protein lactose",
                            ProductBarcode = 1015
                        },
                        new
                        {
                            Contains = "milk salt acidification culture enzyme",
                            ProductBarcode = 1018
                        },
                        new
                        {
                            Contains = "apple",
                            ProductBarcode = 1023
                        },
                        new
                        {
                            Contains = "pear",
                            ProductBarcode = 1025
                        },
                        new
                        {
                            Contains = "orange",
                            ProductBarcode = 1026
                        },
                        new
                        {
                            Contains = "wheat fiber",
                            ProductBarcode = 1032
                        },
                        new
                        {
                            Contains = "sucrose",
                            ProductBarcode = 1035
                        },
                        new
                        {
                            Contains = "black tea aroma",
                            ProductBarcode = 1038
                        },
                        new
                        {
                            Contains = "carbonated water sugar dye(E150d) natural aromas",
                            ProductBarcode = 1044
                        },
                        new
                        {
                            Contains = "caffeine taurine B-vitamins sugars water",
                            ProductBarcode = 1048
                        },
                        new
                        {
                            Contains = "carbonated water sugar orange juice of concentrate citric acid",
                            ProductBarcode = 1046
                        },
                        new
                        {
                            Contains = "wheat flour water gluten rapeseed oil syrup",
                            ProductBarcode = 1055
                        },
                        new
                        {
                            Contains = "wheat flour water salt gluten yeast",
                            ProductBarcode = 1057
                        },
                        new
                        {
                            Contains = "wheat flour water salt sugar butter gluten yeast",
                            ProductBarcode = 1062
                        },
                        new
                        {
                            Contains = "beef",
                            ProductBarcode = 1068
                        },
                        new
                        {
                            Contains = "pork",
                            ProductBarcode = 1073
                        },
                        new
                        {
                            Contains = "chicken",
                            ProductBarcode = 1077
                        });
                });

            modelBuilder.Entity("DAL.Product", b =>
                {
                    b.Property<int>("Barcode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CampaignId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ExpirationDate")
                        .HasColumnType("date");

                    b.Property<DateTime>("InventoriedDate")
                        .HasColumnType("date");

                    b.Property<int>("InventoriedID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(5,2)");

                    b.HasKey("Barcode");

                    b.HasIndex("CampaignId");

                    b.HasIndex("InventoriedID");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Barcode = 1010,
                            CampaignId = 1,
                            ExpirationDate = new DateTime(2022, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            InventoriedDate = new DateTime(2022, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            InventoriedID = 4,
                            Name = "Milk",
                            Quantity = 2,
                            UnitPrice = 13.25m
                        },
                        new
                        {
                            Barcode = 1015,
                            CampaignId = 1,
                            ExpirationDate = new DateTime(2022, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            InventoriedDate = new DateTime(2022, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            InventoriedID = 4,
                            Name = "Butter",
                            Quantity = 3,
                            UnitPrice = 41.33m
                        },
                        new
                        {
                            Barcode = 1018,
                            CampaignId = 3,
                            ExpirationDate = new DateTime(2022, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            InventoriedDate = new DateTime(2022, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            InventoriedID = 4,
                            Name = "Cheese",
                            Quantity = 10,
                            UnitPrice = 89.90m
                        },
                        new
                        {
                            Barcode = 1023,
                            CampaignId = 3,
                            InventoriedDate = new DateTime(2022, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            InventoriedID = 2,
                            Name = "Apple",
                            Quantity = 12,
                            UnitPrice = 6.50m
                        },
                        new
                        {
                            Barcode = 1025,
                            CampaignId = 1,
                            InventoriedDate = new DateTime(2022, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            InventoriedID = 2,
                            Name = "Pear",
                            Quantity = 15,
                            UnitPrice = 4.50m
                        },
                        new
                        {
                            Barcode = 1026,
                            CampaignId = 1,
                            InventoriedDate = new DateTime(2022, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            InventoriedID = 2,
                            Name = "Orange",
                            Quantity = 20,
                            UnitPrice = 7.35m
                        },
                        new
                        {
                            Barcode = 1032,
                            CampaignId = 2,
                            ExpirationDate = new DateTime(2922, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            InventoriedDate = new DateTime(2021, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            InventoriedID = 3,
                            Name = "Flour",
                            Quantity = 8,
                            UnitPrice = 18.85m
                        },
                        new
                        {
                            Barcode = 1035,
                            CampaignId = 1,
                            InventoriedDate = new DateTime(2021, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            InventoriedID = 3,
                            Name = "Sugar",
                            Quantity = 5,
                            UnitPrice = 11.55m
                        },
                        new
                        {
                            Barcode = 1038,
                            CampaignId = 1,
                            ExpirationDate = new DateTime(2022, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            InventoriedDate = new DateTime(2021, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            InventoriedID = 3,
                            Name = "Fruit tea",
                            Quantity = 11,
                            UnitPrice = 28.95m
                        },
                        new
                        {
                            Barcode = 1044,
                            CampaignId = 4,
                            ExpirationDate = new DateTime(2023, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            InventoriedDate = new DateTime(2021, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            InventoriedID = 5,
                            Name = "Cola",
                            Quantity = 25,
                            UnitPrice = 14.50m
                        },
                        new
                        {
                            Barcode = 1048,
                            CampaignId = 4,
                            ExpirationDate = new DateTime(2023, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            InventoriedDate = new DateTime(2021, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            InventoriedID = 5,
                            Name = "Red bull",
                            Quantity = 6,
                            UnitPrice = 18.50m
                        },
                        new
                        {
                            Barcode = 1046,
                            CampaignId = 1,
                            ExpirationDate = new DateTime(2023, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            InventoriedDate = new DateTime(2021, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            InventoriedID = 5,
                            Name = "Fanta",
                            Quantity = 8,
                            UnitPrice = 14.50m
                        },
                        new
                        {
                            Barcode = 1055,
                            CampaignId = 1,
                            ExpirationDate = new DateTime(2022, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            InventoriedDate = new DateTime(2022, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            InventoriedID = 4,
                            Name = "Toast",
                            Quantity = 5,
                            UnitPrice = 25.68m
                        },
                        new
                        {
                            Barcode = 1057,
                            CampaignId = 1,
                            ExpirationDate = new DateTime(2022, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            InventoriedDate = new DateTime(2022, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            InventoriedID = 4,
                            Name = "Baguette",
                            Quantity = 9,
                            UnitPrice = 18.90m
                        },
                        new
                        {
                            Barcode = 1062,
                            CampaignId = 1,
                            ExpirationDate = new DateTime(2022, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            InventoriedDate = new DateTime(2022, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            InventoriedID = 4,
                            Name = "Croissant",
                            Quantity = 6,
                            UnitPrice = 10.00m
                        },
                        new
                        {
                            Barcode = 1068,
                            CampaignId = 2,
                            ExpirationDate = new DateTime(2022, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            InventoriedDate = new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            InventoriedID = 2,
                            Name = "Beef",
                            Quantity = 12,
                            UnitPrice = 396.90m
                        },
                        new
                        {
                            Barcode = 1073,
                            CampaignId = 1,
                            ExpirationDate = new DateTime(2022, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            InventoriedDate = new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            InventoriedID = 2,
                            Name = "Pork",
                            Quantity = 8,
                            UnitPrice = 76.88m
                        },
                        new
                        {
                            Barcode = 1077,
                            CampaignId = 2,
                            ExpirationDate = new DateTime(2022, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            InventoriedDate = new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            InventoriedID = 2,
                            Name = "Chicken",
                            Quantity = 7,
                            UnitPrice = 55.50m
                        });
                });

            modelBuilder.Entity("DAL.Department", b =>
                {
                    b.HasOne("DAL.Employee", "Employee")
                        .WithMany("Departments")
                        .HasForeignKey("EmployeeRefId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("DAL.DepartmentProduct", b =>
                {
                    b.HasOne("DAL.Department", "Department")
                        .WithMany("Products")
                        .HasForeignKey("DepartmentName")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("DAL.Product", "Product")
                        .WithMany("Departments")
                        .HasForeignKey("ProductBarcode")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Department");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("DAL.Employee", b =>
                {
                    b.HasOne("DAL.Employee", "Trainer")
                        .WithMany("Staffs")
                        .HasForeignKey("TrainerID")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("Trainer");
                });

            modelBuilder.Entity("DAL.EmployeeMail", b =>
                {
                    b.HasOne("DAL.Employee", "Employee")
                        .WithMany("Mails")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("DAL.Ingredient", b =>
                {
                    b.HasOne("DAL.Product", "Product")
                        .WithMany("Ingredients")
                        .HasForeignKey("ProductBarcode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("DAL.Product", b =>
                {
                    b.HasOne("DAL.Campaign", "Campaign")
                        .WithMany("Products")
                        .HasForeignKey("CampaignId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Employee", "Inventoried")
                        .WithMany("Products")
                        .HasForeignKey("InventoriedID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Campaign");

                    b.Navigation("Inventoried");
                });

            modelBuilder.Entity("DAL.Campaign", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("DAL.Department", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("DAL.Employee", b =>
                {
                    b.Navigation("Departments");

                    b.Navigation("Mails");

                    b.Navigation("Products");

                    b.Navigation("Staffs");
                });

            modelBuilder.Entity("DAL.Product", b =>
                {
                    b.Navigation("Departments");

                    b.Navigation("Ingredients");
                });
#pragma warning restore 612, 618
        }
    }
}
