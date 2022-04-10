using ToDoApp.Common.Dtos.Users;
using ToDoApp.Data.Models;

namespace ToDoApp.Mappers.Users;

public static class UserMapper
{
    public static UserDto MapToDto(this User user) => new()
    {
        Id = user.Id,
    };
}