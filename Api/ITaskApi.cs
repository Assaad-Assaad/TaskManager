using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Models;

namespace TaskManager.Api
{
    [Headers("Authorization: Bearer")]
    public interface ITaskApi
    {
        [Get("api/tasks/categories")]
        Task<ApiResult<CategoryModel[]>> GetCategoriesAsync();

        [Get("api/tasks")]
        Task<ApiResult<TaskModel[]>> GetTasksAysnc();

        [Get("api/tasks/{taskId}")]
        Task<ApiResult<TaskModel>> GetTaskByIdAsync(int taskId);


        [Post("api/tasks")]
        Task<ApiResult<TaskModel>> CreateTask([Body] TaskModel taskModel);

        [Put("api/tasks/{taskId}")]
        Task<ApiResult<TaskModel>> UpdateTask(int taskId, [Body] TaskModel taskModel);

        [Delete("api/tasks/{taskId}")]
        Task<ApiResult> DeleteTaskAsync(int taskId);

    }
}
