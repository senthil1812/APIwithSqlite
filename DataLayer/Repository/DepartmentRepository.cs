using BusinessModels;
using DataLayer.DBContext;
using DataLayer.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Repository
{
    public class DepartmentRepository : BaseRepository<Department>, IDepartmentRepository
    {
        private readonly RepoDBContext _repositoryContext;

        public DepartmentRepository(RepoDBContext repositoryContext) : base(repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }
    }
}
