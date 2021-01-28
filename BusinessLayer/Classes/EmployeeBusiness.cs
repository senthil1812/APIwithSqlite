using BusinessLayer.Interface;
using BusinessModels;
using DataLayer.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Classes
{
    public class EmployeeBusiness : BaseBusiness<Employee>, IEmployeeBusiness<Employee>
    {
        private readonly IEmployeeRepository _repository;

        public EmployeeBusiness(IEmployeeRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
