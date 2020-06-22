using HRTool.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web.Http;
using System.Configuration;
using System.Data;
using FastMember;

namespace HRTool.Controllers
{
    public class EmployeeController : ApiController
    {

        [HttpGet]
        public IHttpActionResult GetCountByMonthStarted()
        {
            var employeesByDate = new List<EmployeesByDate>();
            try
            {
                string connStr = ConfigurationManager.ConnectionStrings["AzureOrganizationConnString"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(connStr))
                {
                    string query = "SELECT CONVERT(NVARCHAR(7),JoinedDate,120) [Date], Id as EmployeeId, DepartmentId, FirstName, LastName FROM Employee GROUP BY CONVERT(NVARCHAR(7), JoinedDate, 120), Id, DepartmentId, FirstName, LastName ORDER BY[Date]";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                //Add to existing lists if the date is present, otherwise add a new one.
                                var date = DateTime.Parse(reader.GetString(0));
                                if (employeesByDate.Any(e => e.Date == date))
                                {
                                    var emp = employeesByDate.Find(e => e.Date == date);
                                    emp.Employees.Add(new Employee()
                                    {
                                        EmployeeId = reader.GetInt32(1),
                                        DepartmentId = reader.GetInt32(2),
                                        FirstName = reader.GetString(3),
                                        LastName = reader.GetString(4)
                                    });
                                }
                                else
                                {
                                    employeesByDate.Add(new EmployeesByDate()
                                    {
                                        Date = date,
                                        Employees = new List<Employee>() { new Employee(){
                                        EmployeeId = reader.GetInt32(1),
                                        DepartmentId = reader.GetInt32(2),
                                        FirstName = reader.GetString(3),
                                        LastName = reader.GetString(4)
                                    } }
                                    });
                                }
                            }
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                throw new Exception("Error retrieving Employee data: " + e.Message.ToString());
            }

            return Ok(employeesByDate);
        }
    }
}
