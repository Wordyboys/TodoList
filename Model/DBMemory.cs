using Microsoft.EntityFrameworkCore;

namespace TodoMini.Model
{
    public class DBMemory : DbContext
    {

        public DbSet<TodoList> Todo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("MyTodo");
        }
    }
}
