using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Crud_Repositorio_Mvc.Models
{
    public class LivroRepositorio : ILivroRepositorio
    {
         private LivroContext _context;
         public LivroRepositorio(LivroContext livroContext)
         {
             this._context = livroContext;
         }

        public IEnumerable<Livro> GetLivros()
        {
            return _context.Livros.ToList();
        }

        public Livro GetLivroPorID(int id)
        {
            return _context.Livros.Find(id);
        }

        public void InserirLivro(Livro livro)
        {
           _context.Livros.Add(livro);
        }

        public void DeletarLivro(int livroID)
        {
            Livro livro = _context.Livros.Find(livroID);
            _context.Livros.Remove(livro);
        }

        public void AtualizaLivro(Livro livro)
        {
            _context.Entry(livro).State = EntityState.Modified;
        }

        public void Salvar()
        {
            _context.SaveChanges();
        }

        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}