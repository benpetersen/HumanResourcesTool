using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRTool.Models
{
    public class EmployeesByDate
    {
        //Assists in grouping employees by date (month and year) for the view
        public EmployeesByDate()
        {
        }

        public DateTime Date { get; set; }
        public List<Employee> Employees { get; set; }
    }
}