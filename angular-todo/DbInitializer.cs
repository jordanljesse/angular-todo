using System.Linq;
using AngularTodo.Models;

namespace AngularTodo
{
  public static class DbInitializer
  {
    public static void Initialize(AngularTodoContext context)
    {
      context.Database.EnsureCreated();

      // Look for any todos
      if (context.Todos.Any())
      {
        return; // DB has been seeded
      }

      var todos = new Todos[]
      {
        new Todos{Id=1, Name="pick up mom from airport"},
        new Todos{Id=2, Name="get groceries"},
        new Todos{Id=3, Name="walk doggo"},
        new Todos{Id=4, Name="buy bread"}
      };

      foreach (Todos todo in todos)
      {
        context.Todos.Add(todo);
      }
      context.SaveChanges();
    }
  }
}
