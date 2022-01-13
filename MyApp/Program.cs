//using DAL;
//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Linq;

//namespace MyApp
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Test2();
//            //using var context2 = new StoreContext();
//            //var count1 = context2.Employees.
//            //    Where(e => e.Name = "Peter").ToList();          
//        }
//        private static void Test()
//        {
//            using var context = new StoreContext();
//            var person1 = new Employee
//            {
//                ID = 1,
//                PersonNumber = 111,
//                Name = "Peter",
//                JobTitle = "Manager",
//                TelNr = "07907821"
//            };
//            context.Employees.Add(person1);
//            var count = context.SaveChanges();
//            Console.WriteLine(count);
//        }
//        private static void Test2()
//        {
//            using var context1 = new StoreContext();
//            var person = context1.Employees.ToList();
//            foreach (var item in person)
//            {
//                Console.WriteLine(item.Name);
//            }
//        }
//         private static void Test3()
//        {
//            using var context1 = new StoreContext();
//            var person = context1.Employees.ToList();
//            foreach (var item in person)
//            {
//                Console.WriteLine(item.Name);
//            }
//        }

//        private static void Demo()
//        {
//            using var context2 = new StoreContext();
//            var person2 = context2.Employees.Find("1");
//             person2.Name = "Adam";
//            var changes = context2.ChangeTracker.Entries();
//            context2.SaveChanges();
//            Console.ReadKey();
//        }
//        private static void Demo1()
//        {
//            using var context3 = new StoreContext();
//            var p1 = context3.Employees.First(e=>e.Name=="Emma");
//            var p4 = context3.Employees.Where(e => e.Name == "Emma").First();
//            var p2 = context3.Employees.FirstOrDefault(e => e.Name == "Emma");
//            var p3 = context3.Employees.Find("1"); //only primary key
//        }
//        private static void Demo2()
//        {
//            using var context4 = new StoreContext();
//            var depart = context4.Products.Include(d => d.Name).First(d => d.Quantity == 2);
//            Console.WriteLine($"Product:{depart.Name}-{(depart.Name == null ? "no product":depart.Name)}");
//        }
//    }
//}
