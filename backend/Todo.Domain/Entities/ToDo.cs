using System.Collections.Generic;

namespace Todo.Domain.Entities
{
    public class ToDo : Entity
    {
        public ToDo() { }
        public ToDo(int id, string descricao, List<Item> items)
        {
            this.id = id;
            this.descricao = descricao;
            this.items = items;
        }

        public string descricao { get; set; }
        public List<Item> items { get; set; }
    }
}
