using Microsoft.EntityFrameworkCore;
using ToDoApp.Data;

namespace ToDoApp.Repository;

public class BaseRepository<T> : IBaseRepository<T> where T : class
{
    private readonly IDbContextFactory<ApplicationDbContext> _dbContextFactory;

    public BaseRepository(IDbContextFactory<ApplicationDbContext> dbContextFactory)
        => _dbContextFactory = dbContextFactory;

    public async Task<T?> GetByIdAsync(int id)
    {
        await using var context = await _dbContextFactory.CreateDbContextAsync();
        return await context.Set<T>().FindAsync(id);
    }
}