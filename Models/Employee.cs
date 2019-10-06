using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Storage;

namespace Payroll.Models
{
    public class Employee
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal RateOfPay { get; set; }
        public decimal HoursWorked { get; set; }
        [DataType(DataType.Date)]
        public DateTime PayWeek { get; set; }

    }
}
