using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Todo.Domain.Entities;
using Todo.Repository.Data;
using Todo.Repository.Interfaces;

namespace Todo.Repository.Repositories
{
    public class ToDoRepository : IToDoRepository
    {
        private DataContext context;

        public ToDoRepository(DataContext context)
        {
            this.context = context;
        }

        public ToDo Get(int id)
        {
            return context.Todos.Include(x => x.items).SingleOrDefault(x => x.id == id);
        }

        public IEnumerable<ToDo> Get()
        {
            return context.Todos.Include(x => x.items).ToList().OrderBy(x => x.id);
        }

        public void Insert(ToDo todo)
        {
            context.Entry(todo).State = EntityState.Added;
            context.SaveChanges();
        }

        public void Update(ToDo todo)
        {
            context.Entry(todo).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            context.Todos.Remove(Get(id));
            context.SaveChanges();
        }
    }
}