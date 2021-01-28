using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Interface;
using BusinessModels;
using BusinessModels.HttpRequestResponse;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeBusiness<Employee> _employeeBusiness;
        private readonly IDepartmentBusiness<Department> _departmentBusiness;
        public EmployeeController(IEmployeeBusiness<Employee> employeeBusiness, IDepartmentBusiness<Department> departmentBusiness)
        {
            _employeeBusiness = employeeBusiness;
            _departmentBusiness = departmentBusiness;
        }

        // GET: api/User
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var response = new List<EmployeeResponse>();
                var result = _employeeBusiness.GetAll();
                var departments = _departmentBusiness.GetAll();
                if(result.Data != null)
                {
                    IEnumerable<EmployeeResponse> _empresponse = from _item in result.Data
                                                                   join _department in departments.Data on _item.Department equals _department.Id into records
                                                                   from rows in records.DefaultIfEmpty()
                                                                   select new EmployeeResponse
                                                                   {
                                                                       Id = _item.Id,
                                                                       Name = _item.Name,
                                                                       Email = _item.Email,
                                                                       Dob = _item.Dob,
                                                                       Department = _item.Department,
                                                                       DepartmentName = rows.Name
                                                                   };
                    response = _empresponse.ToList();
                }
                return new JsonResult(response);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // GET: api/User/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            try
            {
                var result = _employeeBusiness.Select(id);
                return new JsonResult(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // POST: api/User
        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] Employee model)
        {
            try
            {
                var result = await _employeeBusiness.CreateAsync(model);
                return new JsonResult(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // PUT: api/User/5
        [HttpPut]
        public IActionResult Put([FromBody] Employee model)
        {
            try
            {
                var result = _employeeBusiness.Update(model);
                return new JsonResult(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var result = _employeeBusiness.Delete(id);
                return new JsonResult(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
