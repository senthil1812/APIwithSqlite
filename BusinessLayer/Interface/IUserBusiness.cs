using BusinessModels;
using BusinessModels.HttpRequest;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Interface
{
    public interface IUserBusiness<T> : IBusiness<T>
    {
        Result<User> IsValidLogin(Login model);
    }
}
