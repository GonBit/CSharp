using NUnit.Framework;
using TodoApi;
using TodoApi.Models;
using TodoApi.Services;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;


namespace TodoAPITests
{
    public class ServiceTests
    {
        private TodoContext? _context;
        private ITodoItemService? _sut;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            var options = new DbContextOptionsBuilder<TodoContext>()
                .UseInMemoryDatabase(databaseName: "TodoDB").Options;
            _context = new TodoContext(options);
            _sut = new TodoItemService(_context);
            _sut.CreateTodoItemAsync(new TodoItem { IsComplete = true, Name = "Walk dog", Secret = "I don't like the dog" }).Wait();
            _sut.CreateTodoItemAsync(new TodoItem { IsComplete = false, Name = "Wash dishes", Secret = "I don't use soap"}).Wait();
        }

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GivenAValidId_GetTodoItemById_ReturnsCorrectItem()
        {
            var result = _sut.GetTodoItemByIdAsync(2).Result;
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.TypeOf<TodoItem>());
            Assert.That(result.Name, Is.EqualTo("Wash dishes"));
        }

        [Test]
        public void GetToDoItems_ReturnsAListOfAllItems()
        {
            var result = _sut.GetTodoItems();
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.TypeOf <List<TodoItem>>());
            Assert.That(result.Count, Is.EqualTo(2));  
        }

        [Test]
        public void CreateTodoItem_AddsAnItemToTheDatabase()
        {
            // how many items are in the database?
            int originalNumItems = _sut.GetTodoItems().Count();
            var newTodoItem = new TodoItem { IsComplete = true, Name = "Sweep hallway", Secret = "I don't live here" };
            var result = _sut.CreateTodoItemAsync(newTodoItem);
            // make sure the number of items has increased by 1
            int newNumItems = _sut.GetTodoItems().Count();
            Assert.That(newNumItems, Is.EqualTo(originalNumItems + 1));

            // remove the new item from the database
            _sut.RemoveTodoItemAsync(newTodoItem).Wait();
        }

    }
}