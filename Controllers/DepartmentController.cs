using HumanResourcesAdmin.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HRTool.Controllers
{
    public class DepartmentController : ApiController
    {
        readonly List<Department> departments = new List<Department>
        {
            new Department { Id = 1, Name = "IT" },
            new Department { Id = 2, Name = "HR" },
            new Department { Id = 3, Name = "Administration" },
        };

        //TODO - Get Departments via API call
        [HttpGet]
        public IHttpActionResult Get()
        {
            var departments = new List<Department>();
            try
            {
                string connStr = ConfigurationManager.ConnectionStrings["AzureOrganizationConnString"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(connStr))
                {
                    string query = "SELECT * FROM Department Order by Id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                departments.Add(new Department()
                                {
                                    Id = reader.GetInt32(0),
                                    Name = reader.GetString(1)
                                });
                            }
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                throw new Exception("Error retrieving Department data: " + e.Message.ToString());
            }



            return Ok(departments);
        }
    }
}
