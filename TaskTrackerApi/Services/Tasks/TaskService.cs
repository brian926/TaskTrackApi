using TaskTrackerApi.Models;

namespace TaskTrackerApi.Services.Task
{
    public class TaskService : ITaskService
    {
        private readonly Dictionary<Guid, Tasks> _tasks = new();
        public void CreateTask(Tasks task)
        {
            _tasks.Add(task.Id, task);
        }

        public Tasks GetTask(Guid id)
        {
            return _tasks[id];
        }
    }
}