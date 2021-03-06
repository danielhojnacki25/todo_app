using ToDoApp.Common.Dtos.AppTasks;
using ToDoApp.Data.Models;
using ToDoApp.Mappers.Users;

namespace ToDoApp.Mappers.AppTasks;

public static class AppTaskMapper
{
    public static AppTaskDto MapToDto(this AppTask task) => new()
    {
        Id = task.Id,
        CreationDate = task.CreationDate,
        Description = task.Description,
        EndDate = task.EndDate,
        Priority = task.Priority,
        TargetUser = task.TargetUser?.MapToDto(),
        SourceUser = task.SourceUser?.MapToDto(),
        Status = task.Status,
        Title = task.Title
    };
}