using Microsoft.EntityFrameworkCore;
using Todo.Domain.Entities;

namespace Todo.Repository.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<ToDo> Todos { get; set; }
        public DbSet<Item> Items { get; set; }
    }
}