using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AngularTodo.Models
{
  public partial class AngularTodoContext : DbContext
  {
    public virtual DbSet<Todos> Todos { get; set; }

    public AngularTodoContext(DbContextOptions<AngularTodoContext> options)
        : base(options)
    { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Todos>(entity =>
      {
        entity.Property(e => e.Id).ValueGeneratedNever();

        entity.Property(e => e.Name)
                  .IsRequired()
                  .HasMaxLength(140)
                  .IsUnicode(false);
      });
    }
  }
}
