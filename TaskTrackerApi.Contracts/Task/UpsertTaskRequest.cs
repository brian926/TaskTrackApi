namespace TaskTrackerApi.Contracts.Task
{
    public record UpsertTaskRequest(
        string Name,
        string Description,
        DateTime StartDateTime,
        DateTime EndDateTime,
        Boolean Reminder
    );
}