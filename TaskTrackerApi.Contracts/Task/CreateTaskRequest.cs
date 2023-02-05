namespace TaskTrackerApi.Contracts.Task
{
    public record CreateTaskRequest(
        string Name,
        string Description,
        DateTime StartDateTime,
        DateTime EndDateTime,
        Boolean Reminder
    );
}