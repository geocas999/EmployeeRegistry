namespace EmployeesRegister.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using EmployeesRegister.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<EmployeesRegister.DataAccessLayer.EmployeesContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EmployeesRegister.DataAccessLayer.EmployeesContext context)
        {
            context.Employees.AddOrUpdate(
              e => e.FirstName, 
              new Employee { FirstName = "George", LastName ="Caspersson", Department= "IT", Position= "CEO", Id = 1, Salary=50000, Company="MyWayDesign" },
              new Employee { FirstName = "Emma", LastName = "Caspersson", Department = "HR", Position = "HR-specialist", Id = 2, Salary = 35000, Company = "MyWayDesign" },
              new Employee { FirstName = "Matilda", LastName = "Caspersson", Department = "ACC", Position = "Accounts", Id = 3, Salary = 30000, Company = "MyWayDesign" },
              new Employee { FirstName = "Emil", LastName = "Andersson", Department = "Sales", Position = "Sales Manager", Salary = 37000, Company = "MyWayDesign" }
            );

            //Skapar en ny tabell Companies
            //context.Companies.AddOrUpdate(
            //    c => c.Id,
            //    new Company { Id = 1, Name = "MyWayDesign"},
            //    new Company { Id = 2, Name = "YourWayData"}
            //    );



            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
