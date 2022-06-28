using System.Collections.Generic;

namespace Alura.Loja.Testes.ConsoleApp
{
    interface IProdutoRepository
    {
        void Adicionar(Produto p);
        void Atualizar(Produto p);
        void Remover(Produto p);
        IList<Produto> Listar();
        Produto BuscarPorId(int produtoId);
    }
}