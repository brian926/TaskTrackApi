using TaskTrackerApi.Models;

namespace TaskTrackerApi.Services.Task
{
    public class TaskService : ITaskService
    {
        private static readonly Dictionary<Guid, Tasks> _tasks = new();
        public void CreateTask(Tasks task)
        {
            _tasks.Add(task.Id, task);
        }

        public void DeleteTask(Guid id)
        {
            _tasks.Remove(id);
        }

        public Tasks GetTask(Guid id)
        {
            return _tasks[id];
        }

        public void UpsertTask(Tasks task)
        {
            _tasks[task.Id] = task;
        }
    }
}