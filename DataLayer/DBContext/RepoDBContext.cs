using BusinessModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.DBContext
{
    public class RepoDBContext : DbContext
    {

        public RepoDBContext(DbContextOptions<RepoDBContext> options) : base(options)
        {

        }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }

    }
}
