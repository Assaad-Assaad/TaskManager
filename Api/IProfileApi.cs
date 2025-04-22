using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Api
{
    [Headers("Authorization: Bearer")]
    public interface IProfileApi
    {
        [Put("api/me/update-name")]
        Task<ApiResult<string>> UpdateName([Body] string name);

        

        [Put("api/me/change-password")]
        Task<ApiResult> UpdatePassword([Body] string password);
    }
}
