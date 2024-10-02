using TodoList.Models;
using Xunit;

namespace TodoList.Tests
{
    public class ToDoItemTests
    {
        [Fact]
        public void Can_Create_ToDoItem()
        {
            var todoItem = new ToDoItem { Id = 1, Description = "Test ToDo" };
            Assert.NotNull(todoItem);
            Assert.Equal(1, todoItem.Id);
            Assert.Equal("Test ToDo", todoItem.Description);
        }

        [Fact]
        public void Can_Set_CompletedDate()
        {
            var todoItem = new ToDoItem { CompletedDate = DateTime.Now };
            Assert.NotNull(todoItem.CompletedDate);
        }

        [Fact]
        public void Can_Change_Description()
        {
            var todoItem = new ToDoItem { Description = "Initial Description" };
            todoItem.Description = "Updated Description";
            Assert.Equal("Updated Description", todoItem.Description);
        }

        [Fact]
        public void Can_Set_DueDate()
        {
            var todoItem = new ToDoItem { DueDate = DateTime.Now.AddDays(2) };
            Assert.True(todoItem.DueDate > DateTime.Now);
        }
    }
}
