using InheritanceExample.Contexts;
using InheritanceExample.Models;
using System.Net;

namespace InheritanceExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 3 Ways To Generate Schema
            // 1. TPC : Table Per Class
            // 2. TPH : Table Per Hierarchy
            // 3. TPCC : Table Per Concert Class

            using AppBdContext context = new AppBdContext();

            //FullTimeEmployee fullTime01 = new FullTimeEmployee()
            //{
            //    Name = "Ahmed Ali",
            //    Address = "Cairo",
            //    Email = "AhmedAli@gmail.com",
            //    Salary = 12000
            //};

            //FullTimeEmployee fullTime02 = new FullTimeEmployee()
            //{
            //    Name = "Ahmed Khaled",
            //    Address = "Alex",
            //    Email = "AhmedKhaled@gmail.com",
            //    Salary = 15000
            //};

            PartTimeEmployee partTime01 = new PartTimeEmployee()
            {
                Name = "Mariam Ali",
                Address = "Cairo",
                Email = "AhmedAli@gmail.com",
                HourRate = 120,
                NumberOfHours = 160
            };

            PartTimeEmployee partTime02 = new PartTimeEmployee()
            {
                Name = "Mouhamed Ahmed",
                Address = "Alex",
                Email = "AhmedKhaled@gmail.com",
                HourRate = 180,
                NumberOfHours = 260
            };


            //context.FullTimeEmployees.Add(fullTime01);
            //context.FullTimeEmployees.Add(fullTime02);
            context.PartTimeEmployees.AddRange(new List<PartTimeEmployee> { partTime01, partTime02 });
            context.SaveChanges();



            //foreach (var item in context.Employees)
            //{
            //    Console.WriteLine(item.Name);
            //}


            //var Result = context.Employees.OfType<FullTimeEmployee>();

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item.Name);
            //}






        }
    }
}
