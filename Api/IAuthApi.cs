using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Models;

namespace TaskManager.Api
{
    public interface IAuthApi
    {

        [Post("api/auth/register")]
        Task<ApiResult> RegisterAsync([Body] RegisterModel registerModel);



        [Post("api/auth/login")]
        Task<ApiResult<string>> LoginAsync([Body] LoginModel loginModel);
    }
}
