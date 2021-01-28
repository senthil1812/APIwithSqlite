using BusinessModels;
using DataLayer.DBContext;
using DataLayer.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Repository
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        private readonly RepoDBContext _repositoryContext;

        public UserRepository(RepoDBContext repositoryContext) : base(repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }
    }
}
