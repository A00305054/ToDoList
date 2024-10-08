using Microsoft.EntityFrameworkCore;
using TodoList.Models;

namespace TodoList.API.Data  // Ensure this matches
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        {
        }

        public DbSet<ToDoItem> ToDoItems { get; set; }
    }
}
