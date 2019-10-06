using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Payroll.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new PayrollContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<PayrollContext>>()))
            {
                // Look for any employees
                if (context.Employee.Any())
                {
                    return; 
                }


                context.Employee.AddRange(
                    new Employee
                    {
                        FirstName = "john",
                        LastName = "Landry",
                        RateOfPay = 15.00m,
                        HoursWorked = 35.50m,
                        PayWeek = DateTime.Parse("2019-9-19")
                        

                    },
                    
                    
                    new Employee
                    {
                        FirstName = "Angela",
                        LastName = "Rush",
                        RateOfPay = 15.00m,
                        HoursWorked = 32.25m,
                        PayWeek = DateTime.Parse("2019-9-19") },
                    
                   
                   
                    new Employee
                    {
                        FirstName = "Bill",
                        LastName = "Marsh",
                        RateOfPay = 16.00m,
                        HoursWorked = 45.50m,
                        PayWeek = DateTime.Parse("2019-9-19")
                        

                    },  
                    new Employee
                    {
                        FirstName = "Peggy",
                        LastName = "Simon",
                        RateOfPay = 16.75m,
                        HoursWorked = 50m,
                        PayWeek = DateTime.Parse("2019-9-19")
                        

                    },
                    new Employee
                    {
                        FirstName = "Carl",
                        LastName = "Yost",
                        RateOfPay = 15.75m,
                        HoursWorked = 45,
                        PayWeek = DateTime.Parse("2019-9-19")
                        

                    },  
                    new Employee
                    {
                        FirstName = "Joe",
                        LastName = "Miles",
                        RateOfPay = 15.75m,
                        HoursWorked = 40,
                        PayWeek = DateTime.Parse("2019-9-19")
                        
                    }, 
                    new Employee
                    {
                        FirstName = "Joan",
                        LastName = "Jeffries",   
                        RateOfPay = 14.25m,
                        HoursWorked = 40,
                        PayWeek = DateTime.Parse("2019-9-19")
                        

                    },  
                    new Employee
                    {
                        FirstName = "George",
                        LastName = "Mills",
                        RateOfPay = 13.65m,
                        HoursWorked = 38,
                        PayWeek = DateTime.Parse("2019-9-19")
                        

                    }, 
                    new Employee
                    {
                        FirstName = "Gary",
                        LastName = "Cooper",
                        RateOfPay = 15.75m,
                        HoursWorked = 37.25m,
                        PayWeek = DateTime.Parse("2019-9-19")
                        

                    }

                    
                );
                context.SaveChanges();
            }
        }
    }
}
