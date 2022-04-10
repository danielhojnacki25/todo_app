namespace ToDoApp.Repository;

public interface IBaseRepository<T> where T : class
{
    Task<T?> GetByIdAsync(int id);
}