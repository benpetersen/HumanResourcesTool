using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRTool.Models
{
    public class EmployeesByDate
    {
        public EmployeesByDate(DateTime date, List<Employee> employees)
        {
            Date = date;
            Employees = employees;
        }
        public DateTime Date { get; set; }
        public List<Employee> Employees { get; set; }
    }
}