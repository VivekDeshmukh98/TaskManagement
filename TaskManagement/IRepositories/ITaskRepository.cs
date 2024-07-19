using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskManagement.Models;

namespace TaskManagement.Repositories
{
   public interface ITaskRepository
    {
        Task AddTaskAsync(TaskItem task);
        Task DeleteTaskAsync(int id);
        Task<IEnumerable<TaskItem>> GetAllTasksAsync();
        Task<TaskItem> GetTaskByIdAsync(int id);
        Task UpdateTaskAsync(TaskItem task);
    }
}
