using System.Collections.Generic;
using AngularTodo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AngularTodo
{
  [Route("api/[controller]")]
  public class TodoController : Controller
  {
    private readonly AngularTodoContext _context;

    public TodoController(AngularTodoContext context)
    {
      _context = context;
    }


    [HttpGet]
    public DbSet<Todos> GetAll()
    {
      var allTodos = _context.Todos;
      return allTodos;
    }

    [HttpPost]
    public IActionResult Add(Todos todo)
    {
      if (ModelState.IsValid)
      {
        _context.Todos.Add(todo);
        _context.SaveChanges();

        return StatusCode(200);
      }

      return StatusCode(400);
    }
  }
}
