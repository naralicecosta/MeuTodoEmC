using Microsoft.EntityFrameworkCore;
using MeuTodo.Models;


namespace MeuTodo.Data
//contexto de dados da nossa aplicação
{
    public class AppDbContext :  DbContext //representação do banco de dados em memória //permite interagir com o banco de dados
    {
        public DbSet<Todo> Todos { get; set; } //representação da tabela

        //configurar o contexto de banco de dados
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            optionsBuilder.UseSqlite(connectionString: "DataSource=app.db;Cache=Shared"); //configura o provedor SQLite para ser usado como banco de dados
        }

    }
}