using BusinessModels;
using DataLayer.DBContext;
using DataLayer.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Repository
{
    public class EmployeeRepository : BaseRepository<Employee>, IEmployeeRepository
    {
        private readonly RepoDBContext _repositoryContext;

        public EmployeeRepository(RepoDBContext repositoryContext) : base(repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }
    }
}
