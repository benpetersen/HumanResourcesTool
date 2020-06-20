using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRTool.Models
{
    public class EmployeesByDate
    {
        public EmployeesByDate(DateTime date, List<int> employeeIds)
        {
            Date = date;
            EmployeeIds = employeeIds;
        }
        public DateTime Date { get; set; }
        public List<int> EmployeeIds { get; set; }
    }
}