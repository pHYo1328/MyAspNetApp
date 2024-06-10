using Microsoft.EntityFrameworkCore;
using TodoApp.Models;

public class ToDoContext : DbContext
{
    public ToDoContext(DbContextOptions<ToDoContext> options) : base(options)
    {
    }

    public DbSet<ToDoItem> ToDoItems { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ToDoItem>().HasData(
            new ToDoItem { Id = 1, Name = "Task 1", IsComplete = false, Detail = "Detail for Task 1" },
            new ToDoItem { Id = 2, Name = "Task 2", IsComplete = true, Detail = "Detail for Task 2" }
        );
    }
}
