using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AspNetCoreTodo.Models;

namespace ToDoAspNetCore.Services
{
    public interface ITodoItemService
    {
    Task<TodoItem[]> GetIncompleteItemsAsync();
    }
}