namespace TaskTrackerApi.Contracts.Task
{
    public record TaskResponse(
        Guid Id,
        string Name,
        string Description,
        DateTime StartDateTime,
        DateTime EndDateTime,
        DateTime LastModifiedDateTime,
        Boolean Reminder
    );
}