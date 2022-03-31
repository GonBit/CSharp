using NUnit.Framework;
using TodoApi;
using TodoApi.Models;
using TodoApi.Controllers;
using TodoApi.Services;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Moq;

namespace TodoAPITests
{
    public class TodoItemControllerShould
    {

        private TodoItemsController? _sut;

        [Test]
        public void BeAbleToBeConstructed()
        {
            var mockService = new Mock<ITodoItemService>();
            _sut = new TodoItemsController(mockService.Object);
            Assert.That(_sut, Is.InstanceOf<TodoItemsController>());
        }


        [Test]
        public void ReturnNoContentResult_WhenUpdateIsCalled_WithValidId()
        {
            // Arrange
            var mockService = new Mock<ITodoItemService>();
            var item = new TodoItem {Id = 1, IsComplete = true, Name = "Sweep hallway", Secret = "I don't live here" };
            mockService.Setup(cs => cs.GetTodoItemByIdAsync(1)).ReturnsAsync(item);
            _sut = new TodoItemsController(mockService.Object);
            // Act
            var result = _sut.UpdateTodoItem(1, new TodoItemDTO { Id = 1, IsComplete = false});

            // Assert
            Assert.That(result.Result, Is.InstanceOf<NoContentResult>());
        }


        [Test]
        public void ReturnBadRequestResult_WhenUpdateIsCalled_WithIdThatDoesntMatchDET()
        {
            // Arrange
            var mockService = new Mock<ITodoItemService>();
   //         var originalItem = new TodoItem { Id = 1, IsComplete = true, Name = "Sweep hallway", Secret = "I don't live here" };
  //          mockService.Setup(cs => cs.GetTodoItemByIdAsync(1)).ReturnsAsync(originalItem);
            _sut = new TodoItemsController(mockService.Object);
            // Act
            var result = _sut.UpdateTodoItem(2, new TodoItemDTO { Id = 1, IsComplete = false });

            // Assert
            Assert.That(result.Result, Is.InstanceOf<BadRequestResult>());
        }

        [Test]
        public void ReturnNotFoundResult_WhenUpdateIsCalled_AndADatabaseExceptionIsThrown()
        {
            // Arrange
            var mockService = new Mock<ITodoItemService>();
            mockService.Setup(cs => cs.GetTodoItemByIdAsync(It.IsAny<int>())).ReturnsAsync(new TodoItem());
            mockService.Setup(cs => cs.SaveTodoItemChangesAsync()).Throws<DbUpdateConcurrencyException>();
            _sut = new TodoItemsController(mockService.Object);
            // Act
            var result = _sut.UpdateTodoItem(1, new TodoItemDTO { Id = 1, IsComplete = false });

            // Assert
            Assert.That(result.Result, Is.InstanceOf<NotFoundResult>());
        }

        [Test]
        public void CallsSaveToDoItemChanges_WhenUpdateIsCalled_WithValidId()
        {
            // Arrange
            var mockService = new Mock<ITodoItemService>();
            var item = new TodoItem { Id = 1, IsComplete = true, Name = "Sweep hallway", Secret = "I don't live here" };
            mockService.Setup(cs => cs.GetTodoItemByIdAsync(1)).ReturnsAsync(item);
            _sut = new TodoItemsController(mockService.Object);

            // Act
            var result = _sut.UpdateTodoItem(1, new TodoItemDTO { Id = 1, IsComplete = false });

            // Assert
            mockService.Verify(cs => cs.GetTodoItemByIdAsync(1), Times.Once);
            mockService.Verify(cs => cs.SaveTodoItemChangesAsync(), Times.Once);
        }

    }
}