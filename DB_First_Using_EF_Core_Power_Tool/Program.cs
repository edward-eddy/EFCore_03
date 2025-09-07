using DB_First_Using_EF_Core_Power_Tool.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace DB_First_Using_EF_Core_Power_Tool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NorthwindContext context = new NorthwindContext();

            //var Result = context.Categories.ToList();

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item.CategoryName);
            //}

            // Run SQL Query
            // 1. Select Statments : FromSqlRaw(), FromSqlInterploated()

            //var Result = context.Products.FromSqlRaw("Select * From Products Where UnitsInStock = 0");
            //int price = 10;

            //var Result = context.Products.FromSqlRaw($"Select * From Products Where UnitPrice = {price}");
            //var Result = context.Products.FromSqlRaw("Select * From Products Where UnitPrice = {0}", price);
            //var Result = context.Products.FromSqlInterploated($"Select * From Products Where UnitPrice = {price}");


            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item.ProductName);
            //}


            // 2. DML Statments [Update -Insert - Delete]: ExecuteSqlRaw(), ExecuteSqlInterploated()

            //context.Database.ExecuteSqLRaw("Update Products Set UnitsInStock = 40 Where ProductID = 1");
            //context.Database.ExecuteSqLRaw("Delete From Products Set UnitsInStock = 40 Where ProductID = 1");

            //int ID = 1;
            //context.Database.ExecuteSqLRaw("Delete From Products Set UnitsInStock = 40 Where ProductID = {0}", ID);
            //context.Database.ExecuteSqLRaw($"Delete From Products Set UnitsInStock = 40 Where ProductID = {ID}");
            //context.Database.ExecuteSqlInterploated($"Delete From Products Set UnitsInStock = 40 Where ProductID = {ID}");


        }
    }
}
