using System.Data.Entity;

namespace Crud_Repositorio_Mvc.Models
{
    public class LivroContext : DbContext
    {
        public LivroContext()
            : base("name=LivrariaConnectionString")
        {           
        }

        public DbSet<Livro> Livros { get; set; }
    }
}