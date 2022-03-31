using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TodoApi.Models;

namespace TodoApi.Services
{
    public interface ITodoItemService
    {
        public List<TodoItem> GetTodoItems();
        public Task<TodoItem> GetTodoItemByIdAsync(long id);
        public Task CreateTodoItemAsync(TodoItem item);
        public Task SaveTodoItemChangesAsync();
        public Task RemoveTodoItemAsync(TodoItem item);
        public bool TodoItemExists(long id);
    }
}
