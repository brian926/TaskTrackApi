using TaskTrackerApi.Models;
namespace TaskTrackerApi.Services.Task
{
    public interface ITaskService
    {
        void CreateTask(Tasks task);
        void DeleteTask(Guid id);
        Tasks GetTask(Guid id);
        void UpsertTask(Tasks task);
    }
}