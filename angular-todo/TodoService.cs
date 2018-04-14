using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AngularTodo.Models;

namespace AngularTodo
{
  public class TodoService
  {

    List<Todo> todos = new List<Todo>();

    public List<Todo> GetAll()
    {
      todos.Add(new Todo
      {
        Id = 1,
        Name = "stuff"
      });

      todos.Add(new Todo
      {
        Id = 2,
        Name = "things"
      });

      return todos;
    }

    public void Add(Todo todo)
    {
      todos.Add(todo);
    }
  }
}
