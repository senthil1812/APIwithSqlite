using BusinessLayer.Interface;
using BusinessModels;
using BusinessModels.HttpRequest;
using DataLayer.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Classes
{
    public class UserBusiness : BaseBusiness<User>, IUserBusiness<User>
    {
        private readonly IUserRepository _repository;

        public UserBusiness(IUserRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public Result<User> IsValidLogin(Login model)
        {
            try
            {
                var result = new Result<User>();
                var usercheck = _repository.GetByConditionAync( X=>X.UserName == model.UserName);
                if(usercheck.Data != null)
                {
                    var passwordcheck = _repository.GetByConditionAync(X => X.UserName == model.UserName && X.Password == model.Password);

                    if (passwordcheck.Data != null)
                    {
                        result.Data = passwordcheck.Data;
                        result.SuccessMessage = "Login Success!!";
                        result.IsSuccess = true;
                    }
                    else
                    {
                        result.Data = null;
                        result.SuccessMessage = "Invalid Password!!";
                        result.IsSuccess = false;
                    }
                }
                else
                {
                    result.Data = null;
                    result.SuccessMessage = "Invalid User Name!!";
                    result.IsSuccess = false;
                }
                return result;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
