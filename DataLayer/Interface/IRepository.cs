using BusinessModels;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Interface
{
    public interface IRepository<T>
    {
        Result<T> Create(T data);
        Result<T> Update(T data);
        Result<T> Delete(int id);
        Result<T> Select(int id);
        Result<List<T>> GetAll();

        Task<Result<T>> CreateAsync(T data);
        Result<T> GetByConditionAync(Expression<Func<T, bool>> expression);

    }
}
