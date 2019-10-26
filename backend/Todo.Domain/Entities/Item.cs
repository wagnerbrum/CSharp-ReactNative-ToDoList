namespace Todo.Domain.Entities
{
    public class Item : Entity
    {
        public Item() { }
        public Item(int id, string nome, ToDo todo)
        {
            this.id = id;
            this.nome = nome;
            this.todo = todo;
        }

        public string nome { get; set; }
        public int todoid { get; set; }
        public ToDo todo { get; set; }
    }
}
