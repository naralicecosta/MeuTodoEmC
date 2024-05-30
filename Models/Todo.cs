using System;
namespace MeuTodo.Models
{
    public class Todo
    {
        public int Id { get; set; } //id da terefa
        public string Title { get; set; } //titulo da tarefa
        public bool Done { get; set; } //se tarefa esta concluida ou não
        public DateTime Date { get; set; } = DateTime.Now; 
    }
}