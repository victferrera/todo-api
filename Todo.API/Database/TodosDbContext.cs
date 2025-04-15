using Microsoft.EntityFrameworkCore;
using Todo.API.Models;

namespace Todo.API.Database
{
    public sealed class TodosDbContext : DbContext
    {
        public DbSet<TodoItem> Todos;

        public TodosDbContext(DbContextOptions<TodosDbContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(typeof(TodoItemConfiguration).Assembly);
        }
    }
}
