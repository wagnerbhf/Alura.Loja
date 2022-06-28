using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Alura.Loja.Testes.ConsoleApp
{
    public class ProdutoRepository : IProdutoRepository, IDisposable
    {
        private readonly LojaContext _repo;

        public ProdutoRepository()
        {
            _repo = new LojaContext();
        }

        public void Adicionar(Produto produto)
        {
            _repo.Produtos.Add(produto);
            ExibirEntries(_repo.ChangeTracker.Entries());
            _repo.SaveChanges();
            ExibirEntries(_repo.ChangeTracker.Entries());
            Dispose();
        }

        private static void ExibirEntries(IEnumerable<EntityEntry> entries)
        {
            Console.WriteLine("===================");
            foreach (var e in entries)
            {
                Console.WriteLine(e);
            }
        }

        public void Atualizar(Produto produto)
        {
            _repo.Produtos.Update(produto);
            _repo.SaveChanges();
            Dispose();
        }

        public Produto BuscarPorId(int produtoId)
        {
            var produto = _repo.Produtos.FirstOrDefault(p => p.Id == produtoId);
            Dispose();
            return produto;
        }

        public IList<Produto> Listar()
        {
            Dispose();
            return _repo.Produtos.ToList();
        }

        public void Remover(Produto produto)
        {
            _repo.Produtos.Remove(produto);
            _repo.SaveChanges();
            Dispose();
        }

        public void TestChangeTracker()
        {
            var serviceProvider = _repo.GetInfrastructure<IServiceProvider>();
            var loggerFactory = serviceProvider.GetService<ILoggerFactory>();

            loggerFactory.AddProvider(SqlLoggerProvider.Create());


        }

        public void Dispose()
        {
            _repo.Dispose();
        }
    }
}