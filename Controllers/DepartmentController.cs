using HumanResourcesAdmin.Models;
using System;
using System.Collections.Generic;
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
            return Ok(departments);
        }
    }
}
