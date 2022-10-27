using System;
using System.Collections.Generic;

namespace Crud_Repositorio_Mvc.Models
{
    interface ILivroRepositorio : IDisposable
    {
        IEnumerable<Livro> GetLivros();
        Livro GetLivroPorID(int livroId);
        void InserirLivro(Livro livro);
        void DeletarLivro(int bookID);
        void AtualizaLivro(Livro livro);
        void Salvar();
    }
}
