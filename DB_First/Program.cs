using DB_First.Data.Contexts;
using DB_First.Data.Model;
using Microsoft.EntityFrameworkCore;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DB_First
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using AppDbContext context = new AppDbContext();

            //Category category = new Category()
            //{
            //    CategoryName = "Hamda",
            //    Description = "Hamda"
            //};

            //context.Categories.Add(category);

            //context.SaveChanges();

            //var result = context.Categories.ToList();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.CategoryName);
            //    Console.WriteLine();
            //    foreach (var product in item.Products)
            //    {
            //        Console.WriteLine(product);
            //    }
            //}

        }
    }
}
