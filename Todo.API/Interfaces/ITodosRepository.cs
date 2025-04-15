namespace Todo.API.Interfaces
{
    public interface ITodosRepository
    {
        Task Create(Models.TodoItem item);
    }
}
