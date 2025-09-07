using Castle.Components.DictionaryAdapter.Xml;
using EFCore_03.Contexts;
using EFCore_03.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCore_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //using AppDbContext context = new AppDbContext();

            #region Loading Navigational Property
            //var departments = new List<Department>()
            //{
            //    new Department() { Name = "HR" },
            //    new Department() { Name = "PR" },
            //    new Department() { Name = "IT" },
            //};

            //var employees = new List<Employee>()
            //{
            //    new Employee() { Name = "Ahmed Ali", Address = "Cairo", Age = 29, Salary = 12000, DeptId = 100 },
            //    new Employee() { Name = "Omar Ali", Address = "Giza", Age = 32, Salary = 15000, DeptId = 100 },
            //    new Employee() { Name = "Mona Ali", Address = "Cairo", Age = 25, Salary = 13000, DeptId = 100 },
            //    new Employee() { Name = "Ahmed Khaled", Address = "Nasr City", Age = 30, Salary = 17000, DeptId = 200 },
            //    new Employee() { Name = "Mariam Ahmed", Address = "Alex", Age = 24, Salary = 10000, DeptId = 200 },
            //    new Employee() { Name = "Maha Ahmed", Address = "Alex", Age = 25, Salary = 14000, DeptId = 300 },
            //    new Employee() { Name = "Mohamed Ali", Address = "Cairo", Age = 33, Salary = 18000, DeptId = 100 }
            //};


            //context.Departments.AddRange(departments);
            //context.Employees.AddRange(employees);

            //context.SaveChanges();

            //var employee = context.Employees.FirstOrDefault(E => E.Id == 10);

            //Console.WriteLine(employee?.Id ?? 0);
            //Console.WriteLine(employee?.Name ?? "NA");
            //Console.WriteLine(employee?.Salary ?? 0.0f);
            //Console.WriteLine(employee?.Address ?? "NA");
            //Console.WriteLine(employee?.HiringDate ?? DateTime.Now);
            //Console.WriteLine(employee?.DeptId ?? 0);
            //Console.WriteLine(employee?.WorkAt?.Name ?? "NA");

            //var department = context.Departments.FirstOrDefault(D => D.Id == 100);

            //Console.WriteLine(department.Name);

            //foreach (var item in department.Employees)
            //{
            //    Console.WriteLine(item.Name);
            //}


            // NOTE: EF Core Don't Loading Any Navigational Property

            // EF Core Loading Navigational Property
            // 1. Explicit Loading
            // 2. Eager Loading
            // 3. Lazing Loading


            #region 1. Explicit Loading
            // 1. Explicit Loading

            //var employee = context.Employees.FirstOrDefault(E => E.Id == 10);

            ////context.Entry(employee).Reference("WorkAt").Load();
            ////context.Entry(employee).Reference(nameof(Employee.WorkAt)).Load();
            //context.Entry(employee).Reference(E=>E.WorkAt).Load();

            //Console.WriteLine(employee?.Id ?? 0);
            //Console.WriteLine(employee?.Name ?? "NA");
            //Console.WriteLine(employee?.Salary ?? 0.0f);
            //Console.WriteLine(employee?.Address ?? "NA");
            //Console.WriteLine(employee?.HiringDate ?? DateTime.Now);
            //Console.WriteLine(employee?.DeptId ?? 0);
            //Console.WriteLine(employee?.WorkAt?.Name ?? "NA");


            //var department = context.Departments.FirstOrDefault(D => D.Id == 100);
            //context.Entry(department).Collection(D => D.Employees).Load();


            //Console.WriteLine(department.Name);

            //foreach (var item in department.Employees)
            //{
            //    Console.WriteLine(item.Name);
            //} 
            #endregion

            #region 2. Eager Loading
            // 2. Eager Loading

            //var employee = context.Employees.Include(E => E.WorkAt).FirstOrDefault(E => E.Id == 10);

            //Console.WriteLine(employee?.Id ?? 0);
            //Console.WriteLine(employee?.Name ?? "NA");
            //Console.WriteLine(employee?.Salary ?? 0.0f);
            //Console.WriteLine(employee?.Address ?? "NA");
            //Console.WriteLine(employee?.HiringDate ?? DateTime.Now);
            //Console.WriteLine(employee?.DeptId ?? 0);
            //Console.WriteLine(employee?.WorkAt?.Name ?? "NA");


            ////var department = context.Departments.Include().Include().ThenInclude().FirstOrDefault(D => D.Id == 100);
            //var department = context.Departments.Include(D => D.Employees).FirstOrDefault(D => D.Id == 100);


            //Console.WriteLine(department.Name);

            //foreach (var item in department.Employees)
            //{
            //    Console.WriteLine(item.Name);
            //} 
            #endregion

            #region 3. Lazing Loading
            // 3. Lazing Loading

            // 3.1. Intstall Package Proxies
            // 3.2. Update OnConfiguring(), Use UseLazyLoadingProxies
            // 3.3. Make All Entities Public
            // 3.4. Make All Navogational Properties Virtual

            //var employee = context.Employees.FirstOrDefault(E => E.Id == 10);

            //Console.WriteLine(employee?.Id ?? 0);
            //Console.WriteLine(employee?.Name ?? "NA");
            //Console.WriteLine(employee?.Salary ?? 0.0f);
            //Console.WriteLine(employee?.Address ?? "NA");
            //Console.WriteLine(employee?.HiringDate ?? DateTime.Now);
            //Console.WriteLine(employee?.DeptId ?? 0);
            //Console.WriteLine(employee?.WorkAt?.Name ?? "NA");


            //var department = context.Departments.FirstOrDefault(D => D.Id == 100);


            //Console.WriteLine(department.Name);

            //foreach (var item in department.Employees)
            //{
            //    Console.WriteLine(item.Name);
            //}  
            #endregion
            #endregion

            #region Join Operators - Join inner
            //// Join Operators - Join

            ///*
            //Select E.Id, E.Name, D.Id, D.Name
            //From Employees E, Departments D
            //Where D. Id = E.DeptId -- PK = FK
            //*/

            //// Fluent Syntax
            //var result = context.Employees.Join(context.Departments, E => E.DeptId, D => D.Id, (E, D) => new
            //{
            //    EmpdId = E.Id,
            //    EmpName = E.Name,
            //    DeptId = D.Id,
            //    DeptName = D.Name
            //}).Where(E => E.DeptName == "HR");


            //// Query Expression

            //result = from E in context.Employees
            //         join D in context.Departments
            //         on E.DeptId equals D.Id
            //         where D.Name == "HR"
            //         select new
            //         {
            //             EmpdId = E.Id,
            //             EmpName = E.Name,
            //             DeptId = D.Id,
            //             DeptName = D.Name
            //         };

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Tracking vs NoTracking
            // Tracking vs NoTracking
            // Tracking

            //using AppDbContext context = new AppDbContext();

            //var result = context.Employees.AsNoTracking().FirstOrDefault(E => E.Id == 10);

            //Console.WriteLine(context.Entry(result).State); // Unchanged

            //result.Name = "Ali"; // Local

            //Console.WriteLine(context.Entry(result).State); // Modified

            //Console.WriteLine(result.Name);

            //context.SaveChanges(); // Remotly 
            #endregion

            #region Local Vs Remote
            // Local Vs Remote

            //using AppDbContext context = new AppDbContext();

            // Remotly
            //context.Employees.Any();
            //context.Employees.Any();
            //context.Employees.Any();
            //context.Employees.Any();
            //context.Employees.Any();
            //context.Employees.Any();
            //context.Employees.Any();
            //context.Employees.Any();

            // Localy
            //context.Employees.Load();

            //context.Employees.Local.Any();
            //context.Employees.Local.Any();
            //context.Employees.Local.Any();
            //context.Employees.Local.Any();
            //context.Employees.Local.Any();
            //context.Employees.Local.Any();
            //context.Employees.Local.Any();
            //context.Employees.Local.Any(); 
            #endregion


        }
    }
}
