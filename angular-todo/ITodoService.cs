using AngularTodo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularTodo
{
  public interface ITodoService
  {
    List<Todo> GetAll();
    void Add(Todo todo);
  }
}
