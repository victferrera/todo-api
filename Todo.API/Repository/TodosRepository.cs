using Todo.API.Database;
using Todo.API.Interfaces;
using Todo.API.Models;

namespace Todo.API.Repository
{
    public sealed class TodosRepository : ITodosRepository
    {
        private TodosDbContext _context;

        public TodosRepository(TodosDbContext context) => _context = context;

        public async Task Create(TodoItem item)
        {
            _context.Add(item);
            _context.SaveChanges();
        }
    }
}
