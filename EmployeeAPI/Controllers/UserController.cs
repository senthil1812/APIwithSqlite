using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Interface;
using BusinessModels;
using BusinessModels.HttpRequest;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserBusiness<User> _userBusiness;

        public UserController(IUserBusiness<User> userBusiness)
        {
            _userBusiness = userBusiness;
        }

        // GET: api/User
        [HttpPost]
        public IActionResult Post([FromBody] Login model)
        {
            try
            {
                var result = _userBusiness.IsValidLogin(model);
                return new JsonResult(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
