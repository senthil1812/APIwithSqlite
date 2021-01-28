using BusinessLayer.Interface;
using BusinessModels;
using DataLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Classes
{
    class BaseBusiness
    {
    }
    public class BaseBusiness<T> : IBusiness<T>
    {
        private readonly IRepository<T> _repository;

        public BaseBusiness(IRepository<T> baseRepository)
        {
            _repository = baseRepository;
        }

        public Result<List<T>> GetAll()
        {
            return _repository.GetAll();
        }

        public Result<T> Select(int id)
        {
            return _repository.Select(id);
        }

        public Result<T> Create(T data)
        {
            return _repository.Create(data);
        }

        public async Task<Result<T>> CreateAsync(T data)
        {
            return await _repository.CreateAsync(data);
        }

        public Result<T> Update(T data)
        {
            return _repository.Update(data);
        }

        public Result<T> Delete(int id)
        {
            return _repository.Delete(id);
        }

        public Result<T> GetByConditionAync(Expression<Func<T, bool>> expression)
        {
            return _repository.GetByConditionAync(expression);
        }

    }
}
