using MediatR;
using ToDoApp.Common.Dtos.AppTasks;
using ToDoApp.Mappers.AppTasks;
using ToDoApp.Repository.AppTasks;

namespace ToDoApp.Services.AppTasks.Queries.GetAppTaskById;

public class GetAppTaskByIdQueryHandler : IRequestHandler<GetAppTaskByIdQuery, AppTaskDto?>
{
    private readonly IAppTaskRepository _appTaskRepository;
    
    public GetAppTaskByIdQueryHandler(IAppTaskRepository appTaskRepository)
        => _appTaskRepository = appTaskRepository;

    public async Task<AppTaskDto?> Handle(GetAppTaskByIdQuery request, CancellationToken cancellationToken)
        => (await _appTaskRepository.GetByIdAsync(request.Id))?.MapToDto();

}