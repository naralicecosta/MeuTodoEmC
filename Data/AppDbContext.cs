using Microsoft.EntityFrameworkCore;
using MeuTodo.Models; // Adicione essa linha


namespace MeuTodo.Data
//contexto de dados da nossa aplicação
{
    public class AppDbContext :  DbContext //representação do banco de dados em memória
    {
        public DbSet<Todo> Todos { get; set; } //representação da tabela

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            optionsBuilder.UseSqlite(connectionString: "DataSource=app.db;Cache=Shared");
        }

    }
}