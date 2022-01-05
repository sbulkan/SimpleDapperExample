using Microsoft.AspNetCore.Mvc;
using SimpleDapperExample.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepo _repo;
        public EmployeeController(IEmployeeRepo repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IActionResult GetEmployees()
        {
            var employees = _repo.GetEmployees();
            return Ok(employees);
        }
    }
}
