using System.IO;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using AngularTodo.Models;

namespace AngularTodo
{
  public class Startup
  {
    private const string connectionString = "Server=WINDOWS-10-MBP\\SQLEXPRESS;Database=AngularTodo;Trusted_Connection=True;MultipleActiveResultSets=true";

    public static string ConnectionString => connectionString;

    public void ConfigureServices(IServiceCollection services)
    {
      services.AddDbContext<AngularTodoContext>(options =>
        options.UseSqlServer(ConnectionString));

      services.AddMvc();
    }


    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IHostingEnvironment env)
    {
      app.Use(async (context, next) =>
      {
        await next();
        if (context.Response.StatusCode == 404 &&
                  !Path.HasExtension(context.Request.Path.Value) &&
                  !context.Request.Path.Value.StartsWith("/api/"))
        {
          context.Request.Path = "/index.html";
          await next();
        }
      });

      app.UseMvcWithDefaultRoute();
      app.UseDefaultFiles();
      app.UseStaticFiles();
    }
  }
}
