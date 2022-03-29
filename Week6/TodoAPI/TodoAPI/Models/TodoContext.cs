using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace TodoApi.Models
{
    public class TodoContext : DbContext
    {
        //used for mocking
        public TodoContext(DbContextOptions<TodoContext> options) : base(options)
        {
        }

        public TodoContext()
        { 
            
        }

        public DbSet<TodoItem> TodoItems { get; set; } = null!;
    }
}
