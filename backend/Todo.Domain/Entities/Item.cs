namespace Todo.Domain.Entities
{
    public class Item : Entity
    {
        public Item() { }

        public Item(int todoid, string nome, bool state, ToDo todo)
        {
            this.todoid = todoid;
            this.nome = nome;
            this.state = state;
            this.todo = todo;
        }

        public int todoid { get; set; }
        public string nome { get; set; }
        public bool state { get; set; }
        public ToDo todo { get; set; }
    }
}
