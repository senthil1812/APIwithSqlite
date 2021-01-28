using BusinessLayer.Interface;
using BusinessModels;
using DataLayer.Interface;
using DataLayer.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Classes
{
    public class DepartmentBusiness : BaseBusiness<Department>, IDepartmentBusiness<Department>
    {
        private readonly IDepartmentRepository _repository;

        public DepartmentBusiness(IDepartmentRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
