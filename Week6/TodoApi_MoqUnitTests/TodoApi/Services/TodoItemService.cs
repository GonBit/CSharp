using TodoApi.Models;


namespace TodoApi.Services
{
    public class TodoItemService : ITodoItemService
        
    {
        private readonly TodoContext _context;

        public TodoItemService(TodoContext context)
        {
            _context = context;
        }

        public async Task CreateTodoItemAsync(TodoItem item)
        {
           _context.TodoItems.Add(item);
            await _context.SaveChangesAsync();
        }

        public async Task<TodoItem> GetTodoItemByIdAsync(long id)
        {
            return await _context.TodoItems.FindAsync(id);
        }

        public List<TodoItem> GetTodoItems()
        {
            return _context.TodoItems.ToList();
        }

        public async Task RemoveTodoItemAsync(TodoItem item)
        {
            _context.TodoItems.Remove(item);
            await _context.SaveChangesAsync();
        }

        public async Task SaveTodoItemChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

        public bool TodoItemExists(long id)
        {
            return _context.TodoItems.Any(e => e.Id == id);
        }
    }
}
