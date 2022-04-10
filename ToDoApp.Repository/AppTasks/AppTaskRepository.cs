using Microsoft.EntityFrameworkCore;
using ToDoApp.Data;
using ToDoApp.Data.Models;

namespace ToDoApp.Repository.AppTasks;

public class AppTaskRepository : BaseRepository<AppTask>, IAppTaskRepository
{
    public AppTaskRepository(IDbContextFactory<ApplicationDbContext> dbContextFactory) : base(dbContextFactory)
    {
    }
}