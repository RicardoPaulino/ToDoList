using System;
using System.ComponentModel.DataAnnotations;

namespace ToDoList.Models
{
    public class Tarefas
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime Data { get; set; }
        public bool? Executada { get; set; }
    }
}