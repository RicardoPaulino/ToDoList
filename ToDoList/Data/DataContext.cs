using System.Data.Entity;
using ToDoList.Models;

namespace ToDoList.Data
{
    public class DataContext : DbContext
    {
        public DataContext() : base("ToDoListConn")
        {

        }
        public DbSet<Tarefas> Tarefas { get; set; }
    }
}