using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcManager.Data;
using System;
using System.Linq;

namespace MvcManager.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcManagerContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcManagerContext>>()))
            {

                if (context.Manager.Any())
                {
                    return;   // DB has been seeded
                }
                context.Manager.AddRange(
                    new Manager
                    {
                        EmployeeID = "EM001",
                        EmployeeName = "John Carter",
                        Department = "HR",
                        Salary = 3000
                    },
                    new Manager
                    {
                        EmployeeID = "EM002",
                        EmployeeName = "Micheal Bean",
                        Department = "SC",
                        Salary = 1300
                    },
                     new Manager
                     {
                         EmployeeID = "EM003",
                         EmployeeName = "Jimmy Flod",
                         Department = "MD",
                         Salary = 2000
                     },
                      new Manager
                      {
                          EmployeeID = "EM004",
                          EmployeeName = "Mary Brown",
                          Department = "MD",
                          Salary = 2000
                      }
                );
                context.SaveChanges();
            }
        }
    }
}
