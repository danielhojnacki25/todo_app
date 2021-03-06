using ToDoApp.Common.Enums;
using ToDoApp.Data.Models.Common;

namespace ToDoApp.Data.Models;

public class AppTask : Entity
{
    public string? Title { get; private set; }
    public string? Description { get; private set; }
    public Status Status { get; private set; }
    public DateTime CreationDate { get; init; }
    public DateTime? EndDate { get; private set; }
    public Priority Priority { get; private set; }
    public virtual User? TargetUser { get; private set; }
    public virtual User? SourceUser { get; private set; }

    public AppTask(){}

    public AppTask(string title, string description, User targetUser, User sourceUser, Status status, Priority priority)
    {
        Title = title;
        Description = description;
        TargetUser = targetUser;
        SourceUser = sourceUser;
        Status = status;
        Priority = priority;
        CreationDate = DateTime.Now;
    }
}