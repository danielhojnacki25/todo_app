using MediatR;
using ToDoApp.Common.Dtos.AppTasks;

namespace ToDoApp.Services.AppTasks.Queries.GetAppTaskById;

public class GetAppTaskByIdQuery: IRequest<AppTaskDto?>
{
    public GetAppTaskByIdQuery(int id)
        => Id = id;
    
    public int Id { get; set; }
}