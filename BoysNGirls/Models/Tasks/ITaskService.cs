using System.Collections.Generic;

namespace BoysNGirls.Models.Tasks
{
    // Interface for the Task Service
    public interface ITaskService
    {
        List<Task> GetTasks(int id);
    }
}
