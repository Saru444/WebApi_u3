using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder builder)
        {
            var p1 = new Employee { ID = 1, PersonNumber = 111, Name = "Peter", JobTitle = "Manager", TelNr = "07907821", TrainedDate = null };
            builder.Entity<Employee>().HasData(
                p1,
                new Employee { ID = 2, PersonNumber = 134, Name = "Emma", JobTitle = "General staff", TelNr = "07036271", TrainerID = p1.ID, TrainedDate = new DateTime(2021, 07, 01) },
                new Employee { ID = 3, PersonNumber = 126, Name = "Pelle", JobTitle = "General staff", TelNr = "07807866", TrainerID = p1.ID, TrainedDate = new DateTime(2021, 08, 01) },
                new Employee { ID = 4, PersonNumber = 154, Name = "Maria", JobTitle = "General staff", TelNr = "07007865", TrainerID = p1.ID, TrainedDate = new DateTime(2021, 09, 01) },
                new Employee { ID = 5, PersonNumber = 144, Name = "Eric", JobTitle = "General staff", TelNr = "07907943", TrainerID = p1.ID, TrainedDate = new DateTime(2021, 10, 01) }
                );

            builder.Entity<EmployeeMail>().HasData(
                new EmployeeMail { EmployeeId = 1, Email = "Perter@yahoo.com" },
                new EmployeeMail { EmployeeId = 2, Email = "Emma@msn.com" },
                new EmployeeMail { EmployeeId = 3, Email = "Pelle@hotmail.com" },
                new EmployeeMail { EmployeeId = 3, Email = "Pelle.karlsson@hotmail.com" },
                new EmployeeMail { EmployeeId = 4, Email = "Maria@sina.com" },
                new EmployeeMail { EmployeeId = 5, Email = "Eric@yahoo.com" }
                );

            builder.Entity<Department>().HasData(
               new Department { Name = "Dairy products", EmployeeRefId = 4 },
               new Department { Name = "Fruit", EmployeeRefId = 2 },
               new Department { Name = "Pantry", EmployeeRefId = 3 },
               new Department { Name = "Drink", EmployeeRefId = 5 },
               new Department { Name = "Bread", EmployeeRefId = 2 },
               new Department { Name = "Meat products", EmployeeRefId = 5 }
               );

            builder.Entity<Campaign>().HasData(
                new Campaign { Id = 1, Discount = 0.00, Name = "No Campaign" },
                new Campaign { Id = 2, Discount = 0.05, Name = "Christmas Campaign" },
                new Campaign { Id = 3, Discount = 0.10, Name = "Winter Campaign" },
                new Campaign { Id = 4, Discount = 0.10, Name = "Party Campaign " }
                );

            builder.Entity<Product>().HasData(
                new Product { Barcode = 1010, Name = "Milk", Quantity = 2, UnitPrice = 13.25, ExpirationDate = new DateTime(2022, 01, 20), InventoriedID = 4, InventoriedDate = new DateTime(2022, 01, 10), CampaignId = 1 },
                new Product { Barcode = 1015, Name = "Butter", Quantity = 3, UnitPrice = 41.33, ExpirationDate = new DateTime(2022, 02, 03), InventoriedID = 4, InventoriedDate = new DateTime(2022, 01, 10), CampaignId = 1 },
                new Product { Barcode = 1018, Name = "Cheese", Quantity = 10, UnitPrice = 89.90, ExpirationDate = new DateTime(2022, 02, 05), InventoriedID = 4, InventoriedDate = new DateTime(2022, 01, 10), CampaignId = 3 },
                new Product { Barcode = 1023, Name = "Apple", Quantity = 12, UnitPrice = 6.50, ExpirationDate = null, InventoriedID = 2, InventoriedDate = new DateTime(2022, 01, 09), CampaignId = 3 },
                new Product { Barcode = 1025, Name = "Pear", Quantity = 15, UnitPrice = 4.50, ExpirationDate = null, InventoriedID = 2, InventoriedDate = new DateTime(2022, 01, 09), CampaignId = 1 },
                new Product { Barcode = 1026, Name = "Orange", Quantity = 20, UnitPrice = 7.35, ExpirationDate = null, InventoriedID = 2, InventoriedDate = new DateTime(2022, 01, 09), CampaignId = 1 },
                new Product { Barcode = 1032, Name = "Flour", Quantity = 8, UnitPrice = 18.85, ExpirationDate = new DateTime(2922, 05, 06), InventoriedID = 3, InventoriedDate = new DateTime(2021, 12, 23), CampaignId = 2 },
                new Product { Barcode = 1035, Name = "Sugar", Quantity = 5, UnitPrice = 11.55, ExpirationDate = null, InventoriedID = 3, InventoriedDate = new DateTime(2021, 12, 23), CampaignId = 1 },
                new Product { Barcode = 1038, Name = "Fruit tea", Quantity = 11, UnitPrice = 28.95, ExpirationDate = new DateTime(2022, 12, 20), InventoriedID = 3, InventoriedDate = new DateTime(2021, 12, 23), CampaignId = 1 },
                new Product { Barcode = 1044, Name = "Cola", Quantity = 25, UnitPrice = 14.50, ExpirationDate = new DateTime(2023, 02, 02), InventoriedID = 5, InventoriedDate = new DateTime(2021, 12, 05), CampaignId = 4 },
                new Product { Barcode = 1048, Name = "Red bull", Quantity = 6, UnitPrice = 18.50, ExpirationDate = new DateTime(2023, 01, 02), InventoriedID = 5, InventoriedDate = new DateTime(2021, 12, 05), CampaignId = 4 },
                new Product { Barcode = 1046, Name = "Fanta", Quantity = 8, UnitPrice = 14.50, ExpirationDate = new DateTime(2023, 02, 02), InventoriedID = 5, InventoriedDate = new DateTime(2021, 12, 25), CampaignId = 1 },
                new Product { Barcode = 1055, Name = "Toast", Quantity = 5, UnitPrice = 25.68, ExpirationDate = new DateTime(2022, 01, 20), InventoriedID = 4, InventoriedDate = new DateTime(2022, 01, 07), CampaignId = 1 },
                new Product { Barcode = 1057, Name = "Baguette", Quantity = 9, UnitPrice = 18.90, ExpirationDate = new DateTime(2022, 01, 15), InventoriedID = 4, InventoriedDate = new DateTime(2022, 01, 10), CampaignId = 1 },
                new Product { Barcode = 1062, Name = "Croissant", Quantity = 6, UnitPrice = 10.00, ExpirationDate = new DateTime(2022, 01, 14), InventoriedID = 4, InventoriedDate = new DateTime(2022, 01, 10), CampaignId = 1 },
                new Product { Barcode = 1068, Name = "Beef", Quantity = 12, UnitPrice = 396.90, ExpirationDate = new DateTime(2022, 01, 14), InventoriedID = 2, InventoriedDate = new DateTime(2021, 12, 30), CampaignId = 2 },
                new Product { Barcode = 1073, Name = "Pork", Quantity = 8, UnitPrice = 76.88, ExpirationDate = new DateTime(2022, 01, 15), InventoriedID = 2, InventoriedDate = new DateTime(2021, 12, 30), CampaignId = 1 },
                new Product { Barcode = 1077, Name = "Chicken", Quantity = 7, UnitPrice = 55.50, ExpirationDate = new DateTime(2022, 01, 06), InventoriedID = 2, InventoriedDate = new DateTime(2021, 12, 30), CampaignId = 2 }
                );

            builder.Entity<DepartmentProduct>().HasData(
                new DepartmentProduct { DepartmentName = "Dairy products", ProductBarcode = 1010 },
                new DepartmentProduct { DepartmentName = "Dairy products", ProductBarcode = 1015 },
                new DepartmentProduct { DepartmentName = "Dairy products", ProductBarcode = 1018 },
                new DepartmentProduct { DepartmentName = "Fruit", ProductBarcode = 1023 },
                new DepartmentProduct { DepartmentName = "Fruit", ProductBarcode = 1025 },
                new DepartmentProduct { DepartmentName = "Fruit", ProductBarcode = 1026 },
                new DepartmentProduct { DepartmentName = "Pantry", ProductBarcode = 1032 },
                new DepartmentProduct { DepartmentName = "Pantry", ProductBarcode = 1035 },
                new DepartmentProduct { DepartmentName = "Pantry", ProductBarcode = 1038 },
                new DepartmentProduct { DepartmentName = "Drink", ProductBarcode = 1044 },
                new DepartmentProduct { DepartmentName = "Drink", ProductBarcode = 1048 },
                new DepartmentProduct { DepartmentName = "Drink", ProductBarcode = 1046 },
                new DepartmentProduct { DepartmentName = "Bread", ProductBarcode = 1055 },
                new DepartmentProduct { DepartmentName = "Bread", ProductBarcode = 1057 },
                new DepartmentProduct { DepartmentName = "Bread", ProductBarcode = 1062 },
                new DepartmentProduct { DepartmentName = "Meat products", ProductBarcode = 1068 },
                new DepartmentProduct { DepartmentName = "Meat products", ProductBarcode = 1073 },
                new DepartmentProduct { DepartmentName = "Meat products", ProductBarcode = 1077 }
                );

            builder.Entity<Ingredient>().HasData(
                new Ingredient { ProductBarcode = 1010, Contains = "protein minerals vitamins" },
                new Ingredient { ProductBarcode = 1015, Contains = "fat water salts protein lactose" },
                new Ingredient { ProductBarcode = 1018, Contains = "milk salt acidification culture enzyme" },
                new Ingredient { ProductBarcode = 1023, Contains = "apple" },
                new Ingredient { ProductBarcode = 1025, Contains = "pear" },
                new Ingredient { ProductBarcode = 1026, Contains = "orange" },
                new Ingredient { ProductBarcode = 1032, Contains = "wheat fiber" },
                new Ingredient { ProductBarcode = 1035, Contains = "sucrose" },
                new Ingredient { ProductBarcode = 1038, Contains = "black tea aroma" },
                new Ingredient { ProductBarcode = 1044, Contains = "carbonated water sugar dye(E150d) natural aromas" },
                new Ingredient { ProductBarcode = 1048, Contains = "caffeine taurine B-vitamins sugars water" },
                new Ingredient { ProductBarcode = 1046, Contains = "carbonated water sugar orange juice of concentrate citric acid" },
                new Ingredient { ProductBarcode = 1055, Contains = "wheat flour water gluten rapeseed oil syrup" },
                new Ingredient { ProductBarcode = 1057, Contains = "wheat flour water salt gluten yeast" },
                new Ingredient { ProductBarcode = 1062, Contains = "wheat flour water salt sugar butter gluten yeast" },
                new Ingredient { ProductBarcode = 1068, Contains = "beef" },
                new Ingredient { ProductBarcode = 1073, Contains = "pork" },
                new Ingredient { ProductBarcode = 1077, Contains = "chicken" }
                );
        }
    }
}
