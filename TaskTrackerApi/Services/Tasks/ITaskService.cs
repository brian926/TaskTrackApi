using TaskTrackerApi.Models;
namespace TaskTrackerApi.Services.Task
{
    public interface ITaskService
    {
        void CreateTask(Tasks task);
        Tasks GetTask(Guid id);
    }
}