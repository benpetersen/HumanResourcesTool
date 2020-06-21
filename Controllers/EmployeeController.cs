using HRTool.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

using System.Web.Http;

namespace HRTool.Controllers
{
    public class EmployeeController : ApiController
    {
        readonly List<Employee> employees = new List<Employee>
        {
            new Employee { DepartmentId = 1, EmployeeId = 1, FirstName = "Jane", LastName = "Smith", DateStarted = new DateTime(2019, 11, 10) },
            new Employee { DepartmentId = 1, EmployeeId = 2, FirstName = "Frank", LastName = "Wolff", DateStarted = new DateTime(2020, 2, 11) },
            new Employee { DepartmentId = 1, EmployeeId = 3, FirstName = "Larry", LastName = "Ellison", DateStarted = new DateTime(2019, 10, 31) },
            new Employee { DepartmentId = 1, EmployeeId = 91, FirstName = "Cordova", LastName = "Eve", DateStarted = new DateTime(2019, 6, 21) }
        };
        readonly List<EmployeesByDate> employeesByDate = new List<EmployeesByDate>
        {
            new EmployeesByDate(new DateTime(2019, 6, 21), new List<Employee>(){
                new Employee { DepartmentId = 1, EmployeeId = 91, FirstName = "Cordova", LastName = "Eve", DateStarted = new DateTime(2019, 6, 21) }
            }),
            new EmployeesByDate(new DateTime(2019, 11, 1), new List<Employee>(){
                new Employee { DepartmentId = 2, EmployeeId = 1, FirstName = "Jane", LastName = "Smith", DateStarted = new DateTime(2019, 11, 10) },
                new Employee { DepartmentId = 1, EmployeeId = 2, FirstName = "Frank", LastName = "Wolff", DateStarted = new DateTime(2020, 2, 11) }
            }),
            new EmployeesByDate(new DateTime(2020, 2, 11), new List<Employee>(){
                new Employee { DepartmentId = 3, EmployeeId = 3, FirstName = "Larry", LastName = "Ellison", DateStarted = new DateTime(2019, 10, 31) }
            })
        };

        //TODO - Get data via API call

        [HttpGet]
        public IHttpActionResult Get(int EmployeeId)
        {
            var employee = employees.FirstOrDefault(e => e.EmployeeId == EmployeeId);
            return Ok(employee);
        }

        [HttpGet]
        public IHttpActionResult GetCountByMonthStarted()
        {
            return Ok(employeesByDate);
        }
    }
}
