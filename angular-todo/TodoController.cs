using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AngularTodo;
using AngularTodo.Models;
using Microsoft.AspNetCore.Mvc;

namespace angular_todo
{
  [Route("api/[controller]")]
  public class TodoController : Controller
  {
    // dependancy injection
    private readonly ITodoService _todoService;

    public TodoController(ITodoService todoService)
    {
      _todoService = todoService;
    }


    [HttpGet]
    public List<Todo> Get()
    {
      List<Todo> todos = new List<Todo>();
      todos = _todoService.GetAll();
      return todos;
    }

    [HttpPost]
    public void Post(Todo todo)
    {

    }
  }
}
