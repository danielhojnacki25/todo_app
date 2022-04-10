using ToDoApp.Common.Dtos.Common;
using ToDoApp.Common.Dtos.Users;
using ToDoApp.Common.Enums;

namespace ToDoApp.Common.Dtos.AppTasks;

public sealed class AppTaskDto : EntityDto
{
    public string? Title { get; set; }
    public string? Description { get; set; }
    public Status Status { get; set; }
    public DateTime CreationDate { get; set; }
    public DateTime? EndDate { get; set; }
    public Priority Priority { get; set; }
    public  UserDto? TargetUser { get; set; }
    public  UserDto? SourceUser { get; set; }

    public AppTaskDto()
    {
        TargetUser = new UserDto();
        SourceUser = new UserDto();
    }
}