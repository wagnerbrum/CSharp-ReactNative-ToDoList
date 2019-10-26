using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Todo.Domain.Entities;
using Todo.Repository.Data;
using Todo.Repository.Interfaces;

namespace Todo.Repository.Repositories
{
    public class ItemRepository : IItemRepository
    {
        private DataContext context;

        public ItemRepository(DataContext context)
        {
            this.context = context;
        }

        public Item Get(int id)
        {
            return context.Items.Include(x => x.todo).SingleOrDefault(x => x.id == id);
        }

        public IEnumerable<Item> Get()
        {
            return context.Items.Include(x => x.todo).ToList().OrderBy(x => x.id);
        }

        public void Insert(Item item)
        {
            context.Entry(item).State = EntityState.Added;
            context.SaveChanges();
        }

        public void Update(Item item)
        {
            context.Entry(item).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            context.Items.Remove(Get(id));
            context.SaveChanges();
        }
    }
}