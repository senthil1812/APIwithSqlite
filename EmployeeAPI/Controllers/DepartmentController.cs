using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Interface;
using BusinessModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentBusiness<Department> _departmentBusiness;

        public DepartmentController(IDepartmentBusiness<Department> departmentBusiness)
        {
            _departmentBusiness = departmentBusiness;
        }

        // GET: api/User
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var result = _departmentBusiness.GetAll();
                return new JsonResult(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
